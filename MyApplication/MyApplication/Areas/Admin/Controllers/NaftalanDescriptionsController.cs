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
    public class NaftalanDescriptionsController : Controller
    {
        private readonly ToursDbContext _context;

        public NaftalanDescriptionsController(ToursDbContext context)
        {
            _context = context;
        }

        // GET: Admin/NaftalanDescriptions
        public async Task<IActionResult> Index()
        {
            return View(await _context.NaftalanDescriptions.ToListAsync());
        }

        // GET: Admin/NaftalanDescriptions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var naftalanDescription = await _context.NaftalanDescriptions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (naftalanDescription == null)
            {
                return NotFound();
            }

            return View(naftalanDescription);
        }

        // GET: Admin/NaftalanDescriptions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/NaftalanDescriptions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Hotels")] NaftalanDescription naftalanDescription)
        {
            if (ModelState.IsValid)
            {
                _context.Add(naftalanDescription);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(naftalanDescription);
        }

        // GET: Admin/NaftalanDescriptions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var naftalanDescription = await _context.NaftalanDescriptions.FindAsync(id);
            if (naftalanDescription == null)
            {
                return NotFound();
            }
            return View(naftalanDescription);
        }

        // POST: Admin/NaftalanDescriptions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Hotels")] NaftalanDescription naftalanDescription)
        {
            if (id != naftalanDescription.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(naftalanDescription);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NaftalanDescriptionExists(naftalanDescription.Id))
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
            return View(naftalanDescription);
        }

        // GET: Admin/NaftalanDescriptions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var naftalanDescription = await _context.NaftalanDescriptions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (naftalanDescription == null)
            {
                return NotFound();
            }

            return View(naftalanDescription);
        }

        // POST: Admin/NaftalanDescriptions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var naftalanDescription = await _context.NaftalanDescriptions.FindAsync(id);
            _context.NaftalanDescriptions.Remove(naftalanDescription);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NaftalanDescriptionExists(int id)
        {
            return _context.NaftalanDescriptions.Any(e => e.Id == id);
        }
    }
}
