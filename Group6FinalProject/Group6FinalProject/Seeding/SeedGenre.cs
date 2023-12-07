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
    public static class SeedGenre
    {
        public static void Genres(AppDbContext db)
        {
            // Create a counter and a flag to know which record is causing problems
            int intGenresAdded = 0;
            int intGenresID = 0;

            // Add the list of Genres
            List<Genre> Genres = new List<Genre>();

            Genres.Add(new Genre
            {
                GenreType = GenreType.Horror
            });

            Genres.Add(new Genre
            {
                GenreType = GenreType.Drama
            });

            Genres.Add(new Genre
            {
                GenreType = GenreType.Action
            });

            Genres.Add(new Genre
            {
                GenreType = GenreType.Comedy
            });

            Genres.Add(new Genre
            {
                GenreType = GenreType.Children_Family
            });

            Genres.Add(new Genre
            {
                GenreType = GenreType.Romance
            });

            Genres.Add(new Genre
            {
                GenreType = GenreType.Musical
            });

            Genres.Add(new Genre
            {
                GenreType = GenreType.SciFi
            });

            try
            {
                // Loop through each of the Genres in the list
                foreach (Genre GenresToAdd in Genres)
                {
                    // Set the flag to the current title to help with debugging
                    intGenresID = GenresToAdd.GenreID;

                    // Look to see if the Genres is in the database - this assumes that no
                    // two Genres have the same title
                    Genre dbGenres = db.Genres.FirstOrDefault(b => b.GenreID == GenresToAdd.GenreID);

                    if (dbGenres == null)
                    {
                        // Genres not in the database, so add it
                        db.Genres.Add(GenresToAdd);
                    }
                    else
                    {
                        // Genres is in the database, so update its properties
                        dbGenres.GenreType = GenresToAdd.GenreType;
                    }

                    // Save changes to the database
                    db.SaveChanges();

                    // Update the counter to help with debugging
                    intGenresAdded++;
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                string msg = "Genres added: " + intGenresAdded + "; Error on " + intGenresID;
                throw new InvalidOperationException(ex.Message + msg);
            }
        }
    }
}
