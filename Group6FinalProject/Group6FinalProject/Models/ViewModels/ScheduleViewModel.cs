using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Group_6_Final_Project.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Group_6_Final_Project.ViewModels
{
    public class ScheduleViewModel
    {
        public IEnumerable<Schedule> Schedules { get; set; }

        public IEnumerable<string> TheatreOptions { get; set; }

        public Theatre? SelectedTheatre { get; set; }

        public MPAARating? SelectedMPAARating { get; set; }

        [DataType(DataType.Date)]
        public DateTime? SelectedWeekStartDate { get; set; }

        public String? searchString { get; set; }

        public string MovieID { get; set; }

        [Required(ErrorMessage = "Movie title is required")]
        [Display(Name = "Title: ")]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }

        // Add IsPublished property
        [Display(Name = "Is Published")]
        public bool IsPublished { get; set; } = true; // Default to true
    }
}
