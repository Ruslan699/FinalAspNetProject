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
    public class BronNaftalansController : Controller
    {
        private readonly ToursDbContext _context;

        public BronNaftalansController(ToursDbContext context)
        {
            _context = context;
        }

        // GET: Admin/BronNaftalans
        public async Task<IActionResult> Index()
        {
            return View(await _context.BronNaftalans.ToListAsync());
        }

        // GET: Admin/BronNaftalans/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bronNaftalan = await _context.BronNaftalans
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bronNaftalan == null)
            {
                return NotFound();
            }

            return View(bronNaftalan);
        }

        // GET: Admin/BronNaftalans/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/BronNaftalans/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ImagePath,ImageTitle,AboutTourText,AboutTourNumber")] BronNaftalan bronNaftalan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bronNaftalan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bronNaftalan);
        }

        // GET: Admin/BronNaftalans/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bronNaftalan = await _context.BronNaftalans.FindAsync(id);
            if (bronNaftalan == null)
            {
                return NotFound();
            }
            return View(bronNaftalan);
        }

        // POST: Admin/BronNaftalans/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ImagePath,ImageTitle,AboutTourText,AboutTourNumber")] BronNaftalan bronNaftalan)
        {
            if (id != bronNaftalan.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bronNaftalan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BronNaftalanExists(bronNaftalan.Id))
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
            return View(bronNaftalan);
        }

        // GET: Admin/BronNaftalans/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bronNaftalan = await _context.BronNaftalans
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bronNaftalan == null)
            {
                return NotFound();
            }

            return View(bronNaftalan);
        }

        // POST: Admin/BronNaftalans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bronNaftalan = await _context.BronNaftalans.FindAsync(id);
            _context.BronNaftalans.Remove(bronNaftalan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BronNaftalanExists(int id)
        {
            return _context.BronNaftalans.Any(e => e.Id == id);
        }
    }
}
