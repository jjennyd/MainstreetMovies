using Microsoft.AspNetCore.Identity;
using Group_6_Final_Project.Utilities;
using Group_6_Final_Project.DAL;
using Group_6_Final_Project.Models;
using Microsoft.SqlServer.Server;
using static System.Reflection.Metadata.BlobBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;

namespace Group_6_Final_Project.Seeding
{
    public static class SeedPrices
    {
        public static void Prices(AppDbContext db)
        {
            // Create a counter and a flag to know which record is causing problems
            int intPricesAdded = 0;
            int intPricesID = 0;

            // Add the list of Prices
            List<Price> Prices = new List<Price>();

            Prices.Add(new Price
            {
                TicketType = TicketType.SpecialEvent,
                TicketPrice = 15
            });

            Prices.Add(new Price
            {
                TicketType = TicketType.Matinee,
                TicketPrice = 5
            });

            Prices.Add(new Price
            {
                TicketType = TicketType.WeekdayBase,
                TicketPrice = 10
            });

            Prices.Add(new Price
            {
                TicketType = TicketType.DiscountTuesday,
                TicketPrice = 8
            });

            Prices.Add(new Price
            {
                TicketType = TicketType.Weekends,
                TicketPrice = 12
            });

            try
            {
                // Loop through each of the Prices in the list
                foreach (Price PricesToAdd in Prices)
                {
                    // Set the flag to the current title to help with debugging
                    intPricesID = PricesToAdd.PriceID;

                    // Look to see if the Prices is in the database - this assumes that no
                    // two Prices have the same title
                    Price dbPrices = db.Prices.FirstOrDefault(b => b.PriceID == PricesToAdd.PriceID);

                    if (dbPrices == null)
                    {
                        // Prices not in the database, so add it
                        db.Prices.Add(PricesToAdd);
                    }
                    else
                    {
                        // Prices is in the database, so update its properties
                        dbPrices.TicketType = PricesToAdd.TicketType;
                        dbPrices.TicketPrice = PricesToAdd.TicketPrice;
                    }

                    // Save changes to the database
                    db.SaveChanges();

                    // Update the counter to help with debugging
                    intPricesAdded++;
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                string msg = "Prices added: " + intPricesAdded + "; Error on " + intPricesID;
                throw new InvalidOperationException(ex.Message + msg);
            }
        }
    }
}
