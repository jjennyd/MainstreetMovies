using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Group_6_Final_Project.Models;
using Group_6_Final_Project.DAL;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Group_6_Final_Project.Controllers
{
    public class SeedController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public SeedController(AppDbContext db, UserManager<AppUser> um, RoleManager<IdentityRole> rm)
        {
            _context = db;
            _userManager = um;
            _roleManager = rm;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> SeedRoles()
        {
            try
            {
                //call the method to seed the roles
                await Seeding.SeedRoles.AddAllRoles(_roleManager);
            }
            catch (Exception ex)
            {
                //add the error messages to a list of strings
                List<String> errorList = new List<String>();

                //Add the outer message
                errorList.Add(ex.Message);

                //Add the message from the inner exception
                errorList.Add(ex.InnerException.Message);

                //Add additional inner exception messages, if there are any
                if (ex.InnerException.InnerException != null)
                {
                    errorList.Add(ex.InnerException.InnerException.Message);
                }

                return View("Error", errorList);
            }

            //this is the happy path - seeding worked!
            return View("Confirm");
        }
        public async Task<IActionResult> SeedPeople()
        {
            try
            {
                // Call the method to seed the users
                await Seeding.SeedUsers.SeedAllUsers(_userManager, _context);
            }
            catch (Exception ex)
            {
                // Handle errors and return an error view
                List<string> errorList = new List<string>
                {
                    ex.Message
                };

                if (ex.InnerException != null)
                {
                    errorList.Add(ex.InnerException.Message);

                    if (ex.InnerException.InnerException != null)
                    {
                        errorList.Add(ex.InnerException.InnerException.Message);
                    }
                }

                return View("Error", errorList);
            }

            // Seeding was successful
            return View("Confirm");
        }

        public async Task<IActionResult> SeedPrices()
        {
            try
            {
                // Call the method to seed the prices
                Seeding.SeedPrices.Prices(_context);
            }
            catch (Exception ex)
            {
                List<string> errorList = new List<string>
        {
            ex.Message
        };

                return View("Error", errorList);
            }

            // This is the happy path - seeding worked!
            return View("Confirm");
        }

        public async Task<IActionResult> SeedGenre()
        {
            try
            {
                // Call the method to seed the prices
                Seeding.SeedGenre.Genres(_context);
            }
            catch (Exception ex)
            {
                List<string> errorList = new List<string>
        {
            ex.Message
        };

                return View("Error", errorList);
            }

            // This is the happy path - seeding worked!
            return View("Confirm");
        }

        public async Task<IActionResult> SeedMovie()
        {
            try
            {
                // Call the method to seed the schedule
                Seeding.SeedMovies.Movie(_context);
            }
            catch (Exception ex)
            {
                List<string> errorList = new List<string>
        {
            ex.Message
        };

                return View("Error", errorList);
            }

            // This is the happy path - seeding worked!
            return View("Confirm");
        }

        public async Task<IActionResult> SeedSchedule()
        {
            try
            {
                // Call the method to seed the schedule
                Seeding.SeedSchedules.Schedule(_context);
            }
            catch (Exception ex)
            {
                List<string> errorList = new List<string>
        {
            ex.Message
        };

                return View("Error", errorList);
            }

            // This is the happy path - seeding worked!
            return View("Confirm");
        }

        public async Task<IActionResult> SeedTransaction()
        {
            try
            {
                // Call the method to seed the schedule
                Seeding.SeedTransactions.Transaction(_context);
            }
            catch (Exception ex)
            {
                List<string> errorList = new List<string>
        {
            ex.Message
        };

                return View("Error", errorList);
            }

            // This is the happy path - seeding worked!
            return View("Confirm");
        }

        public async Task<IActionResult> SeedReviews()
        {
            try
            {
                // Call the method to seed the schedule
                Seeding.SeedReviews.Reviews(_context);
            }
            catch (Exception ex)
            {
                List<string> errorList = new List<string>
        {
            ex.Message
        };

                return View("Error", errorList);
            }

            // This is the happy path - seeding worked!
            return View("Confirm");
        }
    }
}
