using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Group_6_Final_Project.DAL;
using Group_6_Final_Project.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using System.Data;
using Group_6_Final_Project.ViewModels;
using Group6FinalProject.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Group_6_Final_Project.Controllers
{
    public class ReportsController : Controller
    {
        private readonly AppDbContext _context;

        public ReportsController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(string customerId, DateTime? startDate, DateTime? endDate, string movieId)
        {
            var totalSeatsSold = _context.TransactionDetails.Sum(td => td.NumberofTickets);
            var totalRevenue = CalculateTotalRevenue();

            var customerTotalSeats = customerId != null
                ? _context.Transactions
                    .Where(t => t.AppUserId == customerId)
                    .Sum(t => t.TransactionDetail.Sum(td => td.NumberofTickets))
                : 0;

            var reportsViewModel = new ReportViewModel
            {
                TotalSeatsSold = totalSeatsSold,
                TotalRevenue = totalRevenue,
            };

            return View(reportsViewModel);
        }

        public IActionResult TotalRevenueReport(DateTime? startDate, DateTime? endDate, string movieTitle, MPAARating? mpaaRating)
        {
            var query = _context.Transactions
                .Where(t => (startDate == null || t.TransactionDate >= startDate) &&
                            (endDate == null || t.TransactionDate <= endDate) &&
                            (string.IsNullOrEmpty(movieTitle) || t.TransactionDetail.Any(td => td.Schedule.Movie.Title.Contains(movieTitle))) &&
                            (!mpaaRating.HasValue || t.TransactionDetail.Any(td => td.Schedule.Movie.MPAARating == mpaaRating)));

            // Calculate total revenue
            var totalRevenue = query.Sum(t => t.TransactionTotal);

            // Calculate total seats sold overall
            var totalSeatsSoldOverall = query.SelectMany(t => t.TransactionDetail)
                .Sum(td => td.NumberofTickets);

            var reportsViewModel = new ReportViewModel
            {
                TotalSeatsSoldOverall = totalSeatsSoldOverall,
                TotalRevenueOverall = totalRevenue,
            };

            return View("Index", reportsViewModel);
        }

        public IActionResult CustomerReport(string customerId, DateTime? startDate, DateTime? endDate, string movieId)
        {
            // Calculate total seats sold for the customer
            var totalSeatsSold = _context.Transactions
                .Where(t => t.AppUserId == customerId &&
                            (startDate == null || t.TransactionDate >= startDate) &&
                            (endDate == null || t.TransactionDate <= endDate))
                .Sum(t => t.TransactionDetail.Sum(td => td.NumberofTickets));

            // Calculate total revenue for the customer
            var totalRevenue = _context.Transactions
                .Where(t => t.AppUserId == customerId &&
                            (startDate == null || t.TransactionDate >= startDate) &&
                            (endDate == null || t.TransactionDate <= endDate))
                .Sum(t => t.TransactionTotal);

            var reportsViewModel = new ReportViewModel
            {
                TotalSeatsSold = totalSeatsSold,
                TotalRevenue = totalRevenue,
            };

            return View("Index", reportsViewModel);
        }

        public IActionResult PopcornPointsReport(DateTime? startDate, DateTime? endDate, string movieId)
        {
            // Calculate popcorn points logic (replace this with your actual logic)
            var popcornPoints = _context.Transactions
                .Where(t => (startDate == null || t.TransactionDate >= startDate) &&
                            (endDate == null || t.TransactionDate <= endDate) &&
                            (movieId == null || t.TransactionDetail.Any(td => td.Schedule.MovieID == movieId)))
                .Sum(t => CalculatePopcornPointsForTransaction(t));

            var reportsViewModel = new ReportViewModel
            {
                PopcornPoints = popcornPoints,
            };

            return View("Index", reportsViewModel);
        }

        // Example method to calculate popcorn points for a transaction (replace this with your actual logic)
        private int CalculatePopcornPointsForTransaction(Transaction transaction)
        {
            // Your popcorn points logic based on the transaction details, movie, etc.
            // Replace this with your actual logic for calculating popcorn points.

            // For example, you might give 1 popcorn point for each $10 spent.
            int points = (int)(transaction.TransactionTotal / 10);

            return points;
        }

        private decimal CalculateTotalRevenue()
        {
            var totalRevenue = _context.Transactions.Sum(t => t.TransactionTotal);
            return totalRevenue;
        }
    }
}
