using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Group_6_Final_Project.DAL;
using Group_6_Final_Project.Models;

namespace Group6FinalProject.Controllers
{
    public class TransactionDetailsController : Controller
    {
        private readonly AppDbContext _context;

        public TransactionDetailsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: TransactionDetails
        public IActionResult Index(int? transactionID)
        {
            if (transactionID == null)
            {
                return View("Error", new String[] { "Please specify an transaction to view!" });
            }

            List<TransactionDetail> ods = _context.TransactionDetails
                                          .Include(od => od.Schedule)
                                          .ThenInclude(od => od.Movie)
                                          .Where(od => od.Transaction.TransactionID == transactionID)
                                          .ToList();

            return View(ods);
        }

        // GET: TransactionDetails/Create
        public IActionResult Create(int transactionID)
        {
            //create a new instance of the TransactionDetail class
            TransactionDetail td = new TransactionDetail();

            //find the transaction that should be associated with this transaction
            Transaction dbTransaction = _context.Transactions.Find(transactionID);

            //set the new transaction detail's transaction equal to the transaction you just found
            td.Transaction = dbTransaction;

            ViewBag.ScheduledMovies = GetScheduleSelectList();

            return View(td);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TransactionDetail transactionDetail, int SelectedSchedule)
        {
            // Find the scheduled movie to be associated with this transaction
            Schedule dbSchedule = _context.Schedules.Find(SelectedSchedule);

            // Set the transaction detail's scheduled movie to be equal to the one we just found
            transactionDetail.Schedule = dbSchedule;

            transactionDetail.NumberofTickets = 1;

            // Find the transaction on the database that has the correct transaction id
            Transaction dbTransaction = _context.Transactions.Find(transactionDetail.Transaction.TransactionID);

            // Set the transaction on the transaction detail equal to the transaction we just found
            transactionDetail.Transaction = dbTransaction;

            // Find the Price entity based on the selected schedule
            Price price = _context.Prices.Find(dbSchedule.PriceID);

            // Check if the Price entity is found
            if (price != null)
            {
                // Use the TicketPrice property of the Price entity
                transactionDetail.SchedulePrice = price.TicketPrice;

                // Apply a $2 discount when SeniorDiscount is true
                if (transactionDetail.SeniorDiscount)
                {
                    transactionDetail.SchedulePrice -= 2;
                }
            }
            else
            {
                // Handle the case where the Price entity is not found
                // You might want to log an error, set a default price, or take appropriate action.
            }

            // Add the transaction detail to the database
            _context.Add(transactionDetail);
            await _context.SaveChangesAsync();

            // Send the user to the details page for this transaction
            return RedirectToAction("Details", "Transaction", new { id = transactionDetail.Transaction.TransactionID });
        }


        // GET: TransactionDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TransactionDetails == null)
            {
                return NotFound();
            }

            var transactionDetail = await _context.TransactionDetails.FindAsync(id);
            if (transactionDetail == null)
            {
                return NotFound();
            }
            //ViewData["ScheduleID"] = new SelectList(_context.Schedules, "ScheduleID", "ScheduleID", transactionDetail.ScheduleID);
            ViewData["TransactionID"] = new SelectList(_context.Transactions, "TransactionID", "TransactionID", transactionDetail.TransactionID);
            return View(transactionDetail);
        }

        // POST: TransactionDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, TransactionDetail transactionDetail)
        {
            if (id != transactionDetail.TransactionDetailID)
            {
                return View("Error", new String[] { "There was a problem editing this record. Try again!" });
            }

            TransactionDetail dbOD;
            try
            {
                dbOD = _context.TransactionDetails
                      //.Include(od => od.Schedule)
                      .Include(od => od.Transaction)
                      .FirstOrDefault(od => od.TransactionDetailID == transactionDetail.TransactionDetailID);

                if (ModelState.IsValid == false)
                {
                    return View(transactionDetail);
                }

                //dbOD.NumberOfTickets = transactionDetail.NumberOfTickets;
                //dbOD.SchedulePrice = dbOD.Schedule.SchedulePrice;
                //dbOD.ExtendedPrice = dbOD.Quantity * dbOD.ProductPrice;

                _context.Update(dbOD);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was a problem editing this record", ex.Message });
            }

            return RedirectToAction("Details", "Transaction", new { id = dbOD.Transaction.TransactionID });
        }

        // GET: OrderDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return View("Error", new String[] { "Please specify an order detail to delete!" });
            }

            TransactionDetail transactionDetail = await _context.TransactionDetails
                                                    .Include(o => o.Transaction)
                                                    .Include(o => o.Schedule)
                                                    .ThenInclude(o => o.Movie)
                                                   .FirstOrDefaultAsync(m => m.TransactionDetailID == id);

            if (transactionDetail == null)
            {
                return View("Error", new String[] { "This transaction detail was not in the database!" });
            }

            return View(transactionDetail);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            TransactionDetail transactionDetail = await _context.TransactionDetails
                                                    .Include(o => o.Transaction)
                                                    .FirstOrDefaultAsync(o => o.TransactionDetailID == id);

            if (transactionDetail == null)
            {
                // Handle the case when the transactionDetail is not found
                return NotFound();
            }

            _context.TransactionDetails.Remove(transactionDetail);
            await _context.SaveChangesAsync();

            // Redirect to the "Details" action of the "Transactions" controller with the correct TransactionID
            return RedirectToAction("Details", "Transaction", new { id = transactionDetail.Transaction.TransactionID });
        }



        //private SelectList GetProductSelectList()
        //{
        //    List<Schedule> allProducts = _context.Schedules.ToList();

        //    // Create a list of SelectListItem using ScheduleID and other properties from the Schedule model
        //    var productItems = allProducts.Select(schedule => new SelectListItem
        //    {
        //        // Assuming ScheduleID, StartTime, and Theatre are properties of the Schedule model
        //        Value = $"{schedule.ScheduleID}",
        //        Text = $"{schedule.StartTime:yyyy-MM-dd HH:mm} - Theatre {schedule.Theatre}"
        //    }).ToList();

        //    // Create the SelectList
        //    SelectList slAllProducts = new SelectList(productItems, "Value", "Text");

        //    return slAllProducts;
        //}
        private SelectList GetStartTime()
        {
            List<Schedule> allStartTime = _context.Schedules.ToList();

            SelectList slallStartTime = new SelectList(allStartTime, nameof(Schedule.ScheduleID), nameof(Schedule.StartTime));

            return slallStartTime;
        }
        //private SelectList GetTheatre()
        //{
        //    List<Schedule> allTheatre = _context.Schedules.ToList();

        //    SelectList slallTheatre = new SelectList(allTheatre, nameof(Schedule.ScheduleID), nameof(Schedule.Theatre));

        //    return slallTheatre;
        //}

        private SelectList GetScheduleSelectList()
        {
            //create a list for all the scheduled movies
            List<Schedule> allScheduledMovies = _context.Schedules.ToList();

            //the user MUST select a scheduled movie, so you don't need a dummy option for no movie

            //use the constructor on select list to create a new select list with the options
            SelectList GetAllScheduledMovies = new SelectList(allScheduledMovies, nameof(Schedule.ScheduleID), nameof(Schedule.Theatre), nameof(Schedule.StartTime));

            return GetAllScheduledMovies;
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> GiftTickets(int transactionID, string recipientEmail)
        {
            // Fetch the transaction from the database
            var transaction = await _context.Transactions
                .Include(t => t.TransactionDetail)
                .FirstOrDefaultAsync(t => t.TransactionID == transactionID);

            if (transaction == null || transaction.PurchaseStatus != PurchaseStatus.Pending)
            {
                // Handle the case where the transaction is not found or not in a pending state
                // You may want to redirect to an error page or display a message
                return RedirectToAction("Index", "Home"); // Adjust the redirection as needed
            }

            // Save changes to the database
            await _context.SaveChangesAsync();

            // Redirect to a confirmation page or display a success message
            return RedirectToAction("ThanYou", new { transactionID = transactionID });
        }

    }
}