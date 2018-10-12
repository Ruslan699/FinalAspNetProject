using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyApplication.Models;

namespace MyApplication.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BilgehDescriptionsController : Controller
    {
        private readonly ToursDbContext _context;

        public BilgehDescriptionsController(ToursDbContext context)
        {
            _context = context;
        }

        // GET: Admin/BilgehDescriptions
        public async Task<IActionResult> Index()
        {
            return View(await _context.BilgehDescriptions.ToListAsync());
        }

        // GET: Admin/BilgehDescriptions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bilgehDescription = await _context.BilgehDescriptions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bilgehDescription == null)
            {
                return NotFound();
            }

            return View(bilgehDescription);
        }

        // GET: Admin/BilgehDescriptions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/BilgehDescriptions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AboutHotel")] BilgehDescription bilgehDescription)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bilgehDescription);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bilgehDescription);
        }

        // GET: Admin/BilgehDescriptions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bilgehDescription = await _context.BilgehDescriptions.FindAsync(id);
            if (bilgehDescription == null)
            {
                return NotFound();
            }
            return View(bilgehDescription);
        }

        // POST: Admin/BilgehDescriptions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AboutHotel")] BilgehDescription bilgehDescription)
        {
            if (id != bilgehDescription.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bilgehDescription);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BilgehDescriptionExists(bilgehDescription.Id))
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
            return View(bilgehDescription);
        }

        // GET: Admin/BilgehDescriptions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bilgehDescription = await _context.BilgehDescriptions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bilgehDescription == null)
            {
                return NotFound();
            }

            return View(bilgehDescription);
        }

        // POST: Admin/BilgehDescriptions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bilgehDescription = await _context.BilgehDescriptions.FindAsync(id);
            _context.BilgehDescriptions.Remove(bilgehDescription);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BilgehDescriptionExists(int id)
        {
            return _context.BilgehDescriptions.Any(e => e.Id == id);
        }
    }
}
