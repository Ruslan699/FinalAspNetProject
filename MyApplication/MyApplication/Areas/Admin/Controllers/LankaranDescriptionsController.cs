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
    public class LankaranDescriptionsController : Controller
    {
        private readonly ToursDbContext _context;

        public LankaranDescriptionsController(ToursDbContext context)
        {
            _context = context;
        }

        // GET: Admin/LankaranDescriptions
        public async Task<IActionResult> Index()
        {
            return View(await _context.LankaranDescriptions.ToListAsync());
        }

        // GET: Admin/LankaranDescriptions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lankaranDescription = await _context.LankaranDescriptions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lankaranDescription == null)
            {
                return NotFound();
            }

            return View(lankaranDescription);
        }

        // GET: Admin/LankaranDescriptions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/LankaranDescriptions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AboutTour")] LankaranDescription lankaranDescription)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lankaranDescription);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lankaranDescription);
        }

        // GET: Admin/LankaranDescriptions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lankaranDescription = await _context.LankaranDescriptions.FindAsync(id);
            if (lankaranDescription == null)
            {
                return NotFound();
            }
            return View(lankaranDescription);
        }

        // POST: Admin/LankaranDescriptions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AboutTour")] LankaranDescription lankaranDescription)
        {
            if (id != lankaranDescription.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lankaranDescription);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LankaranDescriptionExists(lankaranDescription.Id))
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
            return View(lankaranDescription);
        }

        // GET: Admin/LankaranDescriptions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lankaranDescription = await _context.LankaranDescriptions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lankaranDescription == null)
            {
                return NotFound();
            }

            return View(lankaranDescription);
        }

        // POST: Admin/LankaranDescriptions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lankaranDescription = await _context.LankaranDescriptions.FindAsync(id);
            _context.LankaranDescriptions.Remove(lankaranDescription);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LankaranDescriptionExists(int id)
        {
            return _context.LankaranDescriptions.Any(e => e.Id == id);
        }
    }
}
