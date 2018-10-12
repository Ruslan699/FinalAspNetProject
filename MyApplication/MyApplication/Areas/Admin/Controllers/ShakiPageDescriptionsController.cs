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
    public class ShakiPageDescriptionsController : Controller
    {
        private readonly ToursDbContext _context;

        public ShakiPageDescriptionsController(ToursDbContext context)
        {
            _context = context;
        }

        // GET: Admin/ShakiPageDescriptions
        public async Task<IActionResult> Index()
        {
            return View(await _context.ShakiPageDescriptions.ToListAsync());
        }

        // GET: Admin/ShakiPageDescriptions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shakiPageDescription = await _context.ShakiPageDescriptions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (shakiPageDescription == null)
            {
                return NotFound();
            }

            return View(shakiPageDescription);
        }

        // GET: Admin/ShakiPageDescriptions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/ShakiPageDescriptions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TourInclude")] ShakiPageDescription shakiPageDescription)
        {
            if (ModelState.IsValid)
            {
                _context.Add(shakiPageDescription);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(shakiPageDescription);
        }

        // GET: Admin/ShakiPageDescriptions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shakiPageDescription = await _context.ShakiPageDescriptions.FindAsync(id);
            if (shakiPageDescription == null)
            {
                return NotFound();
            }
            return View(shakiPageDescription);
        }

        // POST: Admin/ShakiPageDescriptions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TourInclude")] ShakiPageDescription shakiPageDescription)
        {
            if (id != shakiPageDescription.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shakiPageDescription);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShakiPageDescriptionExists(shakiPageDescription.Id))
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
            return View(shakiPageDescription);
        }

        // GET: Admin/ShakiPageDescriptions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shakiPageDescription = await _context.ShakiPageDescriptions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (shakiPageDescription == null)
            {
                return NotFound();
            }

            return View(shakiPageDescription);
        }

        // POST: Admin/ShakiPageDescriptions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var shakiPageDescription = await _context.ShakiPageDescriptions.FindAsync(id);
            _context.ShakiPageDescriptions.Remove(shakiPageDescription);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShakiPageDescriptionExists(int id)
        {
            return _context.ShakiPageDescriptions.Any(e => e.Id == id);
        }
    }
}
