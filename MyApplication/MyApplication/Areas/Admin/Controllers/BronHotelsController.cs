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
    public class BronHotelsController : Controller
    {
        private readonly ToursDbContext _context;

        public BronHotelsController(ToursDbContext context)
        {
            _context = context;
        }

        // GET: Admin/BronHotels
        public async Task<IActionResult> Index()
        {
            return View(await _context.BronHotels.ToListAsync());
        }

        // GET: Admin/BronHotels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bronHotel = await _context.BronHotels
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bronHotel == null)
            {
                return NotFound();
            }

            return View(bronHotel);
        }

        // GET: Admin/BronHotels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/BronHotels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Price,Description,TypeOf,Value")] BronHotel bronHotel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bronHotel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bronHotel);
        }

        // GET: Admin/BronHotels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bronHotel = await _context.BronHotels.FindAsync(id);
            if (bronHotel == null)
            {
                return NotFound();
            }
            return View(bronHotel);
        }

        // POST: Admin/BronHotels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Price,Description,TypeOf,Value")] BronHotel bronHotel)
        {
            if (id != bronHotel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bronHotel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BronHotelExists(bronHotel.Id))
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
            return View(bronHotel);
        }

        // GET: Admin/BronHotels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bronHotel = await _context.BronHotels
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bronHotel == null)
            {
                return NotFound();
            }

            return View(bronHotel);
        }

        // POST: Admin/BronHotels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bronHotel = await _context.BronHotels.FindAsync(id);
            _context.BronHotels.Remove(bronHotel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BronHotelExists(int id)
        {
            return _context.BronHotels.Any(e => e.Id == id);
        }
    }
}
