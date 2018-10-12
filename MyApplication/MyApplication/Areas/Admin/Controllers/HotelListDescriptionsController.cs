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
    public class HotelListDescriptionsController : Controller
    {
        private readonly ToursDbContext _context;

        public HotelListDescriptionsController(ToursDbContext context)
        {
            _context = context;
        }

        // GET: Admin/HotelListDescriptions
        public async Task<IActionResult> Index()
        {
            return View(await _context.HotelListDescriptions.ToListAsync());
        }

        // GET: Admin/HotelListDescriptions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hotelListDescription = await _context.HotelListDescriptions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hotelListDescription == null)
            {
                return NotFound();
            }

            return View(hotelListDescription);
        }

        // GET: Admin/HotelListDescriptions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/HotelListDescriptions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,HotelLink,ListHotel")] HotelListDescription hotelListDescription)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hotelListDescription);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hotelListDescription);
        }

        // GET: Admin/HotelListDescriptions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hotelListDescription = await _context.HotelListDescriptions.FindAsync(id);
            if (hotelListDescription == null)
            {
                return NotFound();
            }
            return View(hotelListDescription);
        }

        // POST: Admin/HotelListDescriptions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,HotelLink,ListHotel")] HotelListDescription hotelListDescription)
        {
            if (id != hotelListDescription.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hotelListDescription);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HotelListDescriptionExists(hotelListDescription.Id))
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
            return View(hotelListDescription);
        }

        // GET: Admin/HotelListDescriptions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hotelListDescription = await _context.HotelListDescriptions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hotelListDescription == null)
            {
                return NotFound();
            }

            return View(hotelListDescription);
        }

        // POST: Admin/HotelListDescriptions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hotelListDescription = await _context.HotelListDescriptions.FindAsync(id);
            _context.HotelListDescriptions.Remove(hotelListDescription);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HotelListDescriptionExists(int id)
        {
            return _context.HotelListDescriptions.Any(e => e.Id == id);
        }
    }
}
