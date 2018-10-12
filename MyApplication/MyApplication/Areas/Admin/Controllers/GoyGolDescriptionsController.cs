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
    public class GoyGolDescriptionsController : Controller
    {
        private readonly ToursDbContext _context;

        public GoyGolDescriptionsController(ToursDbContext context)
        {
            _context = context;
        }

        // GET: Admin/GoyGolDescriptions
        public async Task<IActionResult> Index()
        {
            return View(await _context.GoyGolDescriptions.ToListAsync());
        }

        // GET: Admin/GoyGolDescriptions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var goyGolDescription = await _context.GoyGolDescriptions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (goyGolDescription == null)
            {
                return NotFound();
            }

            return View(goyGolDescription);
        }

        // GET: Admin/GoyGolDescriptions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/GoyGolDescriptions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TourInclude")] GoyGolDescription goyGolDescription)
        {
            if (ModelState.IsValid)
            {
                _context.Add(goyGolDescription);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(goyGolDescription);
        }

        // GET: Admin/GoyGolDescriptions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var goyGolDescription = await _context.GoyGolDescriptions.FindAsync(id);
            if (goyGolDescription == null)
            {
                return NotFound();
            }
            return View(goyGolDescription);
        }

        // POST: Admin/GoyGolDescriptions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TourInclude")] GoyGolDescription goyGolDescription)
        {
            if (id != goyGolDescription.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(goyGolDescription);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GoyGolDescriptionExists(goyGolDescription.Id))
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
            return View(goyGolDescription);
        }

        // GET: Admin/GoyGolDescriptions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var goyGolDescription = await _context.GoyGolDescriptions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (goyGolDescription == null)
            {
                return NotFound();
            }

            return View(goyGolDescription);
        }

        // POST: Admin/GoyGolDescriptions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var goyGolDescription = await _context.GoyGolDescriptions.FindAsync(id);
            _context.GoyGolDescriptions.Remove(goyGolDescription);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GoyGolDescriptionExists(int id)
        {
            return _context.GoyGolDescriptions.Any(e => e.Id == id);
        }
    }
}
