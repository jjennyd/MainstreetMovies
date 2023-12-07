using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Group_6_Final_Project.Models
{
    public enum Theatre { Theatre1, Theatre2 }
    public enum TicketType { WeekdayBase, Matinee, DiscountTuesday, Weekends, SpecialEvent }

    public class Schedule
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ScheduleID { get; set; }

        [Display(Name = "Start Time:")]
        public DateTime StartTime { get; set; }

        [Display(Name = "Theater:")]
        public Theatre Theatre { get; set; }

        [Display(Name = "Ticket Type:")]
        public TicketType TicketType { get; set; }

        public int PriceID { get; set; }  // Foreign key for the Price

        public bool IsPublished { get; set; } = true; // Default value set to true

        public List<string> AvailableSeats
        {
            get
            {
                return GetAvailableSeats();
            }
        }

        public Schedule()
        {
            TransactionDetails ??= new List<TransactionDetail>();
        }

        private List<string> GetAvailableSeats()
        {
            var allSeats = GenerateInitialSeats();

            // Convert selectedSeats to a list of strings
            var selectedSeatsStrings = TransactionDetails.Select(td => td.SeatSelection.ToString()).ToList();

            return allSeats.Except(selectedSeatsStrings).ToList();
        }

        private List<string> GenerateInitialSeats()
        {
            var seats = new List<string>();
            for (int i = 1; i <= 25; i++)
            {
                seats.Add($"A{i}");
            }
            return seats;
        }

        // NAVIGATIONAL PROPERTIES

        [ForeignKey("PriceID")]
        public Price Price { get; set; }

        public string MovieID { get; set; }  // Foreign key for the Movie
        public Movie Movie { get; set; }

        public List<TransactionDetail> TransactionDetails { get; set; }
    }
}
