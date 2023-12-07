using System;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using Group_6_Final_Project.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Group_6_Final_Project.Models
{
    public enum GenreType { Horror, Drama, Action, Comedy, Children_Family, Romance, Musical, SciFi }

    public class Genre
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GenreID { get; set; }

        public GenreType GenreType { get; set; }

        //NAVIGATIONAL PROPERTIES
        public List<Movie> Movie { get; set; }
    }
}