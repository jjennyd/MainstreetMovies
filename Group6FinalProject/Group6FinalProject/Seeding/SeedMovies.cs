using Microsoft.AspNetCore.Identity;
using Group_6_Final_Project.Utilities;
using Group_6_Final_Project.DAL;
using Group_6_Final_Project.Models;
using Microsoft.SqlServer.Server;
using static System.Reflection.Metadata.BlobBuilder;

namespace Group_6_Final_Project.Seeding
{
    public static class SeedMovies
    {
        public static void Movie(AppDbContext db)
        {
            //Create a counter and a flag so we will know which record is causing problems
            Int32 intMovieAdded = 0;
            String strMovieTitle = "Begin";

            //Add the list of movies
            List<Movie> Movies = new List<Movie>();

            Movies.Add(new Movie
            {
                Title = "Jurassic Park",
                Description = "A pragmatic paleontologist touring an almost complete theme park on an island in Central America is tasked with protecting a couple of kids after a power failure causes the park's cloned dinosaurs to run loose.",
                GenreID = db.Genres.FirstOrDefault(u => u.GenreType == GenreType.Drama)?.GenreID ?? 0,
                Tagline = "Welcome to Jurassic Park",
                PublishedDate = 1993,
                MPAARating = MPAARating.PG13,
                Actors = "Sam Neill, Laura Dern, Jeff Goldblum",
                Runtime = TimeSpan.FromMinutes(90)
            });

            Movies.Add(new Movie
            {
                Title = "Toy Story 7",
                Description = "Woody and Buzz team up once again to lead the resistance in the Toy Revolt.",
                GenreID = db.Genres.FirstOrDefault(m => m.GenreType == GenreType.Action)?.GenreID ?? 0,
                Tagline = "Play, pretend, and protect",
                PublishedDate = 2023,
                MPAARating = MPAARating.G,
                Actors = "Tom Hanks, Tim Allen",
                Runtime = TimeSpan.FromMinutes(90)
            });

            Movies.Add(new Movie
            {
                Title = "Fast and Furious 18: Anger Management",
                Description = "They may be riding mechanical scooters, but they are as furious as ever as they attend court-ordered therapy.",
                GenreID = db.Genres.FirstOrDefault(u => u.GenreType == GenreType.Action)?.GenreID ?? 0,
                Tagline = "I drink your milkshake",
                PublishedDate = 2023,
                MPAARating = MPAARating.R,
                Actors = "The Rock, Vin Diesel",
                Runtime = TimeSpan.FromMinutes(120)
            });

            Movies.Add(new Movie
            {
                Title = "Titanic",
                Description = "An epic, action-packed romance set against the ill-fated maiden voyage of the R.M.S. Titanic.",
                GenreID = db.Genres.FirstOrDefault(u => u.GenreType == GenreType.Romance)?.GenreID ?? 0,
                Tagline = "Nothing On Earth Could Come Between Them. Collide With Destiny.",
                PublishedDate =  1999,  
                MPAARating = MPAARating.PG13,
                Actors = "Leonardo DiCaprio, Kate Winslet",
                Runtime = TimeSpan.FromMinutes(150)
            });

            Movies.Add(new Movie
            {
                Title = "The Secret Life of Walter Mitty",
                Description = "When both he and a colleague are about to lose their job, Walter takes action by embarking on an adventure more extraordinary than anything he ever imagined.",
                GenreID = db.Genres.FirstOrDefault(u => u.GenreType == GenreType.Comedy)?.GenreID ?? 0,
                Tagline = "Stop dreaming. Start Living.",
                PublishedDate =  2013,  
                MPAARating = MPAARating.PG,
                Actors = "Ben Stiller",
                Runtime = TimeSpan.FromMinutes(120)
            });

            Movies.Add(new Movie
            {
                Title = "The Goonies",
                Description = "A group of young misfits called The Goonies discover an ancient map and set out on an adventure to find a legendary pirate's long-lost treasure.",
                GenreID = db.Genres.FirstOrDefault(u => u.GenreType == GenreType.Children_Family)?.GenreID ?? 0,
                Tagline = "The treacherous traps. The hidden treasure. And Sloth... Join the adventure.",
                PublishedDate =  1985,  
                MPAARating = MPAARating.PG,
                Actors = "Sean Astin, Josh Brolin, Corey Feldman",
                Runtime = TimeSpan.FromMinutes(90)
            });

            Movies.Add(new Movie
            {
                Title = "The Sandlot",
                Description = "When Scottie Smalls moves to a new neighborhood, he manages to make friends with a group of kids who play baseball at the sandlot.",
                GenreID = db.Genres.FirstOrDefault(u => u.GenreType == GenreType.Children_Family)?.GenreID ?? 0,
                Tagline = "The adventure of a lifetime, the summer of their dreams...the dog of their nightmares.",
                PublishedDate =  1993,  
                MPAARating = MPAARating.PG,
                Actors = "Mike Vitar, Patrick Renna, James Earl Jones",
                Runtime = TimeSpan.FromMinutes(90)
            });

            Movies.Add(new Movie
            {
                Title = "Rocky Horror Picture Show",
                Description = "A newly-engaged couple have a breakdown in an isolated area and must seek shelter at the bizarre residence of Dr. Frank-n-Furter",
                GenreID = db.Genres.FirstOrDefault(u => u.GenreType == GenreType.Musical)?.GenreID ?? 0,
                Tagline = "Don't Dream it, Be It!",
                PublishedDate =  1975,  
                MPAARating = MPAARating.R,
                Actors = "Tim Curry, Susan Sarandon",
                Runtime = TimeSpan.FromMinutes(90)
            });

            Movies.Add(new Movie
            {
                Title = "Titanic: Jack's Revenge",
                Description = "Emerging from the deep with revenge on his mind, Jack Dawson will stop at nothing to find Rose.",
                GenreID = db.Genres.FirstOrDefault(u => u.GenreType == GenreType.Horror)?.GenreID ?? 0,
                Tagline = "She let me go, now I'll never let her forget it.",
                PublishedDate =  2023,  
                MPAARating = MPAARating.R,
                Actors = "Leonardo DiCaprio, Kate Winslet",
                Runtime = TimeSpan.FromMinutes(150)
            });

            Movies.Add(new Movie
            {
                Title = "The Hobbit: An Unexpected Journey",
                Description = "An Unexpected Journey tells the tale of Bilbo Baggins, who is convinced by the wizard Gandalf to accompany thirteen Dwarves, led by Thorin Oakenshield, on a quest to reclaim the Lonely Mountain from the dragon Smaug.",
                GenreID = db.Genres.FirstOrDefault(u => u.GenreType == GenreType.SciFi)?.GenreID ?? 0,
                Tagline = "From the smallest beginnings come the greatest legends. One journey started it all.",
                PublishedDate =  2012,  
                MPAARating = MPAARating.PG13,
                Actors = "Martin Freeman, Ian McKellan, Richard Armitage",
                Runtime = TimeSpan.FromMinutes(150)
            });

            Movies.Add(new Movie
            {
                Title = "The Hobbit: The Battle of Five Armies",
                Description = "Bilbo and company are forced to engage in a war against an array of combatants and keep the Lonely Mountain from falling into the hands of a rising darkness.",
                GenreID = db.Genres.FirstOrDefault(u => u.GenreType == GenreType.SciFi)?.GenreID ?? 0,
                Tagline = "The defining chapter.",
                PublishedDate =  2014,  
                MPAARating = MPAARating.PG13,
                Actors = "Martin Freeman, Ian McKellan, Richard Armitage",
                Runtime = TimeSpan.FromMinutes(150)
            });

            Movies.Add(new Movie
            {
                Title = "The Hobbit: The Desolation of Smaug",
                Description = "The dwarves, along with Bilbo Baggins and Gandalf the Grey, continue their quest to reclaim Erebor, their homeland, from Smaug.",
                GenreID = db.Genres.FirstOrDefault(u => u.GenreType == GenreType.SciFi)?.GenreID ?? 0,
                Tagline = "It's a really big dragon",
                PublishedDate =  2013,  
                MPAARating = MPAARating.PG13,
                Actors = "Martin Freeman, Ian McKellan, Richard Armitage",
                Runtime = TimeSpan.FromMinutes(150)
            });

            Movies.Add(new Movie
            {
                Title = "Lord of the Rings: Fellowship of the Ring",
                Description = "The future of civilization rests in the fate of the One Ring, which has been lost for centuries. Powerful forces are unrelenting in their search for it. But fate has placed it in the hands of a young Hobbit named Frodo Baggins, who inherits the Ring and steps into legend.",
                GenreID = db.Genres.FirstOrDefault(u => u.GenreType == GenreType.SciFi)?.GenreID ?? 0,
                Tagline = "One Ring To Rule Them All. Fate Has Chosen Him. A Fellowship Will Protect Him. Evil Will Hunt Them.",
                PublishedDate =  2001,  
                MPAARating = MPAARating.PG13,
                Actors = "Elijah Wood, Sam Astin, Orlando Bloom, Viggo Mortenson, Billy Boyd, Dominic Monaghan, Sean Bean",
                Runtime = TimeSpan.FromMinutes(150)
            });

            Movies.Add(new Movie
            {
                Title = "Lord of the Rings: Two Towers",
                Description = "Frodo and Sam discover they are being followed by the mysterious Gollum.",
                GenreID = db.Genres.FirstOrDefault(u => u.GenreType == GenreType.SciFi)?.GenreID ?? 0,
                Tagline = "A New Power Is Rising. The Battle for Middle-earth Begins!",
                PublishedDate =  2002,  
                MPAARating = MPAARating.PG13,
                Actors = "Elijah Wood, Sam Astin, Orlando Bloom, Viggo Mortenson, Billy Boyd, Dominic Monaghan, Sean Bean",
                Runtime = TimeSpan.FromMinutes(150)
            });

            Movies.Add(new Movie
            {
                Title = "Lord of the Rings: The Return of the King",
                Description = "Continuing the plot of the previous film, Frodo, Sam and Gollum are making their final way toward Mount Doom to destroy the One Ring, unaware of Gollum's true intentions, while Merry, Pippin, Gandalf, Aragorn, Legolas, Gimli and the others join forces together against Sauron and his legions in Minas Tirith.",
                GenreID = db.Genres.FirstOrDefault(u => u.GenreType == GenreType.SciFi)?.GenreID ?? 0,
                Tagline = "No victory without suffering. No freedom without sacrifice.",
                PublishedDate =  2003,  
                MPAARating = MPAARating.PG13,
                Actors = "Elijah Wood, Sam Astin, Orlando Bloom, Viggo Mortenson, Billy Boyd, Dominic Monaghan, Sean Bean",
                Runtime = TimeSpan.FromMinutes(180)
            });

            Movies.Add(new Movie
            {
                Title = "Barbie",
                Description = "Stereotypical Barbie experiences a full-on existential crisis and embarks on a journey of self-discovery. Along for the ride is her beau Ken.",
                GenreID = db.Genres.FirstOrDefault(u => u.GenreType == GenreType.Comedy)?.GenreID ?? 0,
                Tagline = "She can do everything. He's just Ken.",
                PublishedDate =  2023,  
                MPAARating = MPAARating.PG13,
                Actors = "Ryan Gosling, Margot Robbie",
                Runtime = TimeSpan.FromMinutes(120)
            });

            Movies.Add(new Movie
            {
                Title = "Spider-Man: Into the Spider-Verse",
                Description = "Teen Miles Morales becomes the Spider-Man of his universe and must join with five spider-powered individuals from other dimensions to stop a threat for all realities.",
                GenreID = db.Genres.FirstOrDefault(u => u.GenreType == GenreType.Action)?.GenreID ?? 0,
                Tagline = "Enter a universe where more than one wears the mask.",
                PublishedDate =  2018,  
                MPAARating = MPAARating.PG,
                Actors = "Shameik Moore, Jake Johnson, Hailee Steinfeld, Stan Lee, Oscar Isaac, Nicolas Cage, Mahershala Ali",
                Runtime = TimeSpan.FromMinutes(120)
            });

            Movies.Add(new Movie
            {
                Title = "Spider-Man: Across the Spider-Verse",
                Description = "Miles Morales catapults across the Multiverse, where he encounters a team of Spider-People charged with protecting its very existence.",
                GenreID = db.Genres.FirstOrDefault(u => u.GenreType == GenreType.Action)?.GenreID ?? 0,
                Tagline = "With great power comes great responsibility.",
                PublishedDate =  2023,  
                MPAARating = MPAARating.PG,
                Actors = "Shameik Moore, Hailee Steinfeld, Oscar Isaac, Karan Soni, Andy Samberg, Daniel Kaluuya",
                Runtime = TimeSpan.FromMinutes(150)
            });


            try  //attempt to add or update the Movie
            {
                //loop through each of the Movies in the list
                foreach (Movie MovieToAdd in Movies)
                {
                    //set the flag to the current title to help with debugging
                    strMovieTitle = MovieToAdd.Title;

                    //look to see if the Movie is in the database - this assumes that no
                    //two Movies have the same title
                    Movie dbMovie = db.Movies.FirstOrDefault(b => b.Title == MovieToAdd.Title);

                    //if the dbMovie is null, this title is not in the database
                    if (dbMovie == null)
                    {
                        //add the Movie to the database and save changes
                        db.Movies.Add(MovieToAdd);
                        db.SaveChanges();

                        //update the counter to help with debugging
                        intMovieAdded += 1;
                    }
                    else //dbMovie is not null - this title *is* in the database
                    {
                        //update all of the Movie's properties
                        dbMovie.Title = MovieToAdd.Title;
                        dbMovie.Description = MovieToAdd.Description;
                        dbMovie.Genre = MovieToAdd.Genre;
                        dbMovie.Tagline = MovieToAdd.Tagline;
                        dbMovie.PublishedDate = MovieToAdd.PublishedDate;
                        dbMovie.MPAARating = MovieToAdd.MPAARating;
                        dbMovie.Actors = MovieToAdd.Actors;
                        dbMovie.Runtime = MovieToAdd.Runtime;

                        //update the database and save the changes
                        db.Update(dbMovie);
                        db.SaveChanges();

                        //update the counter to help with debugging
                        intMovieAdded += 1;
                    } //this is the end of the else
                } //this is the end of the foreach loop for the Movies
            }//this is the end of the try block

            catch (Exception ex)//something went wrong with adding or updating
            {
                //Build a messsage using the flags we created
                String msg = "  Repositories added:" + intMovieAdded + "; Error on " + strMovieTitle;

                //throw the exception with the new message
                throw new InvalidOperationException(ex.Message + msg);
            }
        }
    }
}