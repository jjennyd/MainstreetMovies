using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Group_6_Final_Project.Models;

namespace Group6FinalProject.Models.ViewModels
{
    public class ReportViewModel
    {
        // Report on Total Seats and Total Revenue for a specific user
        public string UserID { get; set; }
        public int TotalSeatsPurchased { get; set; }

        // Report on Total Seats Sold and Total Revenue based on movie and time of day
        public string MovieId { get; set; }
        public string TimeOfDay { get; set; }

        // Navigation property to access schedules
        public IEnumerable<Schedule> Schedules { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Week Start Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? SelectedWeekStartDate { get; set; }

        // Properties for overall report
        public decimal TotalRevenueOverall { get; set; }
        public int TotalSeatsSoldOverall { get; set; }
        public int PopcornPoints { get; set; }

        // Properties for specific report
        public int? TotalSeatsSold { get; set; }
        public decimal? TotalRevenue { get; set; }
    }
}