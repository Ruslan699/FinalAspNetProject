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
    public class FireMountainDescriptionsController : Controller
    {
        private readonly ToursDbContext _context;

        public FireMountainDescriptionsController(ToursDbContext context)
        {
            _context = context;
        }

        // GET: Admin/FireMountainDescriptions
        public async Task<IActionResult> Index()
        {
            return View(await _context.FireMountainDescriptions.ToListAsync());
        }

        // GET: Admin/FireMountainDescriptions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fireMountainDescription = await _context.FireMountainDescriptions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fireMountainDescription == null)
            {
                return NotFound();
            }

            return View(fireMountainDescription);
        }

        // GET: Admin/FireMountainDescriptions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/FireMountainDescriptions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TourInclude")] FireMountainDescription fireMountainDescription)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fireMountainDescription);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fireMountainDescription);
        }

        // GET: Admin/FireMountainDescriptions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fireMountainDescription = await _context.FireMountainDescriptions.FindAsync(id);
            if (fireMountainDescription == null)
            {
                return NotFound();
            }
            return View(fireMountainDescription);
        }

        // POST: Admin/FireMountainDescriptions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TourInclude")] FireMountainDescription fireMountainDescription)
        {
            if (id != fireMountainDescription.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fireMountainDescription);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FireMountainDescriptionExists(fireMountainDescription.Id))
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
            return View(fireMountainDescription);
        }

        // GET: Admin/FireMountainDescriptions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fireMountainDescription = await _context.FireMountainDescriptions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fireMountainDescription == null)
            {
                return NotFound();
            }

            return View(fireMountainDescription);
        }

        // POST: Admin/FireMountainDescriptions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fireMountainDescription = await _context.FireMountainDescriptions.FindAsync(id);
            _context.FireMountainDescriptions.Remove(fireMountainDescription);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FireMountainDescriptionExists(int id)
        {
            return _context.FireMountainDescriptions.Any(e => e.Id == id);
        }
    }
}
