using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Group_6_Final_Project.DAL;
using Group_6_Final_Project.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace Group6FinalProject.Controllers
{
    public class ReviewController : Controller
    {
        private readonly AppDbContext _context;

        public ReviewController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Review
        [Authorize]
        public async Task<IActionResult> Index()
        {
            // Setup list of reviews to display
            List<Review> reviews;

            if (User.IsInRole("Manager") || User.IsInRole("Employee"))
            {
                // Show all reviews
                reviews = _context.Reviews
                          .Include(r => r.Movies)
                          .ToList();

                // Truncate the description for the view aesthetic
                foreach (var review in reviews)
                {
                    review.Description = TruncateDescription(review.Description, 30);
                }

                return View(reviews);
            }

            else if (User.IsInRole("Customer"))
            {
                // Get the current user's ID
                var currentUserID = User.FindFirstValue(ClaimTypes.NameIdentifier);

                // Filter reviews based on the current user's ID
                reviews = _context.Reviews
                          .Include(r => r.Movies)
                          .Where(r => r.UserID == currentUserID)
                          .ToList();

                // Truncate the description for the view aesthetic
                foreach (var review in reviews)
                {
                    review.Description = TruncateDescription(review.Description, 30);
                }

                return View(reviews);
            }
            return View();
        }

        // GET: Review/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Reviews == null)
            {
                return View("Error", new String[] { "Please specify a review to view!" });
            }

            Review review = await _context.Reviews
                            .Include(r => r.Movies)
                            .FirstOrDefaultAsync(m => m.ReviewID == id);

            if (review == null)
            {
                return View("Error", new String[] { "That review was not found." });
            }

            return View(review);
        }

        // GET: Review/Create
        [Authorize]
        public IActionResult Create(string movieId)
        {
            if (movieId == null)
            {
                return RedirectToAction("Index");
            }

            ViewBag.MovieID = new SelectList(_context.Movies, "MovieID", "Title");
            ViewBag.SelectedMovieID = movieId;

            return View();
        }

        // POST: Review/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Customer")]
        public async Task<IActionResult> Create([Bind("Rating, Description, MovieID")] Review review)
        {
            if (ModelState.IsValid)
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                // Check if the user has already submitted a review for the same movie
                var existingReview = _context.Reviews
                    .FirstOrDefault(r => r.MovieID == review.MovieID && r.UserID == userId);

                if (existingReview != null)
                {
                    ViewBag.ReviewCreateError = "You have already submitted a review for this movie.";
                    ViewBag.MovieID = new SelectList(_context.Movies, "MovieID", "Title", review.MovieID);
                    return View(review);
                }

                // Set additional properties for the review
                review.UserID = userId;
                review.Status = Status.NeedsReview;

                // Add the review to the database
                _context.Add(review);
                await _context.SaveChangesAsync();

                // Redirect the user to the review index page
                return RedirectToAction(nameof(Index));
            }

            // If ModelState is not valid, reload the view with the form data
            ViewBag.MovieID = new SelectList(_context.Movies, "MovieID", "Title", review.MovieID);
            return View(review);
        }

        // GET: Review/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Reviews == null)
            {
                return NotFound();
            }

            var review = await _context.Reviews.FindAsync(id);
            if (review == null)
            {
                return NotFound();
            }

            // Fetch the corresponding movie title based on MovieID
            var selectedMovie = _context.Movies.FirstOrDefault(m => m.MovieID == review.MovieID);

            ViewBag.MovieTitle = selectedMovie.Title;

            ViewData["MovieID"] = new SelectList(_context.Movies, "MovieID", "MovieID", review.MovieID);
            return View(review);
        }

        // POST: Review/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Edit(int id, [Bind("ReviewID,Rating,Description,Status,UserID,MovieID")] Review review)
        {
            // Check if the user is a manager or employee
            if (User.Identity.IsAuthenticated)
            {
                // Allow managers and employees to modify Rating and Description
                if (ModelState.IsValid)
                {
                    // Change back to ReviewPending
                    review.Status = Status.NeedsReview;

                    _context.Update(review);
                    await _context.SaveChangesAsync();

                    return RedirectToAction(nameof(Index));
                }
            }

            ViewData["MovieID"] = new SelectList(_context.Movies, "MovieID", "MovieID", review.MovieID);
            return View(review);
        }

        private string TruncateDescription(string description, int maxLength, string suffix = "...")
        {
            if (description != null && description.Length > maxLength)
            {
                description = description.Substring(0, maxLength) + suffix;
            }

            return description;
        }

        private bool ReviewExists(int id)
        {
            return (_context.Reviews?.Any(e => e.ReviewID == id)).GetValueOrDefault();
        }
    }
}
