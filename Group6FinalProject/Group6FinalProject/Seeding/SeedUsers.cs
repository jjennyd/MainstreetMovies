using Microsoft.AspNetCore.Identity;
using Group_6_Final_Project.Utilities;
using Group_6_Final_Project.DAL;
using Group_6_Final_Project.Models;

namespace Group_6_Final_Project.Seeding
{
    public static class SeedUsers
    {
        public async static Task<IdentityResult> SeedAllUsers(UserManager<AppUser> userManager, AppDbContext context)
        {
            //Create a list of AddUserModels
            List<AddUserModel> AllUsers = new List<AddUserModel>();

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "ra@aoo.com",
                    Email = "ra@aoo.com",
                    PhoneNumber = "555-555-5555",
                    FirstName = "Allen",
                    LastName = "Rogers",
                    DateOfBirth = new DateTime(1901, 1, 1),
                    AddressLine1 = "1 Longhorn Road",
                    City = "Austin",
                    State = "TX",
                    Zip = "78705"

                },
                Password = "3wCynC",
                RoleName = "Manager"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "captain@enterprise.net",
                    Email = "captain@enterprise.net",
                    PhoneNumber = "555-555-5555",
                    FirstName = "Jean Luc",
                    LastName = "Picard",
                    DateOfBirth = new DateTime(1901, 1, 1),
                    AddressLine1 = "1 Longhorn Road",
                    City = "Austin",
                    State = "TX",
                    Zip = "78705"

                },
                Password = "Pbon0r",
                RoleName = "Manager"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "slayer@onegirl.net",
                    Email = "slayer@onegirl.net",
                    PhoneNumber = "555-555-5555",
                    FirstName = "Buffy",
                    LastName = "Summers",
                    DateOfBirth = new DateTime(1901, 1, 1),
                    AddressLine1 = "1 Longhorn Road",
                    City = "Austin",
                    State = "TX",
                    Zip = "78705"

                },
                Password = "jW5fPP",
                RoleName = "Manager"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "liz@ggmail.com",
                    Email = "liz@ggmail.com",
                    PhoneNumber = "555-555-5555",
                    FirstName = "Elizabeth",
                    LastName = "Markham",
                    DateOfBirth = new DateTime(1901, 1, 1),
                    AddressLine1 = "1 Longhorn Road",
                    City = "Austin",
                    State = "TX",
                    Zip = "78705"

                },
                Password = "0QyilL",
                RoleName = "Manager"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "twin@deservedbetter.com",
                    Email = "twin@deservedbetter.com",
                    PhoneNumber = "555-555-5555",
                    FirstName = "Fred",
                    LastName = "Weasley",
                    DateOfBirth = new DateTime(1901, 1, 1),
                    AddressLine1 = "1 Longhorn Road",
                    City = "Austin",
                    State = "TX",
                    Zip = "78705"

                },
                Password = "atLm6W",
                RoleName = "Manager"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "michelle@example.com",
                    Email = "michelle@example.com",
                    PhoneNumber = "555-555-5555",
                    FirstName = "Michelle",
                    LastName = "Banks",
                    DateOfBirth = new DateTime(1901, 1, 1),
                    AddressLine1 = "1 Longhorn Road",
                    City = "Austin",
                    State = "TX",
                    Zip = "78705"
                },
                Password = "jVb0Z6",
                RoleName = "Employee"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "toddy@aool.com",
                    Email = "toddy@aool.com",
                    PhoneNumber = "555-555-5555",
                    FirstName = "Todd",
                    LastName = "Jacobs",
                    DateOfBirth = new DateTime(1901, 1, 1),
                    AddressLine1 = "1 Longhorn Road",
                    City = "Austin",
                    State = "TX",
                    Zip = "78705"
                },
                Password = "1PnrBV",
                RoleName = "Employee"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "elowe@netscrape.net",
                    Email = "elowe@netscrape.net",
                    PhoneNumber = "555-555-5555",
                    FirstName = "Ernest",
                    LastName = "Lowe",
                    DateOfBirth = new DateTime(1901, 1, 1),
                    AddressLine1 = "1 Longhorn Road",
                    City = "Austin",
                    State = "TX",
                    Zip = "78705"
                },
                Password = "v3n5AV",
                RoleName = "Employee"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "mclarence@aool.com",
                    Email = "mclarence@aool.com",
                    PhoneNumber = "555-555-5555",
                    FirstName = "Clarence",
                    LastName = "Martin",
                    DateOfBirth = new DateTime(1901, 1, 1),
                    AddressLine1 = "1 Longhorn Road",
                    City = "Austin",
                    State = "TX",
                    Zip = "78705"
                },
                Password = "zBLq3S",
                RoleName = "Employee"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "nelson.Kelly@aool.com",
                    Email = "nelson.Kelly@aool.com",
                    PhoneNumber = "555-555-5555",
                    FirstName = "Kelly",
                    LastName = "Nelson",
                    DateOfBirth = new DateTime(1901, 1, 1),
                    AddressLine1 = "1 Longhorn Road",
                    City = "Austin",
                    State = "TX",
                    Zip = "78705"
                },
                Password = "FSb8rA",
                RoleName = "Employee"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "megrhodes@freezing.co.uk",
                    Email = "megrhodes@freezing.co.uk",
                    PhoneNumber = "555-555-5555",
                    FirstName = "Megan",
                    LastName = "Rhodes",
                    DateOfBirth = new DateTime(1901, 1, 1),
                    AddressLine1 = "1 Longhorn Road",
                    City = "Austin",
                    State = "TX",
                    Zip = "78705"
                },
                Password = "1xVfHp",
                RoleName = "Employee"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "sheff44@ggmail.com",
                    Email = "sheff44@ggmail.com",
                    PhoneNumber = "555-555-5555",
                    FirstName = "Martin",
                    LastName = "Sheffield",
                    DateOfBirth = new DateTime(1901, 1, 1),
                    AddressLine1 = "1 Longhorn Road",
                    City = "Austin",
                    State = "TX",
                    Zip = "78705"
                },
                Password = "4XKLsd",
                RoleName = "Employee"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "peterstump@hootmail.com",
                    Email = "peterstump@hootmail.com",
                    PhoneNumber = "555-555-5555",
                    FirstName = "Peter",
                    LastName = "Stump",
                    DateOfBirth = new DateTime(1901, 1, 1),
                    AddressLine1 = "1 Longhorn Road",
                    City = "Austin",
                    State = "TX",
                    Zip = "78705"
                },
                Password = "1XdmSV",
                RoleName = "Employee"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "yhuik9.Taylor@aool.com",
                    Email = "yhuik9.Taylor@aool.com",
                    PhoneNumber = "555-555-5555",
                    FirstName = "Rachel",
                    LastName = "Taylor",
                    DateOfBirth = new DateTime(1901, 1, 1),
                    AddressLine1 = "1 Longhorn Road",
                    City = "Austin",
                    State = "TX",
                    Zip = "78705"
                },
                Password = "9yhFS3",
                RoleName = "Employee"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "tuck33@ggmail.com",
                    Email = "tuck33@ggmail.com",
                    PhoneNumber = "555-555-5555",
                    FirstName = "Clent",
                    LastName = "Tucker",
                    DateOfBirth = new DateTime(1901, 1, 1),
                    AddressLine1 = "1 Longhorn Road",
                    City = "Austin",
                    State = "TX",
                    Zip = "78705"
                },
                Password = "I6BgsS",
                RoleName = "Employee"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "taylordjay@aool.com",
                    Email = "taylordjay@aool.com",
                    PhoneNumber = "555-555-5555",
                    FirstName = "Allison",
                    LastName = "Taylor",
                    DateOfBirth = new DateTime(1901, 1, 1),
                    AddressLine1 = "1 Longhorn Road",
                    City = "Austin",
                    State = "TX",
                    Zip = "78705"
                },
                Password = "Vjb1wI",
                RoleName = "Employee"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "jojoe@ggmail.com",
                    Email = "jojoe@ggmail.com",
                    PhoneNumber = "555-555-5555",
                    FirstName = "Joe",
                    LastName = "Nguyen",
                    DateOfBirth = new DateTime(1901, 1, 1),
                    AddressLine1 = "1 Longhorn Road",
                    City = "Austin",
                    State = "TX",
                    Zip = "78705"
                },
                Password = "xI8Brg",
                RoleName = "Employee"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "hicks43@ggmail.com",
                    Email = "hicks43@ggmail.com",
                    PhoneNumber = "555-555-5555",
                    FirstName = "Anthony",
                    LastName = "Hicks",
                    DateOfBirth = new DateTime(1901, 1, 1),
                    AddressLine1 = "1 Longhorn Road",
                    City = "Austin",
                    State = "TX",
                    Zip = "78705"
                },
                Password = "s33WOz",
                RoleName = "Employee"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "orielly@foxnets.com",
                    Email = "orielly@foxnets.com",
                    PhoneNumber = "555-555-5555",
                    FirstName = "Bill",
                    LastName = "O'Reilly",
                    DateOfBirth = new DateTime(1901, 1, 1),
                    AddressLine1 = "1 Longhorn Road",
                    City = "Austin",
                    State = "TX",
                    Zip = "78705"
                },
                Password = "pS2OJh",
                RoleName = "Employee"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "cbaker@example.com",
                    Email = "cbaker@example.com",
                    PhoneNumber = "152-275-7212",
                    FirstName = "Christopher",
                    LastName = "Baker",
                    DateOfBirth = new DateTime(1945, 8, 2),
                    AddressLine1 = "1 David Park",
                    City = "Austin",
                    State = "TX",
                    Zip = "78705"

                },
                Password = "bookworm",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel
            {
                User = new AppUser
                {
                    UserName = "banker@longhorn.net",
                    Email = "banker@longhorn.net",
                    FirstName = "Michelle",
                    LastName = "Banks",
                    DateOfBirth = new DateTime(2000, 11, 18),
                    AddressLine1 = "10117 Swallow Road",
                    City = "Austin",
                    State = "TX",
                    Zip = "78712"
                },
                Password = "aclfest2017",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel
            {
                User = new AppUser
                {
                    UserName = "franco@example.com",
                    Email = "franco@example.com",
                    FirstName = "Franco",
                    LastName = "Broccolo",
                    DateOfBirth = new DateTime(2002, 5, 2),
                    AddressLine1 = "21344 Marcy Avenue",
                    City = "Austin",
                    State = "TX",
                    Zip = "78786"
                },
                Password = "aggies",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel
            {
                User = new AppUser
                {
                    UserName = "wchang@example.com",
                    Email = "wchang@example.com",
                    FirstName = "Wendy",
                    LastName = "Chang",
                    DateOfBirth = new DateTime(1955, 8, 20),
                    AddressLine1 = "894 Kim Junction",
                    City = "Eagle Pass",
                    State = "TX",
                    Zip = "78852"
                },
                Password = "alaskaboy",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel
            {
                User = new AppUser
                {
                    UserName = "limchou@gogle.com",
                    Email = "limchou@gogle.com",
                    FirstName = "Lim",
                    LastName = "Chou",
                    DateOfBirth = new DateTime(2009, 4, 6),
                    AddressLine1 = "703 Anthes Lane",
                    City = "Austin",
                    State = "TX",
                    Zip = "78729"
                },
                Password = "allyrally",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel
            {
                User = new AppUser
                {
                    UserName = "shdixon@aoll.com",
                    Email = "shdixon@aoll.com",
                    FirstName = "Shan",
                    LastName = "Dixon",
                    DateOfBirth = new DateTime(1989, 10, 21),
                    AddressLine1 = "45927 Forest Run Trail",
                    City = "Georgetown",
                    State = "TX",
                    Zip = "78628"
                },
                Password = "Anchorage",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel
            {
                User = new AppUser
                {
                    UserName = "j.b.evans@aheca.org",
                    Email = "j.b.evans@aheca.org",
                    FirstName = "Jim Bob",
                    LastName = "Evans",
                    DateOfBirth = new DateTime(2001, 10, 8),
                    AddressLine1 = "51 Miller Park",
                    City = "Austin",
                    State = "TX",
                    Zip = "78705"
                },
                Password = "billyboy",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel
            {
                User = new AppUser
                {
                    UserName = "feeley@penguin.org",
                    Email = "feeley@penguin.org",
                    FirstName = "Lou Ann",
                    LastName = "Feeley",
                    DateOfBirth = new DateTime(1966, 6, 19),
                    AddressLine1 = "80686 Ryan Terrace",
                    City = "Austin",
                    State = "TX",
                    Zip = "78704"
                },
                Password = "bunnyhop",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel
            {
                User = new AppUser
                {
                    UserName = "tfreeley@minnetonka.ci.us",
                    Email = "tfreeley@minnetonka.ci.us",
                    FirstName = "Tesa",
                    LastName = "Freeley",
                    DateOfBirth = new DateTime(1996, 9, 12),
                    AddressLine1 = "97327 Express Avenue",
                    City = "College Station",
                    State = "TX",
                    Zip = "77840"
                },
                Password = "dustydusty",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel
            {
                User = new AppUser
                {
                    UserName = "mgarcia@gogle.com",
                    Email = "mgarcia@gogle.com",
                    FirstName = "Margaret",
                    LastName = "Garcia",
                    DateOfBirth = new DateTime(2002, 6, 17),
                    AddressLine1 = "1 Arrowood Road",
                    City = "Austin",
                    State = "TX",
                    Zip = "78756"
                },
                Password = "gowest",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel
            {
                User = new AppUser
                {
                    UserName = "chaley@thug.com",
                    Email = "chaley@thug.com",
                    FirstName = "Charles",
                    LastName = "Haley",
                    DateOfBirth = new DateTime(1998, 5, 15),
                    AddressLine1 = "5035 Dayton Court",
                    City = "Austin",
                    State = "TX",
                    Zip = "78746"
                },
                Password = "hampton1",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel
            {
                User = new AppUser
                {
                    UserName = "jeffh@sonic.com",
                    Email = "jeffh@sonic.com",
                    FirstName = "Jeffrey",
                    LastName = "Hampton",
                    DateOfBirth = new DateTime(2003, 4, 8),
                    AddressLine1 = "90461 Evergreen Place",
                    City = "Austin",
                    State = "TX",
                    Zip = "78756"
                },
                Password = "hickhickup",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel
            {
                User = new AppUser
                {
                    UserName = "wjhearniii@umich.org",
                    Email = "wjhearniii@umich.org",
                    FirstName = "John",
                    LastName = "Hearn",
                    DateOfBirth = new DateTime(2000, 9, 15),
                    AddressLine1 = "973 Stephen Alley",
                    City = "Liberty",
                    State = "TX",
                    Zip = "77575"
                },
                Password = "ingram2015",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel
            {
                User = new AppUser
                {
                    UserName = "ahick@yaho.com",
                    Email = "ahick@yaho.com",
                    FirstName = "Anthony",
                    LastName = "Hicks",
                    DateOfBirth = new DateTime(1980, 5, 7),
                    AddressLine1 = "80319 Forster Parkway",
                    City = "San Antonio",
                    State = "TX",
                    Zip = "78203"
                },
                Password = "jhearn22",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel
            {
                User = new AppUser
                {
                    UserName = "ingram@jack.com",
                    Email = "ingram@jack.com",
                    FirstName = "Brad",
                    LastName = "White",
                    DateOfBirth = new DateTime(1986, 2, 6),
                    AddressLine1 = "96 Stang Hill",
                    City = "New Braunfels",
                    State = "TX",
                    Zip = "78132"
                },
                Password = "joejoejoe",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel
            {
                User = new AppUser
                {
                    UserName = "toddj@yourmom.com",
                    Email = "toddj@yourmom.com",
                    FirstName = "Todd",
                    LastName = "Jacobs",
                    DateOfBirth = new DateTime(1975, 8, 29),
                    AddressLine1 = "23726 Main Crossing",
                    City = "New York",
                    State = "NY",
                    Zip = "10101"
                },
                Password = "jrod2017",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel
            {
                User = new AppUser
                {
                    UserName = "thequeen@aska.net",
                    Email = "thequeen@aska.net",
                    FirstName = "Victoria",
                    LastName = "Lawrence",
                    DateOfBirth = new DateTime(2001, 1, 29),
                    AddressLine1 = "6299 Moland Alley",
                    City = "Lockhart",
                    State = "TX",
                    Zip = "78644"
                },
                Password = "longhorns",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel
            {
                User = new AppUser
                {
                    UserName = "linebacker@gogle.com",
                    Email = "linebacker@gogle.com",
                    FirstName = "Erik",
                    LastName = "Lineback",
                    DateOfBirth = new DateTime(2004, 5, 21),
                    AddressLine1 = "6 Truax Street",
                    City = "Kingwood",
                    State = "TX",
                    Zip = "77325"
                },
                Password = "louielouie",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel
            {
                User = new AppUser
                {
                    UserName = "elowe@netscare.net",
                    Email = "elowe@netscare.net",
                    FirstName = "Ernest",
                    LastName = "Lowe",
                    DateOfBirth = new DateTime(2001, 12, 27),
                    AddressLine1 = "50883 Heath Park",
                    City = "Beverly Hills",
                    State = "CA",
                    Zip = "90210"
                },
                Password = "martin1234",
                RoleName = "Customer"
            });

            String errorFlag = "Start";
            IdentityResult result = new IdentityResult();

            try
            {
                foreach (AddUserModel aum in AllUsers)
                {
                    errorFlag = aum.User.Email;
                    result = await Utilities.AddUser.AddUserWithRoleAsync(aum, userManager, context);

                    if (!result.Succeeded)
                    {
                        // User creation failed, print out the errors
                        foreach (var error in result.Errors)
                        {
                            Console.WriteLine($"Error: {error.Description}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("There was a problem adding the user with email: " + errorFlag, ex);
            }

            return result;
        }
    }
}