using System;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using Group_6_Final_Project.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Group_6_Final_Project.Models
{
    public enum Status { Approved, NeedsReview };

    public class Review
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReviewID { get; set; }

        [Required]
        [Display(Name = "Rating: ")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
        public int Rating { get; set; }

        [MaxLength(280, ErrorMessage = "Review cannot be more than 280 characters.")]
        [Display(Name = "Description: ")]
        public string Description { get; set; }

        [Display(Name = "Status:")]
        public Status Status { get; set; }

        public string UserID { get; set; }  // Foreign key for the Product

        public string MovieID { get; set; }  // Foreign key for the Product
        public Movie Movies { get; set; }

        public AppUser User { get; set; } // Navigational to only display reviews of a specific user
    }
}