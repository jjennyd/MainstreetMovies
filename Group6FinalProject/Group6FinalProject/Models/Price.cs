using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;


namespace Group_6_Final_Project.Models
{
    public class Price
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PriceID { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        [Column(TypeName = "decimal(18, 2)")]
        public Decimal TicketPrice { get; set; }

        // Add the TicketType property as an enum
        public TicketType TicketType { get; set; }

        // NAVIGATIONAL PROPERTIES
        public List<Schedule> Schedules { get; set; }
    }
}