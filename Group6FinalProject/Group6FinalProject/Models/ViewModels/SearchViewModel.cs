using System;
using System.ComponentModel.DataAnnotations;

namespace Group_6_Final_Project.Models
{
    public enum SearchType { GreaterThan, LessThan }

    public class SearchViewModel
    {
        [Display(Name = "Search by Title:")]
        public string SearchTitle { get; set; }

        [Display(Name = "Search by Description:")]
        public string SearchDescription { get; set; }

        [Display(Name = "Search by Tagline:")]
        public string SearchTagline { get; set; }

        [Display(Name = "Search by Published Date:")]
        public string SelectedYear { get; set; }

        [Display(Name = "Search by Actors:")]
        public string SearchActors { get; set; }

        [Display(Name = "Search by Runtime:")]
        public TimeSpan? SelectedRuntime { get; set; }

        [Display(Name = "Search by Genre:")]
        public int? SelectedGenreID { get; set; }

        [Display(Name = "Search Type:")]
        public SearchType SearchType { get; set; }

        [Display(Name = "Minimum User Rating:")]
        [Range(1, 5, ErrorMessage = "User Rating must be between 1 and 5.")]
        public int SelectedRating { get; set; }

        [Display(Name = "Maximum User Rating:")]
        [Range(1, 5, ErrorMessage = "User Rating must be between 1 and 5.")]
        public int? MaxUserRating { get; set; }

    }
}