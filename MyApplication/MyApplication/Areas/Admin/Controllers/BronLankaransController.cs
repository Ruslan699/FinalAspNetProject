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
    public class BronLankaransController : Controller
    {
        private readonly ToursDbContext _context;

        public BronLankaransController(ToursDbContext context)
        {
            _context = context;
        }

        // GET: Admin/BronLankarans
        public async Task<IActionResult> Index()
        {
            return View(await _context.BronLankarans.ToListAsync());
        }

        // GET: Admin/BronLankarans/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bronLankaran = await _context.BronLankarans
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bronLankaran == null)
            {
                return NotFound();
            }

            return View(bronLankaran);
        }

        // GET: Admin/BronLankarans/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/BronLankarans/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ImagePath,ImageTitle,AboutTourText,AboutTourNumber")] BronLankaran bronLankaran)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bronLankaran);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bronLankaran);
        }

        // GET: Admin/BronLankarans/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bronLankaran = await _context.BronLankarans.FindAsync(id);
            if (bronLankaran == null)
            {
                return NotFound();
            }
            return View(bronLankaran);
        }

        // POST: Admin/BronLankarans/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ImagePath,ImageTitle,AboutTourText,AboutTourNumber")] BronLankaran bronLankaran)
        {
            if (id != bronLankaran.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bronLankaran);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BronLankaranExists(bronLankaran.Id))
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
            return View(bronLankaran);
        }

        // GET: Admin/BronLankarans/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bronLankaran = await _context.BronLankarans
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bronLankaran == null)
            {
                return NotFound();
            }

            return View(bronLankaran);
        }

        // POST: Admin/BronLankarans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bronLankaran = await _context.BronLankarans.FindAsync(id);
            _context.BronLankarans.Remove(bronLankaran);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BronLankaranExists(int id)
        {
            return _context.BronLankarans.Any(e => e.Id == id);
        }
    }
}
