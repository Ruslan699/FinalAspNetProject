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
    public class TransportDescriptionsController : Controller
    {
        private readonly ToursDbContext _context;

        public TransportDescriptionsController(ToursDbContext context)
        {
            _context = context;
        }

        // GET: Admin/TransportDescriptions
        public async Task<IActionResult> Index()
        {
            return View(await _context.TransportDescriptions.ToListAsync());
        }

        // GET: Admin/TransportDescriptions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transportDescription = await _context.TransportDescriptions
                .FirstOrDefaultAsync(m => m.id == id);
            if (transportDescription == null)
            {
                return NotFound();
            }

            return View(transportDescription);
        }

        // GET: Admin/TransportDescriptions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/TransportDescriptions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,AboutTransport")] TransportDescription transportDescription)
        {
            if (ModelState.IsValid)
            {
                _context.Add(transportDescription);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(transportDescription);
        }

        // GET: Admin/TransportDescriptions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transportDescription = await _context.TransportDescriptions.FindAsync(id);
            if (transportDescription == null)
            {
                return NotFound();
            }
            return View(transportDescription);
        }

        // POST: Admin/TransportDescriptions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,AboutTransport")] TransportDescription transportDescription)
        {
            if (id != transportDescription.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(transportDescription);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransportDescriptionExists(transportDescription.id))
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
            return View(transportDescription);
        }

        // GET: Admin/TransportDescriptions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transportDescription = await _context.TransportDescriptions
                .FirstOrDefaultAsync(m => m.id == id);
            if (transportDescription == null)
            {
                return NotFound();
            }

            return View(transportDescription);
        }

        // POST: Admin/TransportDescriptions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var transportDescription = await _context.TransportDescriptions.FindAsync(id);
            _context.TransportDescriptions.Remove(transportDescription);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TransportDescriptionExists(int id)
        {
            return _context.TransportDescriptions.Any(e => e.id == id);
        }
    }
}
