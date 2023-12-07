using Microsoft.AspNetCore.Identity;
using Group_6_Final_Project.Utilities;
using Group_6_Final_Project.DAL;
using Group_6_Final_Project.Models;
using Microsoft.SqlServer.Server;
using static System.Reflection.Metadata.BlobBuilder;

namespace Group_6_Final_Project.Seeding
{
    public static class SeedTransactions
    {
        public static void Transaction(AppDbContext db)
        {
            //Create a counter and a flag so we will know which record is causing problems
            Int32 intTransactionsAdded = 0;
            int intTransactionsID = 0;

            //Add the list of Transactions
            List<Transaction> Transactions = new List<Transaction>();

            Transactions.Add(new Transaction
            {
                TransactionDate = new DateTime(2023, 11, 1),
                PurchaseStatus = PurchaseStatus.Purchased, ConfirmNumber = 10002,
                AppUserId = db.Users.FirstOrDefault(u => u.UserName == "banker@longhorn.net")?.Id ?? string.Empty,
                TransactionNumber = 1,
                TransactionDetail = new List<TransactionDetail>
                {
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.A1,
                        SchedulePrice = 5.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 23, 11, 0, 0) && ds.Theatre == Theatre.Theatre2)?.ScheduleID ?? default(int),
                    },
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.A2,
                        SchedulePrice = 5.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 23, 11, 0, 0) && ds.Theatre == Theatre.Theatre2)?.ScheduleID ?? default(int)
                    },
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.A3,
                        SchedulePrice = 5.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 23, 11, 0, 0) && ds.Theatre == Theatre.Theatre2)?.ScheduleID ?? default(int)
                    },
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.A4,
                        SchedulePrice = 5.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 23, 11, 0, 0) && ds.Theatre == Theatre.Theatre2)?.ScheduleID ?? default(int)
                    },
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.A5,
                        SchedulePrice = 5.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 23, 11, 0, 0) && ds.Theatre == Theatre.Theatre2)?.ScheduleID ?? default(int)
                    },
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.B1,
                        SchedulePrice = 5.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 23, 11, 0, 0) && ds.Theatre == Theatre.Theatre2)?.ScheduleID ?? default(int)
                    },
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.B2,
                        SchedulePrice = 5.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 23, 11, 0, 0) && ds.Theatre == Theatre.Theatre2)?.ScheduleID ?? default(int)
                    },
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.B3,
                        SchedulePrice = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 23, 11, 0, 0) && ds.Theatre == Theatre.Theatre2)?.Price?.TicketPrice ?? default(decimal),
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 23, 11, 0, 0) && ds.Theatre == Theatre.Theatre2)?.ScheduleID ?? default(int)
                    },
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.B4,
                        SchedulePrice = 5.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 23, 11, 0, 0) && ds.Theatre == Theatre.Theatre2)?.ScheduleID ?? default(int)
                    },
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.B5,
                        SchedulePrice = 5.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 23, 11, 0, 0) && ds.Theatre == Theatre.Theatre2)?.ScheduleID ?? default(int)
                    },
                }
            }); ;

            Transactions.Add(new Transaction
            {
                TransactionDate = new DateTime(2023, 11, 5),
                PurchaseStatus = PurchaseStatus.Purchased, ConfirmNumber = 10003,
                AppUserId = db.Users.FirstOrDefault(u => u.UserName == "cbaker@example.com")?.Id ?? string.Empty,
                TransactionNumber = 2,
                TransactionDetail = new List<TransactionDetail>
                {
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.A1,
                        SchedulePrice = 10.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = true,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 23, 16, 30, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.A2,
                        SchedulePrice = 10.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = true,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 23, 16, 30, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.A3,
                        SchedulePrice = 12.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 23, 16, 30, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.A4,
                        SchedulePrice = 12.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 23, 16, 30, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.A5,
                        SchedulePrice = 12.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 23, 16, 30, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.B1,
                        SchedulePrice = 12.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 23, 16, 30, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.B2,
                        SchedulePrice = 12.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 23, 16, 30, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.B3,
                        SchedulePrice = 12.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 23, 16, 30, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.B4,
                        SchedulePrice = 12.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 23, 16, 30, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.B5,
                        SchedulePrice = 12.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 23, 16, 30, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                }
            });

            Transactions.Add(new Transaction
            {
                TransactionDate = new DateTime(2023, 11, 20),
                PurchaseStatus = PurchaseStatus.Purchased, ConfirmNumber = 10004,
                AppUserId = db.Users.FirstOrDefault(u => u.UserName == "ingram@jack.com")?.Id ?? string.Empty,
                TransactionNumber = 3,
                TransactionDetail = new List<TransactionDetail>
                {
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.C2,
                        SchedulePrice = 5.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 23, 11, 00, 0) && ds.Theatre == Theatre.Theatre2)?.ScheduleID ?? default(int)
                    },
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.C3,
                        SchedulePrice = 5.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 23, 11, 00, 0) && ds.Theatre == Theatre.Theatre2)?.ScheduleID ?? default(int)
                    },
                }
            });

            Transactions.Add(new Transaction
            {
                TransactionDate = new DateTime(2023, 11, 14),
                PurchaseStatus = PurchaseStatus.Purchased, ConfirmNumber = 10005,
                AppUserId = db.Users.FirstOrDefault(u => u.UserName == "banker@longhorn.net")?.Id ?? string.Empty,
                TransactionNumber = 4,
                TransactionDetail = new List<TransactionDetail>
                {
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.C4,
                        SchedulePrice = 5.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 23, 11, 00, 0) && ds.Theatre == Theatre.Theatre2)?.ScheduleID ?? default(int)
                    },
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.C5,
                        SchedulePrice = 5.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 23, 11, 00, 0) && ds.Theatre == Theatre.Theatre2)?.ScheduleID ?? default(int)
                    },
                }
            });

            Transactions.Add(new Transaction
            {
                TransactionDate = new DateTime(2023, 11, 5),
                PurchaseStatus = PurchaseStatus.Purchased, ConfirmNumber = 10006,
                AppUserId = db.Users.FirstOrDefault(u => u.UserName == "franco@example.com")?.Id ?? string.Empty,
                TransactionNumber = 5,
                TransactionDetail = new List<TransactionDetail>
                {
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.A1,
                        SchedulePrice = 12.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 24, 21, 00, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                }
            });

            Transactions.Add(new Transaction
            {
                TransactionDate = new DateTime(2023, 11, 20),
                PurchaseStatus = PurchaseStatus.Purchased, ConfirmNumber = 10007,
                AppUserId = db.Users.FirstOrDefault(u => u.UserName == "wchang@example.com")?.Id ?? string.Empty,
                TransactionNumber = 6,
                TransactionDetail = new List<TransactionDetail>
                {
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.A2,
                        SchedulePrice = 10.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = true,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 24, 21, 00, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                }
            });

            Transactions.Add(new Transaction
            {
                TransactionDate = new DateTime(2023, 11, 14),
                PurchaseStatus = PurchaseStatus.Purchased, ConfirmNumber = 10008,
                AppUserId = db.Users.FirstOrDefault(u => u.UserName == "limchou@gogle.com")?.Id ?? string.Empty,
                TransactionNumber = 7,
                TransactionDetail = new List<TransactionDetail>
                {
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.A3,
                        SchedulePrice = 12.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 24, 21, 00, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                }
            });

            Transactions.Add(new Transaction
            {
                TransactionDate = new DateTime(2023, 11, 20),
                PurchaseStatus = PurchaseStatus.Purchased, ConfirmNumber = 10009,
                AppUserId = db.Users.FirstOrDefault(u => u.UserName == "ingram@jack.com")?.Id ?? string.Empty,
                TransactionNumber = 8,
                TransactionDetail = new List<TransactionDetail>
                {
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.A4,
                        SchedulePrice = 12.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 24, 21, 00, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                }
            });

            Transactions.Add(new Transaction
            {
                TransactionDate = new DateTime(2023, 11, 5),
                PurchaseStatus = PurchaseStatus.Purchased, ConfirmNumber = 10010,
                AppUserId = db.Users.FirstOrDefault(u => u.UserName == "shdixon@aoll.com")?.Id ?? string.Empty,
                TransactionNumber = 9,
                TransactionDetail = new List<TransactionDetail>
                {
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.A5,
                        SchedulePrice = 12.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 24, 21, 00, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                }
            });

            Transactions.Add(new Transaction
            {
                TransactionDate = new DateTime(2023, 11, 20),
                PurchaseStatus = PurchaseStatus.Purchased, ConfirmNumber = 10011,
                AppUserId = db.Users.FirstOrDefault(u => u.UserName == "j.b.evans@aheca.org")?.Id ?? string.Empty,
                TransactionNumber = 10,
                TransactionDetail = new List<TransactionDetail>
                {
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.B1,
                        SchedulePrice = 12.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 24, 21, 00, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                }
            });

            Transactions.Add(new Transaction
            {
                TransactionDate = new DateTime(2023, 11, 14),
                PurchaseStatus = PurchaseStatus.Purchased, ConfirmNumber = 10012,
                AppUserId = db.Users.FirstOrDefault(u => u.UserName == "feeley@penguin.org")?.Id ?? string.Empty,
                TransactionNumber = 11,
                TransactionDetail = new List<TransactionDetail>
                {
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.B2,
                        SchedulePrice = 12.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 24, 21, 00, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                }
            });

            Transactions.Add(new Transaction
            {
                TransactionDate = new DateTime(2023, 11, 20),
                PurchaseStatus = PurchaseStatus.Purchased, ConfirmNumber = 10013,
                AppUserId = db.Users.FirstOrDefault(u => u.UserName == "ingram@jack.com")?.Id ?? string.Empty,
                TransactionNumber = 12,
                TransactionDetail = new List<TransactionDetail>
                {
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.B3,
                        SchedulePrice = 12.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 24, 21, 00, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                }
            });

            Transactions.Add(new Transaction
            {
                TransactionDate = new DateTime(2023, 11, 5),
                PurchaseStatus = PurchaseStatus.Purchased, ConfirmNumber = 10014,
                AppUserId = db.Users.FirstOrDefault(u => u.UserName == "thequeen@aska.net")?.Id ?? string.Empty,
                TransactionNumber = 13,
                TransactionDetail = new List<TransactionDetail>
                {
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.B4,
                        SchedulePrice = 12.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 24, 21, 00, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                }
            });

            Transactions.Add(new Transaction
            {
                TransactionDate = new DateTime(2023, 11, 20),
                PurchaseStatus = PurchaseStatus.Cancelled,
                ConfirmNumber = 10015,
                AppUserId = db.Users.FirstOrDefault(u => u.UserName == "linebacker@gogle.com")?.Id ?? string.Empty,
                TransactionNumber = 14,
                TransactionDetail = new List<TransactionDetail>
                {
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.B5,
                        SchedulePrice = 12.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 24, 21, 00, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                }
            });

            Transactions.Add(new Transaction
            {
                TransactionDate = new DateTime(2023, 11, 14),
                PurchaseStatus = PurchaseStatus.Purchased, ConfirmNumber = 10016,
                AppUserId = db.Users.FirstOrDefault(u => u.UserName == "elowe@netscare.net")?.Id ?? string.Empty,
                TransactionNumber = 15,
                TransactionDetail = new List<TransactionDetail>
                {
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.E1,
                        SchedulePrice = 12.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 24, 21, 00, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                }
            });

            Transactions.Add(new Transaction
            {
                TransactionDate = new DateTime(2023, 11, 20),
                PurchaseStatus = PurchaseStatus.Purchased, ConfirmNumber = 10017,
                AppUserId = db.Users.FirstOrDefault(u => u.UserName == "ingram@jack.com")?.Id ?? string.Empty,
                TransactionNumber = 16,
                TransactionDetail = new List<TransactionDetail>
                {
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.E2,
                        SchedulePrice = 12.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 24, 21, 00, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                }
            });

            Transactions.Add(new Transaction
            {
                TransactionDate = new DateTime(2023, 11, 20),
                PurchaseStatus = PurchaseStatus.Purchased, ConfirmNumber = 10018,
                AppUserId = db.Users.FirstOrDefault(u => u.UserName == "ingram@jack.com")?.Id ?? string.Empty,
                TransactionNumber = 17,
                TransactionDetail = new List<TransactionDetail>
                {
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.E3,
                        SchedulePrice = 12.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 24, 21, 00, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                }
            });

            Transactions.Add(new Transaction
            {
                TransactionDate = new DateTime(2023, 11, 20),
                PurchaseStatus = PurchaseStatus.Purchased, ConfirmNumber = 10019,
                AppUserId = db.Users.FirstOrDefault(u => u.UserName == "ingram@jack.com")?.Id ?? string.Empty,
                TransactionNumber = 18,
                TransactionDetail = new List<TransactionDetail>
                {
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.E4,
                        SchedulePrice = 12.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 24, 21, 00, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                }
            });

            Transactions.Add(new Transaction
            {
                TransactionDate = new DateTime(2023, 11, 20),
                PurchaseStatus = PurchaseStatus.Purchased, ConfirmNumber = 10020,
                AppUserId = db.Users.FirstOrDefault(u => u.UserName == "ingram@jack.com")?.Id ?? string.Empty,
                TransactionNumber = 19,
                TransactionDetail = new List<TransactionDetail>
                {
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.E5,
                        SchedulePrice = 12.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 24, 21, 00, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                }
            });

            Transactions.Add(new Transaction
            {
                TransactionDate = new DateTime(2023, 11, 20),
                PurchaseStatus = PurchaseStatus.Purchased, ConfirmNumber = 10021,
                AppUserId = db.Users.FirstOrDefault(u => u.UserName == "ingram@jack.com")?.Id ?? string.Empty,
                TransactionNumber = 20,
                TransactionDetail = new List<TransactionDetail>
                {
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.C4,
                        SchedulePrice = 12.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 24, 21, 00, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                }
            });

            Transactions.Add(new Transaction
            {
                TransactionDate = new DateTime(2023, 11, 20),
                PurchaseStatus = PurchaseStatus.Purchased, ConfirmNumber = 10023,
                AppUserId = db.Users.FirstOrDefault(u => u.UserName == "ingram@jack.com")?.Id ?? string.Empty,
                TransactionNumber = 21,
                TransactionDetail = new List<TransactionDetail>
                {
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.C5,
                        SchedulePrice = 12.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 24, 21, 00, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                }
            });

            Transactions.Add(new Transaction
            {
                TransactionDate = new DateTime(2023, 11, 24),
                PurchaseStatus = PurchaseStatus.Purchased, ConfirmNumber = 10024,
                AppUserId = db.Users.FirstOrDefault(u => u.UserName == "banker@longhorn.net")?.Id ?? string.Empty,
                TransactionNumber = 22,
                TransactionDetail = new List<TransactionDetail>
                {
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.D1,
                        SchedulePrice = 15.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 25, 21, 00, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                }
            });

            Transactions.Add(new Transaction
            {
                TransactionDate = new DateTime(2023, 11, 24),
                PurchaseStatus = PurchaseStatus.Purchased, ConfirmNumber = 10025,
                AppUserId = db.Users.FirstOrDefault(u => u.UserName == "cbaker@example.com")?.Id ?? string.Empty,
                TransactionNumber = 23,
                TransactionDetail = new List<TransactionDetail>
                {
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.A2,
                        SchedulePrice = 15.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 25, 21, 00, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                }
            });

            Transactions.Add(new Transaction
            {
                TransactionDate = new DateTime(2023, 11, 24),
                PurchaseStatus = PurchaseStatus.Purchased, ConfirmNumber = 10026,
                AppUserId = db.Users.FirstOrDefault(u => u.UserName == "ingram@jack.com")?.Id ?? string.Empty,
                TransactionNumber = 24,
                TransactionDetail = new List<TransactionDetail>
                {
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.A3,
                        SchedulePrice = 15.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 25, 21, 00, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                }
            });

            Transactions.Add(new Transaction
            {
                TransactionDate = new DateTime(2023, 11, 24),
                PurchaseStatus = PurchaseStatus.Purchased, ConfirmNumber = 10027,
                AppUserId = db.Users.FirstOrDefault(u => u.UserName == "banker@longhorn.net")?.Id ?? string.Empty,
                TransactionNumber = 25,
                TransactionDetail = new List<TransactionDetail>
                {
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.A4,
                        SchedulePrice = 15.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 25, 21, 00, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                }
            });

            Transactions.Add(new Transaction
            {
                TransactionDate = new DateTime(2023, 11, 24),
                PurchaseStatus = PurchaseStatus.Purchased, ConfirmNumber = 10028,
                AppUserId = db.Users.FirstOrDefault(u => u.UserName == "franco@example.com")?.Id ?? string.Empty,
                TransactionNumber = 26,
                TransactionDetail = new List<TransactionDetail>
                {
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.A5,
                        SchedulePrice = 15.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 25, 21, 00, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                }
            });

            Transactions.Add(new Transaction
            {
                TransactionDate = new DateTime(2023, 11, 24),
                PurchaseStatus = PurchaseStatus.Purchased, ConfirmNumber = 10029,
                AppUserId = db.Users.FirstOrDefault(u => u.UserName == "wchang@example.com")?.Id ?? string.Empty,
                TransactionNumber = 27,
                TransactionDetail = new List<TransactionDetail>
                {
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.B1,
                        SchedulePrice = 15.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 25, 21, 00, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                }
            });

            Transactions.Add(new Transaction
            {
                TransactionDate = new DateTime(2023, 11, 24),
                PurchaseStatus = PurchaseStatus.Purchased, ConfirmNumber = 10030,
                AppUserId = db.Users.FirstOrDefault(u => u.UserName == "limchou@gogle.com")?.Id ?? string.Empty,
                TransactionNumber = 28,
                TransactionDetail = new List<TransactionDetail>
                {
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.B2,
                        SchedulePrice = 15.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 25, 21, 00, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                }
            });

            Transactions.Add(new Transaction
            {
                TransactionDate = new DateTime(2023, 11, 24),
                PurchaseStatus = PurchaseStatus.Cancelled,
                ConfirmNumber = 10031,
                AppUserId = db.Users.FirstOrDefault(u => u.UserName == "shdixon@aoll.com")?.Id ?? string.Empty,
                TransactionNumber = 29,
                TransactionDetail = new List<TransactionDetail>
                {
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.B3,
                        SchedulePrice = 15.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 25, 21, 00, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                }
            });

            Transactions.Add(new Transaction
            {
                TransactionDate = new DateTime(2023, 11, 24),
                PurchaseStatus = PurchaseStatus.Purchased, ConfirmNumber = 10032,
                AppUserId = db.Users.FirstOrDefault(u => u.UserName == "j.b.evans@aheca.org")?.Id ?? string.Empty,
                TransactionNumber = 30,
                TransactionDetail = new List<TransactionDetail>
                {
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.B4,
                        SchedulePrice = 15.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 25, 21, 00, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                }
            });

            Transactions.Add(new Transaction
            {
                TransactionDate = new DateTime(2023, 11, 24),
                PurchaseStatus = PurchaseStatus.Purchased, ConfirmNumber = 10033,
                AppUserId = db.Users.FirstOrDefault(u => u.UserName == "feeley@penguin.org")?.Id ?? string.Empty,
                TransactionNumber = 31,
                TransactionDetail = new List<TransactionDetail>
                {
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.B5,
                        SchedulePrice = 15.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 25, 21, 00, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                }
            });

            Transactions.Add(new Transaction
            {
                TransactionDate = new DateTime(2023, 11, 24),
                PurchaseStatus = PurchaseStatus.Purchased, ConfirmNumber = 10034,
                AppUserId = db.Users.FirstOrDefault(u => u.UserName == "thequeen@aska.net")?.Id ?? string.Empty,
                TransactionNumber = 32,
                TransactionDetail = new List<TransactionDetail>
                {
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.E1,
                        SchedulePrice = 15.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 25, 21, 00, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                }
            });

            Transactions.Add(new Transaction
            {
                TransactionDate = new DateTime(2023, 11, 24),
                PurchaseStatus = PurchaseStatus.Cancelled,
                ConfirmNumber = 10035,
                AppUserId = db.Users.FirstOrDefault(u => u.UserName == "linebacker@gogle.com")?.Id ?? string.Empty,
                TransactionNumber = 33,
                TransactionDetail = new List<TransactionDetail>
                {
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.E2,
                        SchedulePrice = 15.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 25, 21, 00, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                }
            });

            Transactions.Add(new Transaction
            {
                TransactionDate = new DateTime(2023, 11, 24),
                PurchaseStatus = PurchaseStatus.Purchased, ConfirmNumber = 10036,
                AppUserId = db.Users.FirstOrDefault(u => u.UserName == "elowe@netscare.net")?.Id ?? string.Empty,
                TransactionNumber = 34,
                TransactionDetail = new List<TransactionDetail>
                {
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.E3,
                        SchedulePrice = 15.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 25, 21, 00, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                }
            });

            Transactions.Add(new Transaction
            {
                TransactionDate = new DateTime(2023, 11, 24),
                PurchaseStatus = PurchaseStatus.Purchased, ConfirmNumber = 10037,
                AppUserId = db.Users.FirstOrDefault(u => u.UserName == "cbaker@example.com")?.Id ?? string.Empty,
                TransactionNumber = 35,
                TransactionDetail = new List<TransactionDetail>
                {
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.E4,
                        SchedulePrice = 15.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 25, 21, 00, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                }
            });

            Transactions.Add(new Transaction
            {
                TransactionDate = new DateTime(2023, 11, 24),
                PurchaseStatus = PurchaseStatus.Purchased, ConfirmNumber = 10038,
                AppUserId = db.Users.FirstOrDefault(u => u.UserName == "cbaker@example.com")?.Id ?? string.Empty,
                TransactionNumber = 36,
                TransactionDetail = new List<TransactionDetail>
                {
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.E5,
                        SchedulePrice = 15.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 25, 21, 00, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                }
            });

            Transactions.Add(new Transaction
            {
                TransactionDate = new DateTime(2023, 11, 24),
                PurchaseStatus = PurchaseStatus.Purchased, ConfirmNumber = 10039,
                AppUserId = db.Users.FirstOrDefault(u => u.UserName == "cbaker@example.com")?.Id ?? string.Empty,
                TransactionNumber = 37,
                TransactionDetail = new List<TransactionDetail>
                {
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.C4,
                        SchedulePrice = 15.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 25, 21, 00, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                }
            });

            Transactions.Add(new Transaction
            {
                TransactionDate = new DateTime(2023, 11, 24),
                PurchaseStatus = PurchaseStatus.Purchased, ConfirmNumber = 10040,
                AppUserId = db.Users.FirstOrDefault(u => u.UserName == "cbaker@example.com")?.Id ?? string.Empty,
                TransactionNumber = 38,
                TransactionDetail = new List<TransactionDetail>
                {
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.C5,
                        SchedulePrice = 15.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 25, 21, 00, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                }
            });

            Transactions.Add(new Transaction
            {
                TransactionDate = new DateTime(2023, 11, 24),
                PurchaseStatus = PurchaseStatus.Purchased, ConfirmNumber = 10041,
                AppUserId = db.Users.FirstOrDefault(u => u.UserName == "cbaker@example.com")?.Id ?? string.Empty,
                TransactionNumber = 39,
                TransactionDetail = new List<TransactionDetail>
                {
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.D1,
                        SchedulePrice = 15.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 25, 19, 30, 0) && ds.Theatre == Theatre.Theatre2)?.ScheduleID ?? default(int)
                    },
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.A2,
                        SchedulePrice = 15.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 25, 19, 30, 0) && ds.Theatre == Theatre.Theatre2)?.ScheduleID ?? default(int)
                    },
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.A3,
                        SchedulePrice = 15.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 25, 19, 30, 0) && ds.Theatre == Theatre.Theatre2)?.ScheduleID ?? default(int)
                    },
                }
            });

            Transactions.Add(new Transaction
            {
                TransactionDate = new DateTime(2023, 11, 1),
                PurchaseStatus = PurchaseStatus.Purchased, ConfirmNumber = 10042,
                AppUserId = db.Users.FirstOrDefault(u => u.UserName == "ingram@jack.com")?.Id ?? string.Empty,
                TransactionNumber = 40,
                TransactionDetail = new List<TransactionDetail>
                {
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.A4,
                        SchedulePrice = 15.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 25, 19, 30, 0) && ds.Theatre == Theatre.Theatre2)?.ScheduleID ?? default(int)
                    },
                     new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.A5,
                        SchedulePrice = 15.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 25, 19, 30, 0) && ds.Theatre == Theatre.Theatre2)?.ScheduleID ?? default(int)
                    },
                      new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.B1,
                        SchedulePrice = 15.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 25, 19, 30, 0) && ds.Theatre == Theatre.Theatre2)?.ScheduleID ?? default(int)
                    },
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.B2,
                        SchedulePrice = 15.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 25, 19, 30, 0) && ds.Theatre == Theatre.Theatre2)?.ScheduleID ?? default(int)
                    },
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.B3,
                        SchedulePrice = 15.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 25, 19, 30, 0) && ds.Theatre == Theatre.Theatre2)?.ScheduleID ?? default(int)
                    },
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.B4,
                        SchedulePrice = 15.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 25, 19, 30, 0) && ds.Theatre == Theatre.Theatre2)?.ScheduleID ?? default(int)
                    },
                }
            });

            Transactions.Add(new Transaction
            {
                TransactionDate = new DateTime(2023, 11, 1),
                PurchaseStatus = PurchaseStatus.Cancelled,
                ConfirmNumber = 10043,
                AppUserId = db.Users.FirstOrDefault(u => u.UserName == "banker@longhorn.net")?.Id ?? string.Empty,
                TransactionNumber = 41,
                TransactionDetail = new List<TransactionDetail>
                {
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.B5,
                        SchedulePrice = 15.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 25, 19, 30, 0) && ds.Theatre == Theatre.Theatre2)?.ScheduleID ?? default(int)
                    },
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.E1,
                        SchedulePrice = 15.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 25, 19, 30, 0) && ds.Theatre == Theatre.Theatre2)?.ScheduleID ?? default(int)
                    },
                }
            });

            Transactions.Add(new Transaction
            {
                TransactionDate = new DateTime(2023, 11, 1),
                PurchaseStatus = PurchaseStatus.Purchased, ConfirmNumber = 10044,
                AppUserId = db.Users.FirstOrDefault(u => u.UserName == "j.b.evans@aheca.org")?.Id ?? string.Empty,
                TransactionNumber = 42,
                TransactionDetail = new List<TransactionDetail>
                {
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.E2,
                        SchedulePrice = 15.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 25, 19, 30, 0) && ds.Theatre == Theatre.Theatre2)?.ScheduleID ?? default(int)
                    },
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.E3,
                        SchedulePrice = 15.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 25, 19, 30, 0) && ds.Theatre == Theatre.Theatre2)?.ScheduleID ?? default(int)
                    },
                }
            });

            Transactions.Add(new Transaction
            {
                TransactionDate = new DateTime(2023, 11, 1),
                PurchaseStatus = PurchaseStatus.Purchased, ConfirmNumber = 10045,
                AppUserId = db.Users.FirstOrDefault(u => u.UserName == "feeley@penguin.org")?.Id ?? string.Empty,
                TransactionNumber = 43,
                TransactionDetail = new List<TransactionDetail>
                {
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.E4,
                        SchedulePrice = 15.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 25, 19, 30, 0) && ds.Theatre == Theatre.Theatre2)?.ScheduleID ?? default(int)
                    },
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.E5,
                        SchedulePrice = 15.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 25, 19, 30, 0) && ds.Theatre == Theatre.Theatre2)?.ScheduleID ?? default(int)
                    },
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.C4,
                        SchedulePrice = 15.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 25, 19, 30, 0) && ds.Theatre == Theatre.Theatre2)?.ScheduleID ?? default(int)
                    },
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.C5,
                        SchedulePrice = 15.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 25, 19, 30, 0) && ds.Theatre == Theatre.Theatre2)?.ScheduleID ?? default(int)
                    },
                }
            });

            Transactions.Add(new Transaction
            {
                TransactionDate = new DateTime(2023, 11, 1),
                PurchaseStatus = PurchaseStatus.Purchased, ConfirmNumber = 10046,
                AppUserId = db.Users.FirstOrDefault(u => u.UserName == "ingram@jack.com")?.Id ?? string.Empty,
                TransactionNumber = 44,
                TransactionDetail = new List<TransactionDetail>
                {
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.B2,
                        SchedulePrice = 12.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 25, 12, 00, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.B3,
                        SchedulePrice = 12.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 25, 12, 00, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.B4,
                        SchedulePrice = 12.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 25, 12, 00, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                }
            });

            Transactions.Add(new Transaction
            {
                TransactionDate = new DateTime(2023, 11, 1),
                PurchaseStatus = PurchaseStatus.Purchased, ConfirmNumber = 10047,
                AppUserId = db.Users.FirstOrDefault(u => u.UserName == "thequeen@aska.net")?.Id ?? string.Empty,
                TransactionNumber = 45,
                TransactionDetail = new List<TransactionDetail>
                {
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.B5,
                        SchedulePrice = 12.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 25, 12, 00, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                }
            });
            Transactions.Add(new Transaction
            {
                TransactionDate = new DateTime(2023, 11, 1),
                PurchaseStatus = PurchaseStatus.Purchased, ConfirmNumber = 10048,
                AppUserId = db.Users.FirstOrDefault(u => u.UserName == "franco@example.com")?.Id ?? string.Empty,
                TransactionNumber = 46,
                TransactionDetail = new List<TransactionDetail>
                {
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.E1,
                        SchedulePrice = 12.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 25, 12, 00, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.E2,
                        SchedulePrice = 12.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 25, 12, 00, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                }
            });

            Transactions.Add(new Transaction
            {
                TransactionDate = new DateTime(2023, 11, 1),
                PurchaseStatus = PurchaseStatus.Purchased, ConfirmNumber = 10049,
                AppUserId = db.Users.FirstOrDefault(u => u.UserName == "wchang@example.com")?.Id ?? string.Empty,
                TransactionNumber = 47,
                TransactionDetail = new List<TransactionDetail>
                {
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.E3,
                        SchedulePrice = 12.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 25, 12, 00, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.E4,
                        SchedulePrice = 12.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 25, 12, 00, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                }
            });

            Transactions.Add(new Transaction
            {
                TransactionDate = new DateTime(2023, 11, 1),
                PurchaseStatus = PurchaseStatus.Purchased, ConfirmNumber = 10050,
                AppUserId = db.Users.FirstOrDefault(u => u.UserName == "cbaker@example.com")?.Id ?? string.Empty,
                TransactionNumber = 48,
                TransactionDetail = new List<TransactionDetail>
                {
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.E5,
                        SchedulePrice = 12.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 25, 12, 00, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                }
            });

            Transactions.Add(new Transaction
            {
                TransactionDate = new DateTime(2023, 11, 15),
                PurchaseStatus = PurchaseStatus.Purchased, ConfirmNumber = 10051,
                AppUserId = db.Users.FirstOrDefault(u => u.UserName == "limchou@gogle.com")?.Id ?? string.Empty,
                TransactionNumber = 49,
                TransactionDetail = new List<TransactionDetail>
                {
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.E5,
                        SchedulePrice = 12.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 25, 9, 00, 0) && ds.Theatre == Theatre.Theatre2)?.ScheduleID ?? default(int)
                    },
                }
            });

            Transactions.Add(new Transaction
            {
                TransactionDate = new DateTime(2023, 11, 24),
                PurchaseStatus = PurchaseStatus.Cancelled,
                ConfirmNumber = 10052,
                AppUserId = db.Users.FirstOrDefault(u => u.UserName == "j.b.evans@aheca.org")?.Id ?? string.Empty,
                TransactionNumber = 50,
                TransactionDetail = new List<TransactionDetail>
                {
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.A4,
                        SchedulePrice = 5.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 27, 11, 00, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.E1,
                        SchedulePrice = 5.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 27, 11, 00, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.E2,
                        SchedulePrice = 5.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 27, 11, 00, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.E3,
                        SchedulePrice = 5.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 27, 11, 00, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.E4,
                        SchedulePrice = 5.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 27, 11, 00, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.E5,
                        SchedulePrice = 5.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 27, 11, 00, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.B3,
                        SchedulePrice = 5.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 27, 11, 00, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.B4,
                        SchedulePrice = 5.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 27, 11, 00, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.B5,
                        SchedulePrice = 5.00m,
                        PaymentMethod = PaymentMethod.CashCard,  SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 11, 27, 11, 00, 0) && ds.Theatre == Theatre.Theatre1)?.ScheduleID ?? default(int)
                    },
                }
            });

            Transactions.Add(new Transaction
            {
                TransactionDate = new DateTime(2023, 11, 26),
                PurchaseStatus = PurchaseStatus.Purchased, ConfirmNumber = 10053,
                AppUserId = db.Users.FirstOrDefault(u => u.UserName == "ingram@jack.com")?.Id ?? string.Empty,
                TransactionNumber = 51,
                TransactionDetail = new List<TransactionDetail>
                {
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.C3,
                        SchedulePrice = 0.00m,
                        PaymentMethod = PaymentMethod.Points, SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 12, 4, 22, 00, 0) && ds.Theatre == Theatre.Theatre2)?.ScheduleID ?? default(int)
                    },
                    new TransactionDetail
                    {
                        NumberofTickets = 1,
                        SeatSelection = SeatSelection.C4,
                        SchedulePrice = 0.00m,
                        PaymentMethod = PaymentMethod.Points, SeniorDiscount = false,
                        ScheduleID = db.Schedules.FirstOrDefault(ds => ds.StartTime == new DateTime(2023, 12, 4, 22, 00, 0) && ds.Theatre == Theatre.Theatre2)?.ScheduleID ?? default(int)
                    },
                }
            });

            try
            {
                // Loop through each of the Transactions in the list
                foreach (Transaction TransactionsToAdd in Transactions)
                {
                    // Set the flag to the current title to help with debugging
                    intTransactionsID = TransactionsToAdd.TransactionID;

                    // Look to see if the Transactions is in the database - this assumes that no
                    // two Transactions have the same title
                    Transaction dbTransactions = db.Transactions.FirstOrDefault(b => b.TransactionID == TransactionsToAdd.TransactionID);


                    // If dbTransactions is null, this title is not in the database
                    if (dbTransactions == null)
                    {
                        // Add the Transactions to the database and save changes
                        db.Transactions.Add(TransactionsToAdd);
                        db.SaveChanges();

                        // Update the counter to help with debugging
                        intTransactionsAdded += 1;
                    }
                    else // dbTransactions is not null - this title *is* in the database
                    {
                        // Update all of the Transactions's properties
                        dbTransactions.TransactionDate = TransactionsToAdd.TransactionDate;
                        dbTransactions.PurchaseStatus = TransactionsToAdd.PurchaseStatus;

                        // Update the database and save the changes
                        db.Update(dbTransactions);
                        db.SaveChanges();

                        // Update the counter to help with debugging
                        intTransactionsAdded += 1;
                    } // This is the end of the else
                } // This is the end of the foreach loop for the Transactions
            }// This is the end of the try block

            catch (Exception ex) // Something went wrong with adding or updating
            {
                // Build a message using the flags we created
                String msg = "  Repositories added:" + intTransactionsAdded + "; Error on " + intTransactionsID;

                // Throw the exception with the new message
                throw new InvalidOperationException(ex.Message + msg);
            }
        }
    }
}