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
    public class QakhDescriptionsController : Controller
    {
        private readonly ToursDbContext _context;

        public QakhDescriptionsController(ToursDbContext context)
        {
            _context = context;
        }

        // GET: Admin/QakhDescriptions
        public async Task<IActionResult> Index()
        {
            return View(await _context.QakhDescriptions.ToListAsync());
        }

        // GET: Admin/QakhDescriptions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qakhDescriptions = await _context.QakhDescriptions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (qakhDescriptions == null)
            {
                return NotFound();
            }

            return View(qakhDescriptions);
        }

        // GET: Admin/QakhDescriptions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/QakhDescriptions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AboutTour")] QakhDescriptions qakhDescriptions)
        {
            if (ModelState.IsValid)
            {
                _context.Add(qakhDescriptions);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(qakhDescriptions);
        }

        // GET: Admin/QakhDescriptions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qakhDescriptions = await _context.QakhDescriptions.FindAsync(id);
            if (qakhDescriptions == null)
            {
                return NotFound();
            }
            return View(qakhDescriptions);
        }

        // POST: Admin/QakhDescriptions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AboutTour")] QakhDescriptions qakhDescriptions)
        {
            if (id != qakhDescriptions.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(qakhDescriptions);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QakhDescriptionsExists(qakhDescriptions.Id))
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
            return View(qakhDescriptions);
        }

        // GET: Admin/QakhDescriptions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qakhDescriptions = await _context.QakhDescriptions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (qakhDescriptions == null)
            {
                return NotFound();
            }

            return View(qakhDescriptions);
        }

        // POST: Admin/QakhDescriptions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var qakhDescriptions = await _context.QakhDescriptions.FindAsync(id);
            _context.QakhDescriptions.Remove(qakhDescriptions);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QakhDescriptionsExists(int id)
        {
            return _context.QakhDescriptions.Any(e => e.Id == id);
        }
    }
}
