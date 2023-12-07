using Microsoft.AspNetCore.Identity;
using Group_6_Final_Project.Utilities;
using Group_6_Final_Project.DAL;
using Group_6_Final_Project.Models;
using Microsoft.SqlServer.Server;
using static System.Reflection.Metadata.BlobBuilder;
using System.Diagnostics;
using System;

namespace Group_6_Final_Project.Seeding
{
    public static class SeedSchedules
    {
        public static void Schedule(AppDbContext db)
        {
            //Create a counter and a flag so we will know which record is causing problems
            Int32 intScheduleAdded = 0;
            Int32 intScheduleTitle = 0;

            //Add the list of Schedules
            List<Schedule> Schedules = new List<Schedule>();

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 23, 9, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park")?.MovieID ?? string.Empty,
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0,
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 23, 11, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Matinee)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 23, 13, 30, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Titanic")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 23, 16, 30, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 23, 19, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 23, 21, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Goonies")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 23, 9, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Matinee)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 23, 11, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park")?.MovieID ?? string.Empty,  
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Matinee)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 23, 13, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 23, 15, 30, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management")?.MovieID ?? string.Empty,
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 23, 18, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Goonies")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 23, 20, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Sandlot")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 23, 22, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Rocky Horror Picture Show")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 24, 9, 0, 0),
                Theatre = Theatre.Theatre1,
                                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park")?.MovieID ?? string.Empty,  
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Matinee)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 24, 11, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Matinee)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 24, 13, 30, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Titanic: Jack's Revenge")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Weekends)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 24, 16, 30, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Weekends)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 24, 19, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Weekends)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 24, 21, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Goonies")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Weekends)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 24, 9, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Matinee)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 24, 11, 0, 0),
                Theatre = Theatre.Theatre2,
                                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park")?.MovieID ?? string.Empty,  
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Matinee)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 24, 13, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Weekends)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 24, 15, 30, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Weekends)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 24, 18, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Goonies")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Weekends)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 24, 20, 30, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Sandlot")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Weekends)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 24, 22, 30, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Rocky Horror Picture Show")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Weekends)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 25, 9, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Titanic")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Weekends)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 25, 12, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Titanic: Jack's Revenge")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Weekends)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 25, 15, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: An Unexpected Journey")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Weekends)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 25, 18, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: The Desolation of Smaug")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Weekends)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 25, 21, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: The Battle of Five Armies")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.SpecialEvent)?.PriceID ?? 0, 
                //SpecialEvent = true
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 25, 9, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Weekends)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 25, 11, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management")?.MovieID ?? string.Empty,
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Weekends)?.PriceID ?? 0,
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 25, 13, 30, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Lord of the Rings: Fellowship of the Ring")?.MovieID ?? string.Empty,
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Weekends)?.PriceID ?? 0,
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 25, 16, 30, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Lord of the Rings: Two Towers")?.MovieID ?? string.Empty,
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Weekends)?.PriceID ?? 0,
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 25, 19, 30, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Lord of the Rings: The Return of the King ")?.MovieID ?? string.Empty,
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.SpecialEvent)?.PriceID ?? 0,
                //SpecialEvent = true
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 26, 9, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Titanic")?.MovieID ?? string.Empty,
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Weekends)?.PriceID ?? 0,
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 26, 12, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Titanic: Jack's Revenge")?.MovieID ?? string.Empty,
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Weekends)?.PriceID ?? 0,
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 26, 15, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: An Unexpected Journey")?.MovieID ?? string.Empty,
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Weekends)?.PriceID ?? 0,
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 26, 18, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: The Desolation of Smaug")?.MovieID ?? string.Empty,
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Weekends)?.PriceID ?? 0,
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 26, 21, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7")?.MovieID ?? string.Empty,
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.SpecialEvent)?.PriceID ?? 0,
                //SpecialEvent = true
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 26, 9, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management")?.MovieID ?? string.Empty,
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Weekends)?.PriceID ?? 0,
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 26, 11, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Lord of the Rings: Fellowship of the Ring")?.MovieID ?? string.Empty,
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Weekends)?.PriceID ?? 0,
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 26, 13, 30, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Lord of the Rings: Two Towers")?.MovieID ?? string.Empty,
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Weekends)?.PriceID ?? 0,
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 26, 16, 30, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Lord of the Rings: The Return of the King ")?.MovieID ?? string.Empty,
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Weekends)?.PriceID ?? 0,
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 26, 19, 30, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park")?.MovieID ?? string.Empty,
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.SpecialEvent)?.PriceID ?? 0,
                //SpecialEvent = true
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 27, 9, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management")?.MovieID ?? string.Empty,
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Matinee)?.PriceID ?? 0,
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 27, 11, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Titanic")?.MovieID ?? string.Empty,
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Matinee)?.PriceID ?? 0,
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 27, 13, 30, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 27, 16, 30, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 27, 19, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Goonies")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 27, 21, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 27, 9, 0, 0),
                Theatre = Theatre.Theatre2,
                                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park")?.MovieID ?? string.Empty,  
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Matinee)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 27, 11, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Matinee)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 27, 13, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 27, 15, 30, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Goonies")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 27, 18, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Sandlot")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 27, 20, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Rocky Horror Picture Show")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 27, 22, 0, 0),
                Theatre = Theatre.Theatre2,
                                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park")?.MovieID ?? string.Empty,  
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 28, 9, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Matinee)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 28, 11, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Titanic")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Matinee)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 28, 13, 30, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.DiscountTuesday)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 28, 16, 30, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.DiscountTuesday)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 28, 19, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Goonies")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 28, 21, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 28, 9, 0, 0),
                Theatre = Theatre.Theatre2,
                                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park")?.MovieID ?? string.Empty,  
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Matinee)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 28, 11, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Matinee)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 28, 13, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.DiscountTuesday)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 28, 15, 30, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.DiscountTuesday)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 28, 18, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Goonies")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 28, 20, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Sandlot")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 28, 22, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Rocky Horror Picture Show")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 29, 9, 0, 0),
                Theatre = Theatre.Theatre1,
                                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park")?.MovieID ?? string.Empty,  
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Matinee)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 29, 11, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Matinee)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 29, 13, 30, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Titanic")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 29, 16, 30, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 29, 19, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 29, 21, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Goonies")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 29, 9, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Matinee)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 29, 11, 0, 0),
                Theatre = Theatre.Theatre2,
                                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park")?.MovieID ?? string.Empty,  
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Matinee)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 29, 13, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 29, 15, 30, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 29, 18, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Goonies")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 29, 20, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Sandlot")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 29, 22, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Rocky Horror Picture Show")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 30, 9, 0, 0),
                Theatre = Theatre.Theatre1,
                                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park")?.MovieID ?? string.Empty,  
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Matinee)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 30, 11, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Matinee)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 30, 13, 30, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Titanic: Jack's Revenge")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 30, 16, 30, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 30, 19, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 30, 21, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Goonies")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 30, 9, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Matinee)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 30, 11, 0, 0),
                Theatre = Theatre.Theatre2,
                                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park")?.MovieID ?? string.Empty,  
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Matinee)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 30, 13, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 30, 15, 30, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 30, 18, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Goonies")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 30, 20, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Sandlot")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 11, 30, 22, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Rocky Horror Picture Show")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 1, 9, 0, 0),
                Theatre = Theatre.Theatre1,
                                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park")?.MovieID ?? string.Empty,  
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Matinee)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 1, 11, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Matinee)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 1, 13, 30, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Titanic: Jack's Revenge")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Weekends)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 1, 16, 30, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Weekends)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 1, 19, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Weekends)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 1, 21, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Goonies")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.SpecialEvent)?.PriceID ?? 0, 
                //SpecialEvent = true
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 1, 9, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Matinee)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 1, 11, 0, 0),
                Theatre = Theatre.Theatre2,
                                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park")?.MovieID ?? string.Empty,  
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Matinee)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 1, 13, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Weekends)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 1, 15, 30, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Weekends)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 1, 18, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Goonies")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Weekends)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 1, 20, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Sandlot")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.SpecialEvent)?.PriceID ?? 0, 
                //SpecialEvent = true
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 1, 22, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Rocky Horror Picture Show")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Weekends)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 2, 9, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Titanic")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Weekends)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 2, 12, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Titanic: Jack's Revenge")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Weekends)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 2, 15, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: An Unexpected Journey")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Weekends)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 2, 18, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: The Desolation of Smaug")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Weekends)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 2, 21, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: The Battle of Five Armies")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Weekends)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 2, 9, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Weekends)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 2, 11, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Weekends)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 2, 13, 30, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Lord of the Rings: Fellowship of the Ring")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Weekends)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 2, 16, 30, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Lord of the Rings: Two Towers")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Weekends)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 2, 19, 30, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Lord of the Rings: The Return of the King ")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Weekends)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 3, 9, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Titanic")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Weekends)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 3, 12, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Titanic: Jack's Revenge")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Weekends)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 3, 15, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: An Unexpected Journey")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Weekends)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 3, 18, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: The Desolation of Smaug")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Weekends)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 3, 21, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Hobbit: The Battle of Five Armies")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.SpecialEvent)?.PriceID ?? 0, 
                //SpecialEvent = true
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 3, 9, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Weekends)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 3, 11, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Weekends)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 3, 13, 30, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Lord of the Rings: Fellowship of the Ring")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Weekends)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 3, 16, 30, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Lord of the Rings: Two Towers")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Weekends)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 3, 19, 30, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Lord of the Rings: The Return of the King ")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.SpecialEvent)?.PriceID ?? 0, 
                //SpecialEvent = true
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 4, 9, 0, 0),
                Theatre = Theatre.Theatre1,
                                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park")?.MovieID ?? string.Empty,  
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Matinee)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 4, 11, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Matinee)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 4, 13, 30, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Titanic")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 4, 16, 30, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 4, 19, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 4, 21, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Goonies")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 4, 9, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Matinee)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 4, 11, 0, 0),
                Theatre = Theatre.Theatre2,
                                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park")?.MovieID ?? string.Empty,  
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Matinee)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 4, 13, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 4, 15, 30, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 4, 18, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Goonies")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 4, 20, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Sandlot")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 4, 22, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Rocky Horror Picture Show")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 5, 9, 0, 0),
                Theatre = Theatre.Theatre1,
                                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park")?.MovieID ?? string.Empty,  
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Matinee)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 5, 11, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Matinee)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 5, 13, 30, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Titanic: Jack's Revenge")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.DiscountTuesday)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 5, 16, 30, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.DiscountTuesday)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 5, 19, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 5, 21, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Goonies")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 5, 9, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Matinee)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 5, 11, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park")?.MovieID ?? string.Empty,  
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Matinee)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 5, 13, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.DiscountTuesday)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 5, 15, 30, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.DiscountTuesday)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 5, 18, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Goonies")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 5, 20, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Sandlot")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 5, 22, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Rocky Horror Picture Show")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 6, 9, 0, 0),
                Theatre = Theatre.Theatre1,
                                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park")?.MovieID ?? string.Empty,  
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Matinee)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 6, 11, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Matinee)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 6, 13, 30, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Titanic")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 6, 16, 30, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 6, 19, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 6, 21, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Goonies")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 6, 9, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Matinee)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 6, 11, 0, 0),
                Theatre = Theatre.Theatre2,
                                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park")?.MovieID ?? string.Empty,  
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Matinee)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 6, 13, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 6, 15, 30, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 6, 18, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Goonies")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 6, 20, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Sandlot")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 6, 22, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Rocky Horror Picture Show")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 7, 9, 0, 0),
                Theatre = Theatre.Theatre1,
                                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park")?.MovieID ?? string.Empty,  
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Matinee)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 7, 11, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Matinee)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 7, 13, 30, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Titanic: Jack's Revenge")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 7, 16, 30, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 7, 19, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 7, 21, 0, 0),
                Theatre = Theatre.Theatre1,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Goonies")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 7, 9, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Toy Story 7")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Matinee)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 7, 11, 0, 0),
                Theatre = Theatre.Theatre2,
                                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Jurassic Park")?.MovieID ?? string.Empty,  
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.Matinee)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 7, 13, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Secret Life of Walter Mitty")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 7, 15, 30, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Fast and Furious 18: Anger Management")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 7, 18, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Goonies")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 7, 20, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "The Sandlot")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            Schedules.Add(new Schedule
            {
                StartTime = new DateTime(2023, 12, 7, 22, 0, 0),
                Theatre = Theatre.Theatre2,
                MovieID = db.Movies.FirstOrDefault(m => m.Title == "Rocky Horror Picture Show")?.MovieID ?? string.Empty, 
                PriceID = db.Prices.FirstOrDefault(m => m.TicketType == TicketType.WeekdayBase)?.PriceID ?? 0, 
                //SpecialEvent = false
            });

            try  //attempt to add or update the Schedule
            {
                //loop through each of the Schedules in the list
                foreach (Schedule ScheduleToAdd in Schedules)
                {
                    //set the flag to the current title to help with debugging
                    intScheduleTitle = ScheduleToAdd.ScheduleID;

                    //look to see if the Schedule is in the database - this assumes that no
                    //two Schedules have the same title
                    Schedule dbSchedule = db.Schedules.FirstOrDefault(b => b.ScheduleID == ScheduleToAdd.ScheduleID);

                    //if the dbSchedule is null, this title is not in the database
                    if (dbSchedule == null)
                    {
                        //add the Schedule to the database and save changes
                        db.Schedules.Add(ScheduleToAdd);
                        db.SaveChanges();

                        //update the counter to help with debugging
                        intScheduleAdded += 1;
                    }
                    else //dbSchedule is not null - this title *is* in the database
                    {
                        //update all of the Schedule's properties
                        dbSchedule.StartTime = ScheduleToAdd.StartTime;
                        dbSchedule.Theatre = ScheduleToAdd.Theatre;
                        //dbSchedule.Price = ScheduleToAdd.Price;
                        //dbSchedule.//SpecialEvent = ScheduleToAdd.//SpecialEvent;

                        //update the database and save the changes
                        db.Update(dbSchedule);
                        db.SaveChanges();

                        //update the counter to help with debugging
                        intScheduleAdded += 1;
                    } //this is the end of the else
                } //this is the end of the foreach loop for the Schedules
            }//this is the end of the try block

            catch (Exception ex)//something went wrong with adding or updating
            {
                //Build a messsage using the flags we created
                String msg = "  Repositories added:" + intScheduleAdded + "; Error on " + intScheduleTitle;

                //throw the exception with the new message
                throw new InvalidOperationException(ex.Message + msg);
            }
        }
    }
}