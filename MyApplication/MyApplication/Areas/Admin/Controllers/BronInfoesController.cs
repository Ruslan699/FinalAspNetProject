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
    public class BronInfoesController : Controller
    {
        private readonly ToursDbContext _context;

        public BronInfoesController(ToursDbContext context)
        {
            _context = context;
        }

        // GET: Admin/BronInfoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.BronInfos.ToListAsync());
        }

        // GET: Admin/BronInfoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bronInfo = await _context.BronInfos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bronInfo == null)
            {
                return NotFound();
            }

            return View(bronInfo);
        }

        // GET: Admin/BronInfoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/BronInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,BronEnum,ImagePath,ImageText,AboutTourText,AboutTourNumber")] BronInfo bronInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bronInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bronInfo);
        }

        // GET: Admin/BronInfoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bronInfo = await _context.BronInfos.FindAsync(id);
            if (bronInfo == null)
            {
                return NotFound();
            }
            return View(bronInfo);
        }

        // POST: Admin/BronInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,BronEnum,ImagePath,ImageText,AboutTourText,AboutTourNumber")] BronInfo bronInfo)
        {
            if (id != bronInfo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bronInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BronInfoExists(bronInfo.Id))
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
            return View(bronInfo);
        }

        // GET: Admin/BronInfoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bronInfo = await _context.BronInfos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bronInfo == null)
            {
                return NotFound();
            }

            return View(bronInfo);
        }

        // POST: Admin/BronInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bronInfo = await _context.BronInfos.FindAsync(id);
            _context.BronInfos.Remove(bronInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BronInfoExists(int id)
        {
            return _context.BronInfos.Any(e => e.Id == id);
        }
    }
}
