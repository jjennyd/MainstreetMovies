using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Group_6_Final_Project.DAL;
using Group_6_Final_Project.Models;

namespace Group_6_Final_Project.Controllers
{
    public class AppDateTimeController : Controller
    {
        private readonly AppDbContext _context;

        public AppDateTimeController(AppDbContext context)
        {
            _context = context;
        }

        // GET: AppDateTime
        public async Task<IActionResult> Index()
        {
            return View(await _context.AppDateTime.ToListAsync());
        }

        // GET: AppDateTime/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.AppDateTime == null)
            {
                return NotFound();
            }

            var appDateTime = await _context.AppDateTime
                .FirstOrDefaultAsync(m => m.AppDateTimeId == id);
            if (appDateTime == null)
            {
                return NotFound();
            }

            return View(appDateTime);
        }

        // GET: AppDateTime/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AppDateTime/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AppDateTimeId,GlobalTime")] DateTime globalTime)
        {
            var appDateTime = new AppDateTime(globalTime);

            if (ModelState.IsValid)
            {
                _context.Add(appDateTime);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(appDateTime);
        }

        // POST: AppDateTime/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AppDateTimeId,GlobalTime")] DateTime globalTime)
        {
            var appDateTime = await _context.AppDateTime.FindAsync(id);
            appDateTime.SetDateTime(globalTime);

            if (id != appDateTime.AppDateTimeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(appDateTime);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AppDateTimeExists(appDateTime.AppDateTimeId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(appDateTime);
        }


        // GET: AppDateTime/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.AppDateTime == null)
            {
                return NotFound();
            }

            var appDateTime = await _context.AppDateTime.FindAsync(id);
            if (appDateTime == null)
            {
                return NotFound();
            }
            return View(appDateTime);
        }

        // GET: AppDateTime/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.AppDateTime == null)
            {
                return NotFound();
            }

            var appDateTime = await _context.AppDateTime
                .FirstOrDefaultAsync(m => m.AppDateTimeId == id);
            if (appDateTime == null)
            {
                return NotFound();
            }

            return View(appDateTime);
        }

        // POST: AppDateTime/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.AppDateTime == null)
            {
                return Problem("Entity set 'AppDbContext.AppDateTime' is null.");
            }

            var appDateTime = await _context.AppDateTime.FindAsync(id);
            if (appDateTime != null)
            {
                _context.AppDateTime.Remove(appDateTime);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AppDateTimeExists(int id)
        {
            return _context.AppDateTime.Any(e => e.AppDateTimeId == id);
        }
    }
}
