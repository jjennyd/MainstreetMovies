using Group_6_Final_Project.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Group_6_Final_Project.Models
{
    public class AppUser : IdentityUser
    {
        [Display(Name = "First Name: ")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name: ")]
        public string LastName { get; set; }

        [Display(Name = "Full Name")]
        public String FullName
        {
            get { return FirstName + " " + LastName; }
        }

        [Display(Name = "Date of Birth: ")]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Address Line 1")]
        public string AddressLine1 { get; set; }

        [Display(Name = "Address Line 2")]
        public string? AddressLine2 { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "State")]
        public string State { get; set; }

        [Display(Name = "Zip")]
        public string Zip { get; set; }


        [Display(Name = "Total Popcorn Points")]
        public int TotalPopcornPoints
        {
            get
            {
                // Ensure Transactions is not null
                if (Transactions == null)
                {
                    return 0;
                }

                // Sum PopcornPoints from all Transactions
                return Transactions.Sum(tr => tr.PopcornPoints);
            }
        }
        public virtual List<Transaction> Transactions { get; set; }
    }
}
