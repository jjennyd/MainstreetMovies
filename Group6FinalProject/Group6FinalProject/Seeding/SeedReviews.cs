using Microsoft.AspNetCore.Identity;
using Group_6_Final_Project.Utilities;
using Group_6_Final_Project.DAL;
using Group_6_Final_Project.Models;
using Microsoft.SqlServer.Server;
using static System.Reflection.Metadata.BlobBuilder;
using Microsoft.EntityFrameworkCore;

namespace Group_6_Final_Project.Seeding
{
    public static class SeedReviews
    {
        public static void Reviews(AppDbContext db)
        {
            //Create a counter and a flag so we will know which record is causing problems
            Int32 intReviewsAdded = 0;
            String strReviewInfo = "";

            //Add the list of Reviews
            List<Review> Reviews = new List<Review>();

            Reviews.Add(new Review
            {
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park")?.MovieID ?? string.Empty,
                Rating = 5,
                UserID = db.Users.FirstOrDefault(u => u.UserName == "banker@longhorn.net")?.Id ?? string.Empty,
                Description = "Best Movie I've ever seen.",
                Status = Status.Approved,
            });

            Reviews.Add(new Review
            {
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty")?.MovieID ?? string.Empty,
                Rating = 4,
                UserID = db.Users.FirstOrDefault(u => u.UserName == "cbaker@example.com")?.Id ?? string.Empty,
                Description = "Not bad.",
                Status = Status.Approved,
            });

            Reviews.Add(new Review
            {
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park")?.MovieID ?? string.Empty,
                Rating = 5,
                UserID = db.Users.FirstOrDefault(u => u.UserName == "ingram@jack.com")?.Id ?? string.Empty,
                Description = "Changed my life",
                Status = Status.Approved,
            });

            Reviews.Add(new Review
            {
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Goonies")?.MovieID ?? string.Empty,
                Rating = 5,
                UserID = db.Users.FirstOrDefault(u => u.UserName == "franco@example.com")?.Id ?? string.Empty,
                Description = "Great family adventure Movie",
                Status = Status.Approved,
            });

            Reviews.Add(new Review
            {
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Goonies")?.MovieID ?? string.Empty,
                Rating = 4,
                UserID = db.Users.FirstOrDefault(u => u.UserName == "wchang@example.com")?.Id ?? string.Empty,
                Description = "Good Movie",
                Status = Status.Approved,
            });

            Reviews.Add(new Review
            {
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Goonies")?.MovieID ?? string.Empty,
                Rating = 1,
                UserID = db.Users.FirstOrDefault(u => u.UserName == "limchou@gogle.com")?.Id ?? string.Empty,
                Description = "Worst thing I've ever seen",
                Status = Status.Approved,
            });

            Reviews.Add(new Review
            {
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Goonies")?.MovieID ?? string.Empty,
                Rating = 5,
                UserID = db.Users.FirstOrDefault(u => u.UserName == "ingram@jack.com")?.Id ?? string.Empty,
                Description = "Reminded me of my summers in the NW",
                Status = Status.Approved,
            });

            Reviews.Add(new Review
            {
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Goonies")?.MovieID ?? string.Empty,
                Rating = 5,
                UserID = db.Users.FirstOrDefault(u => u.UserName == "shdixon@aoll.com")?.Id ?? string.Empty,
                Description = "I love a good treasure hunt!",
                Status = Status.NeedsReview,
            });

            Reviews.Add(new Review
            {
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Goonies")?.MovieID ?? string.Empty,
                Rating = 3,
                UserID = db.Users.FirstOrDefault(u => u.UserName == "j.b.evans@aheca.org")?.Id ?? string.Empty,
                Description = "Meh",
                Status = Status.Approved,
            });

            Reviews.Add(new Review
            {
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: The Battle of Five Armies")?.MovieID ?? string.Empty,
                Rating = 4,
                UserID = db.Users.FirstOrDefault(u => u.UserName == "cbaker@example.com")?.Id ?? string.Empty,
                Description = " ",
                Status = Status.Approved,
            });

            Reviews.Add(new Review
            {
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: The Battle of Five Armies")?.MovieID ?? string.Empty,
                Rating = 4,
                UserID = db.Users.FirstOrDefault(u => u.UserName == "ingram@jack.com")?.Id ?? string.Empty,
                Description = " ",
                Status = Status.Approved,
            });

            Reviews.Add(new Review
            {
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: The Battle of Five Armies")?.MovieID ?? string.Empty,
                Rating = 5,
                UserID = db.Users.FirstOrDefault(u => u.UserName == "banker@longhorn.net")?.Id ?? string.Empty,
                Description = " ",
                Status = Status.Approved,
            });

            Reviews.Add(new Review
            {
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: The Battle of Five Armies")?.MovieID ?? string.Empty,
                Rating = 5,
                UserID = db.Users.FirstOrDefault(u => u.UserName == "franco@example.com")?.Id ?? string.Empty,
                Description = " ",
                Status = Status.Approved,
            });

            Reviews.Add(new Review
            {
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: The Battle of Five Armies")?.MovieID,
                Rating = 1,
                UserID = db.Users.FirstOrDefault(u => u.UserName == "wchang@example.com")?.Id ?? string.Empty,
                Description = "Too long",
                Status = Status.NeedsReview,
            });

            Reviews.Add(new Review
            {
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: The Battle of Five Armies")?.MovieID ?? string.Empty,
                Rating = 2,
                UserID = db.Users.FirstOrDefault(u => u.UserName == "limchou@gogle.com")?.Id ?? string.Empty,
                Description = "Did they really need to drag this out into its own Movie?",
                Status = Status.NeedsReview,
            });

            try  //attempt to add or update the Reviews
            {
                foreach (Review reviewToAdd in Reviews)
                {
                    //set the flag to the current review to help with debugging
                    strReviewInfo = "Review for MovieID: " + reviewToAdd.MovieID +
                                    ", UserID: " + reviewToAdd.UserID;

                    //look to see if the review is in the database
                    Review dbReview = db.Reviews.FirstOrDefault(r => r.MovieID == reviewToAdd.MovieID &&
                                                                     r.UserID == reviewToAdd.UserID);

                    //if the dbReview is null, this review is not in the database
                    if (dbReview == null)
                    {
                        //add the review to the database
                        db.Reviews.Add(reviewToAdd);
                        db.SaveChanges();
                        intReviewsAdded += 1; //increment the counter
                    }
                    else //dbReview is not null - update the review's properties
                    {
                        dbReview.Rating = reviewToAdd.Rating;
                        dbReview.Description = reviewToAdd.Description;
                        dbReview.Status = reviewToAdd.Status;
                        // no need to update MovieID and UserID as they are used for lookup

                        db.Update(dbReview);
                        db.SaveChanges();
                        intReviewsAdded += 1; //increment the counter
                    }
                } //end of foreach loop
            }
            catch (DbUpdateException ex)
            {
                // Extract the detailed inner exception
                var innerException = ex.InnerException?.Message ?? "No inner exception message.";

                // Build a message with the information gathered
                String msg = $"Error on Review: {strReviewInfo} - Repositories added: {intReviewsAdded}; " +
                             $"Error Message: {innerException}";

                // Log the detailed error message
                Console.WriteLine(msg); // or use your logger to log the error

                // Re-throw the exception with the new message
                throw new InvalidOperationException(msg, ex);
            }
            catch (Exception ex)
            {
                // For any other exception, build and throw a new exception
                String msg = $"Repositories added: {intReviewsAdded}; Error on {strReviewInfo}. " +
                             $"General Exception Message: {ex.Message}";

                // Log and re-throw
                Console.WriteLine(msg); // or use your logger to log the error
                throw new InvalidOperationException(msg, ex);
            }
        }
    }
}