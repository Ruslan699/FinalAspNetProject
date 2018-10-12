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
    public class QubaPageDescriptionsController : Controller
    {
        private readonly ToursDbContext _context;

        public QubaPageDescriptionsController(ToursDbContext context)
        {
            _context = context;
        }

        // GET: Admin/QubaPageDescriptions
        public async Task<IActionResult> Index()
        {
            return View(await _context.QubaPageDescriptions.ToListAsync());
        }

        // GET: Admin/QubaPageDescriptions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qubaPageDescription = await _context.QubaPageDescriptions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (qubaPageDescription == null)
            {
                return NotFound();
            }

            return View(qubaPageDescription);
        }

        // GET: Admin/QubaPageDescriptions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/QubaPageDescriptions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AboutQuba")] QubaPageDescription qubaPageDescription)
        {
            if (ModelState.IsValid)
            {
                _context.Add(qubaPageDescription);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(qubaPageDescription);
        }

        // GET: Admin/QubaPageDescriptions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qubaPageDescription = await _context.QubaPageDescriptions.FindAsync(id);
            if (qubaPageDescription == null)
            {
                return NotFound();
            }
            return View(qubaPageDescription);
        }

        // POST: Admin/QubaPageDescriptions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AboutQuba")] QubaPageDescription qubaPageDescription)
        {
            if (id != qubaPageDescription.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(qubaPageDescription);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QubaPageDescriptionExists(qubaPageDescription.Id))
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
            return View(qubaPageDescription);
        }

        // GET: Admin/QubaPageDescriptions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qubaPageDescription = await _context.QubaPageDescriptions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (qubaPageDescription == null)
            {
                return NotFound();
            }

            return View(qubaPageDescription);
        }

        // POST: Admin/QubaPageDescriptions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var qubaPageDescription = await _context.QubaPageDescriptions.FindAsync(id);
            _context.QubaPageDescriptions.Remove(qubaPageDescription);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QubaPageDescriptionExists(int id)
        {
            return _context.QubaPageDescriptions.Any(e => e.Id == id);
        }
    }
}
