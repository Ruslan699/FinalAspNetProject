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
    public class InsuaranceDescriptionsController : Controller
    {
        private readonly ToursDbContext _context;

        public InsuaranceDescriptionsController(ToursDbContext context)
        {
            _context = context;
        }

        // GET: Admin/InsuaranceDescriptions
        public async Task<IActionResult> Index()
        {
            return View(await _context.InsuaranceDescriptions.ToListAsync());
        }

        // GET: Admin/InsuaranceDescriptions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuaranceDescription = await _context.InsuaranceDescriptions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (insuaranceDescription == null)
            {
                return NotFound();
            }

            return View(insuaranceDescription);
        }

        // GET: Admin/InsuaranceDescriptions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/InsuaranceDescriptions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AboutInsuarance")] InsuaranceDescription insuaranceDescription)
        {
            if (ModelState.IsValid)
            {
                _context.Add(insuaranceDescription);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(insuaranceDescription);
        }

        // GET: Admin/InsuaranceDescriptions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuaranceDescription = await _context.InsuaranceDescriptions.FindAsync(id);
            if (insuaranceDescription == null)
            {
                return NotFound();
            }
            return View(insuaranceDescription);
        }

        // POST: Admin/InsuaranceDescriptions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AboutInsuarance")] InsuaranceDescription insuaranceDescription)
        {
            if (id != insuaranceDescription.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(insuaranceDescription);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InsuaranceDescriptionExists(insuaranceDescription.Id))
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
            return View(insuaranceDescription);
        }

        // GET: Admin/InsuaranceDescriptions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuaranceDescription = await _context.InsuaranceDescriptions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (insuaranceDescription == null)
            {
                return NotFound();
            }

            return View(insuaranceDescription);
        }

        // POST: Admin/InsuaranceDescriptions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var insuaranceDescription = await _context.InsuaranceDescriptions.FindAsync(id);
            _context.InsuaranceDescriptions.Remove(insuaranceDescription);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InsuaranceDescriptionExists(int id)
        {
            return _context.InsuaranceDescriptions.Any(e => e.Id == id);
        }
    }
}
