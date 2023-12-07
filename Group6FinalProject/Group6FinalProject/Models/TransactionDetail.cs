using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Group_6_Final_Project.Models
{
    public enum SeatSelection { A1, A2, A3, A4, A5, B1, B2, B3, B4, B5, C1, C2, C3, C4, C5, D1, D2, D3, D4, D5, E1, E2, E3, E4, E5 }

    public enum PaymentMethod { CashCard, Points }

    public class TransactionDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TransactionDetailID { get; set; }

        [Range(1, 25, ErrorMessage = "Number of Tickets must be between 1 and 25")]
        [Display(Name = "Number of Tickets")]
        public int NumberofTickets { get; set; }

        public SeatSelection SeatSelection { get; set; }

        public PaymentMethod PaymentMethod { get; set; }

        [Display(Name = "Schedule Price")]
        public decimal SchedulePrice { get; set; }

        [Display(Name = "Extended Price")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal ExtendedPrice
        {
            get
            {
                // Calculate the extended price by multiplying number of tickets by schedule price
                return NumberofTickets * SchedulePrice;
            }
            private set { }
        }

        [Display(Name = "Senior Discount")]
        public bool SeniorDiscount { get; set; }

        public int TransactionID { get; set; } // Foreign key for the Transaction
        public Transaction Transaction { get; set; }

        public int ScheduleID { get; set; } // Foreign key for the Schedule
        public Schedule Schedule { get; set; }
    }
}