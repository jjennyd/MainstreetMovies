using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Group_6_Final_Project.DAL;
using Group_6_Final_Project.Models;
using Group_6_Final_Project.ViewModels;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace Group6FinalProject.Controllers
{
    public class ScheduleController : Controller
    {
        private readonly AppDbContext _context;

        public ScheduleController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Schedule/Index
        public async Task<IActionResult> Index(DateTime? startDate, DateTime? endDate, int? movieId)
        {
            var schedulesQuery = GetFilteredSchedules(null, startDate, endDate, null, null, movieId);

            //// Apply IsPublished filter for non-Manager users
            //if (!User.Identity.IsAuthenticated || !User.IsInRole("Manager"))
            //{
            //    schedulesQuery = schedulesQuery.Where(s => s.IsPublished);
            //}

            var viewModel = new ScheduleViewModel
            {
                Schedules = await schedulesQuery.ToListAsync(),
                TheatreOptions = _context.Schedules.Select(s => s.Theatre.ToString()).Distinct(),
                IsPublished = User.Identity.IsAuthenticated && User.IsInRole("Manager") // Managers can see all, others see only published
            };

            ViewBag.AllMovieSchedule = viewModel.Schedules.Count();
            ViewBag.FilteredMovieSchedule = viewModel.Schedules.Count();

            return View(viewModel);
        }



        // POST: Schedule/Index
        [HttpPost]
        public IActionResult Index(ScheduleViewModel viewModel)
        {
            // Convert MovieID from string to int?
            int? movieId = null;
            if (!string.IsNullOrEmpty(viewModel.MovieID) && int.TryParse(viewModel.MovieID, out int parsedMovieId))
            {
                movieId = parsedMovieId;
            }

            // Fetch the schedules based on the filters provided in the viewModel
            var schedulesQuery = GetFilteredSchedules(viewModel.SelectedTheatre, viewModel.StartDate, viewModel.EndDate, viewModel.searchString, viewModel.SelectedMPAARating, movieId);

            // Always apply the IsPublished filter based on the toggle state
            schedulesQuery = schedulesQuery.Where(s => s.IsPublished == viewModel.IsPublished);

            // Execute the query and update the viewModel
            viewModel.Schedules = schedulesQuery.ToList();
            viewModel.TheatreOptions = _context.Schedules.Select(s => s.Theatre.ToString()).Distinct();

            // Update ViewBag
            ViewBag.AllMovieSchedule = viewModel.Schedules.Count();
            ViewBag.FilteredMovieSchedule = viewModel.Schedules.Count();

            return View(viewModel);
        }





        // GET: Schedule/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Schedules == null)
            {
                return NotFound();
            }

            var schedule = await _context.Schedules
                .Include(s => s.Movie)
                .Include(s => s.Price)
                .FirstOrDefaultAsync(m => m.ScheduleID == id);
            if (schedule == null)
            {
                return NotFound();
            }

            return View(schedule);
        }

        // GET: Schedule/Create
        public IActionResult Create()
        {
            var prices = _context.Prices.ToList();
            var movies = _context.Movies.ToList();

            // Populate ViewBag.PriceID with the list of Price entities
            ViewBag.PriceID = new SelectList(prices, "PriceID", "PriceID");

            // Populate ViewBag.MovieID with the list of Movie entities
            ViewBag.MovieID = new SelectList(movies, "MovieID", "Title");

            ViewBag.TicketTypes = new SelectList(Enum.GetValues(typeof(TicketType)));
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ScheduleID,StartTime,Theatre,TicketType,MovieID, IsPublished")] Schedule schedule)
        {
            if (ModelState.IsValid)
            {
                // Set TicketType based on the selected value in the form
                Enum.TryParse(Request.Form["TicketType"], out TicketType selectedTicketType);
                schedule.TicketType = selectedTicketType;

                // Set PriceID based on TicketType
                SetPriceBasedOnTicketType(schedule);

                // Check for time gaps between movies
                var previousMovieEndTime = _context.Schedules
                    .Where(s => s.Theatre == schedule.Theatre && s.StartTime < schedule.StartTime)
                    .OrderByDescending(s => s.StartTime)
                    .Select(s => s.StartTime.AddMinutes(s.Movie.Runtime.TotalMinutes + 25)) // Use Runtime property
                    .FirstOrDefault();

                if (previousMovieEndTime != default && (schedule.StartTime - previousMovieEndTime).TotalMinutes < 25)
                {
                    // Less than 25 minutes between movies, display an error
                    ModelState.AddModelError("StartTime", "There must be at least 25 minutes between movies.");
                }

                // Check for more than 45 minutes gap between movies
                var nextMovieStartTime = _context.Schedules
                    .Where(s => s.Theatre == schedule.Theatre && s.StartTime > schedule.StartTime)
                    .OrderBy(s => s.StartTime)
                    .Select(s => s.StartTime)
                    .FirstOrDefault();

                if (nextMovieStartTime != default && (nextMovieStartTime - schedule.StartTime).TotalMinutes > 45)
                {
                    // More than 45 minutes between movies, display an error
                    ModelState.AddModelError("StartTime", "There should not be more than 45 minutes between movies.");
                }

                if (ModelState.IsValid)
                {
                    // If all checks passed, save the schedule
                    _context.Add(schedule);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }

            // Repopulate dropdowns in case of validation errors
            ViewData["MovieID"] = new SelectList(_context.Movies, "MovieID", "Title", schedule.MovieID);
            ViewBag.TicketTypes = new SelectList(Enum.GetValues(typeof(TicketType)), schedule.TicketType);

            return View(schedule);
        }

        // GET: Schedule/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Schedules == null)
            {
                return NotFound();
            }

            var schedule = await _context.Schedules.FindAsync(id);
            if (schedule == null)
            {
                return NotFound();
            }

            var prices = _context.Prices.ToList();

            // Populate ViewBag.PriceID with the list of Price entities
            ViewBag.PriceID = new SelectList(prices, "PriceID", "PriceID", schedule.PriceID);

            ViewData["MovieID"] = new SelectList(_context.Movies, "MovieID", "Title", schedule.MovieID);
            ViewBag.TicketTypes = new SelectList(Enum.GetValues(typeof(TicketType)), schedule.TicketType);
            return View(schedule);
        }

        // POST: Schedule/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ScheduleID,StartTime,Theatre,TicketType,MovieID, IsPublished")] Schedule schedule)
        {
            if (id != schedule.ScheduleID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    SetPriceBasedOnTicketType(schedule);
                    _context.Update(schedule);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ScheduleExists(schedule.ScheduleID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            ViewData["MovieID"] = new SelectList(_context.Movies, "MovieID", "Title", schedule.MovieID);
            ViewBag.TicketTypes = new SelectList(Enum.GetValues(typeof(TicketType)), schedule.TicketType);
            return View(schedule);
        }


        // GET: Schedule/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Schedules == null)
            {
                return NotFound();
            }

            var schedule = await _context.Schedules
                .Include(s => s.Movie)
                .Include(s => s.Price)
                .FirstOrDefaultAsync(m => m.ScheduleID == id);
            if (schedule == null)
            {
                return NotFound();
            }

            return View(schedule);
        }

        // POST: Schedule/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Schedules == null)
            {
                return Problem("Entity set 'AppDbContext.Schedules'  is null.");
            }
            var schedule = await _context.Schedules.FindAsync(id);
            if (schedule != null)
            {
                _context.Schedules.Remove(schedule);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private IQueryable<Schedule> GetFilteredSchedules(Theatre? selectedTheatre, DateTime? startDate, DateTime? endDate, string? searchString, MPAARating? selectedMPAARating, int? movieId)
        {
            var schedulesQuery = _context.Schedules.Include(s => s.Movie).Include(s => s.Price).AsQueryable();

            // Filter by theatre
            if (selectedTheatre.HasValue)
            {
                schedulesQuery = schedulesQuery.Where(s => s.Theatre == selectedTheatre.Value);
            }

            // Filter by start date
            if (startDate.HasValue)
            {
                schedulesQuery = schedulesQuery.Where(s => s.StartTime.Date >= startDate.Value.Date);
            }

            // Filter by end date
            if (endDate.HasValue)
            {
                schedulesQuery = schedulesQuery.Where(s => s.StartTime.Date <= endDate.Value.Date);
            }

            // Filter by MPAARating
            if (selectedMPAARating.HasValue)
            {
                schedulesQuery = schedulesQuery.Where(s => s.Movie.MPAARating == selectedMPAARating.Value);
            }

            // Filter by search string
            if (!string.IsNullOrEmpty(searchString))
            {
                var searchLower = searchString.ToLower();
                schedulesQuery = schedulesQuery.Where(m => m.Movie.Title.ToLower().Contains(searchLower) || m.Movie.Description.ToLower().Contains(searchLower));
            }

            // Filter by movieId
            if (movieId.HasValue)
            {
                // Convert movieId to string for comparison
                string movieIdString = movieId.Value.ToString();
                schedulesQuery = schedulesQuery.Where(s => s.Movie.MovieID == movieIdString);
            }
            return schedulesQuery;
        }


        [HttpPost]
        [Authorize(Roles = "Manager")] // Ensure only managers can access this
        public async Task<IActionResult> PublishSchedule(int id)
        {
            var schedule = await _context.Schedules.FindAsync(id);
            if (schedule == null)
            {
                return NotFound();
            }

            schedule.IsPublished = true;
            _context.Update(schedule);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        private void SetPriceBasedOnTicketType(Schedule schedule)
        {
            switch (schedule.TicketType)
            {
                case TicketType.WeekdayBase:
                    schedule.PriceID = 1;
                    break;
                case TicketType.Matinee:
                    schedule.PriceID = 2;
                    break;
                case TicketType.DiscountTuesday:
                    schedule.PriceID = 3;
                    break;
                case TicketType.Weekends:
                    schedule.PriceID = 4;
                    break;
                case TicketType.SpecialEvent:
                    schedule.PriceID = 5;
                    break;
                default:
                    // Handle any other cases or provide a default price
                    break;
            }
        }
        private bool ScheduleExists(int id)
        {
            return _context.Schedules.Any(e => e.ScheduleID == id);
        }
    }
}
