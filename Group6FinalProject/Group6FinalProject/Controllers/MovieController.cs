using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Group_6_Final_Project.Models;
using Group_6_Final_Project.DAL;

namespace Group_6_Final_Project.Controllers
{
    public class MovieController : Controller
    {
        private readonly AppDbContext _context;

        public MovieController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Movie
        public async Task<IActionResult> Index(string? searchString)
        {
            // Retrieve movies including the Genre information and reviews
            var movies = await _context.Movies
                .Include(m => m.Genre)
                .Include(m => m.Review)
                .ToListAsync();

            // Check if SearchString is null, else query a search with specified string
            if (searchString == null)
            {
                // Display all movies
                ViewBag.CurrentlyShowingMovies = _context.Movies.Count();
                ViewBag.TotalMovieCount = _context.Movies.Count();

                return View(_context.Movies.ToList());
            }
            else
            {
                // Limit query based on searchString
                movies = movies.Where(m => m.Title.Contains(searchString, StringComparison.OrdinalIgnoreCase)
                                      || m.Genre.ToString().Contains(searchString, StringComparison.OrdinalIgnoreCase))
                               .ToList();

                ViewBag.CurrentlyShowingMovies = movies.Count();
                ViewBag.TotalMovieCount = _context.Movies.Count();

                return View(movies);
            }
        }

        // GET: Movie/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Movies == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies
                .Include(m => m.Genre) // Include the Genre information
                .FirstOrDefaultAsync(m => m.MovieID == id);

            if (movie == null)
            {
                return NotFound();
            }

            // Fetch reviews for the movie
            var reviews = await _context.Reviews
                .Where(r => r.MovieID == id)
                .ToListAsync();

            // Calculate average customer review
            double averageRating = reviews.Any() ? reviews.Average(r => (int)r.Rating) : 0.0;

            ViewBag.AverageCustomerReview = averageRating;

            // Pass the reviews to the view
            ViewBag.Reviews = reviews;

            return View(movie);
        }

        // GET: Movie/Create
        public IActionResult Create()
        {
            // Populate ViewBag.GenreList with available genres
            ViewBag.GenreList = new SelectList(_context.Genres, "GenreID", "GenreType");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MovieID,MPAARating,Title,Description,Tagline,PublishedDate,Actors,Runtime,GenreID")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                _context.Add(movie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            // Check ModelState errors here (use debugger)
            var errors = ModelState.Values.SelectMany(v => v.Errors);
            // Add a breakpoint here to inspect errors

            ViewBag.GenreList = new SelectList(_context.Genres, "GenreID", "Genres", movie.GenreID);
            return View(movie);
        }


        // GET: Movie/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }

            // Populate ViewBag.Genres with the list of genres
            ViewBag.Genres = new SelectList(_context.Genres, "GenreID", "GenreType", movie.GenreID);

            return View(movie);
        }

        // POST: Movie/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MovieID,MPAARating,Title,Description,Tagline,PublishedDate,Actors,Runtime,GenreID")] Movie movie)
        {
            if (id != movie.MovieID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(movie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovieExists(movie.MovieID))
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

            ViewBag.GenreList = new SelectList(_context.Genres, "GenreID", "Genres", movie.GenreID);
            return View(movie);
        }

        private bool MovieExists(string id)
        {
            return _context.Movies.Any(e => e.MovieID == id);
        }

        // GET: Movie/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Movies == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies
                .FirstOrDefaultAsync(m => m.MovieID == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // POST: Movie/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Movies == null)
            {
                return Problem("Entity set 'AppDbContext.Movies'  is null.");
            }
            var movie = await _context.Movies.FindAsync(id);
            if (movie != null)
            {
                _context.Movies.Remove(movie);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private SelectList GetGenreSelectList()
        {
            var genres = _context.Genres.ToList();
            genres.Insert(0, new Genre { GenreID = 0, GenreType = GenreType.Action });

            return new SelectList(genres, "GenreID", "GenreType");
        }

        // Allow user to run a detailed search for movies
        public IActionResult DetailedSearch()
        {
            ViewBag.GenreList = GetGenreSelectList();

            // Default properties
            SearchViewModel searchViewModel = new SearchViewModel();

            return View(searchViewModel);
        }

        public IActionResult DisplaySearchResults(SearchViewModel searchViewModel)
        {
            // Filter movies using LINQ
            var query = from movie in _context.Movies
                        select movie;

            // Check if user entered a title
            if (searchViewModel.SearchTitle != null)
            {
                query = query.Where(m => m.Title.Contains(searchViewModel.SearchTitle));
            }

            // Check if user entered a description
            if (searchViewModel.SearchDescription != null)
            {
                query = query.Where(m => m.Description.Contains(searchViewModel.SearchDescription));
            }

            if (searchViewModel.SelectedGenreID != 0)
            {
                query = query.Where(jp => jp.Genre.GenreID == searchViewModel.SelectedGenreID);
            }

            if (searchViewModel.SelectedYear != null)
            {
                switch (searchViewModel.SearchType)
                {
                    case SearchType.GreaterThan:
                        query = query.Where(movie => movie.PublishedDate >= Int32.Parse(searchViewModel.SelectedYear));
                        break;
                    case SearchType.LessThan:
                        query = query.Where(movie => movie.PublishedDate <= Int32.Parse(searchViewModel.SelectedYear));
                        break;
                }
            }

            if (searchViewModel.SearchActors != null)
            {
                query = query.Where(m => m.Actors.Contains(searchViewModel.SearchActors));
            }

            if (searchViewModel.SelectedRuntime != null)
            {
                switch (searchViewModel.SearchType)
                {
                    case SearchType.GreaterThan:
                        query = query.Where(movie => movie.Runtime >= searchViewModel.SelectedRuntime);
                        break;
                    case SearchType.LessThan:
                        query = query.Where(movie => movie.Runtime <= searchViewModel.SelectedRuntime);
                        break;
                }
            }

            // Ensure query is materialized before using it
            var selectedMovies = query.Include(m => m.Genre).ToList();

            // Calculate average user rating for each selected movie
            Dictionary<string, double> averageRatings = new Dictionary<string, double>();
            foreach (var movie in selectedMovies)
            {
                var ratings = _context.Reviews
                    .Where(review => review.MovieID == movie.MovieID && review.Status == Status.Approved)
                    .Select(review => (int)review.Rating);

                if (ratings.Any())
                {
                    averageRatings[movie.MovieID] = ratings.Average();
                }
                else
                {
                    averageRatings[movie.MovieID] = 0; // or another default value
                }
            }

            //if (searchViewModel.SelectedRating != 0)
            //{
            //    switch (searchViewModel.SearchType)
            //    {
            //        case SearchType.GreaterThan:
            //            query = query.Where(searchViewModel.SelectedRating >= ViewBag.AverageRatings);
            //            break;
            //        case SearchType.LessThan:
            //            query = query.Where(movie => movie.Runtime <= searchViewModel.SelectedRuntime);
            //            break;
            //    }
            //}

            // Pass the average ratings dictionary to the view
            ViewBag.AverageRatings = averageRatings;

            // Set the GenreList in ViewBag
            ViewBag.GenreList = GetGenreSelectList();

            ViewBag.AllMovies = _context.Movies.Count();
            ViewBag.SelectedMovies = selectedMovies.Count();

            // Update the ViewBag properties and return the Index view
            ViewBag.TotalMovieCount = selectedMovies.Count();
            ViewBag.CurrentlyShowingMovies = selectedMovies.Count();

            return View("Index", selectedMovies.OrderByDescending(m => m.PublishedDate));
        }
    }
}