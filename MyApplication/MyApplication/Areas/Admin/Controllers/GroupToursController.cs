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
    public class GroupToursController : Controller
    {
        private readonly ToursDbContext _context;

        public GroupToursController(ToursDbContext context)
        {
            _context = context;
        }

        // GET: Admin/GroupTours
        public async Task<IActionResult> Index()
        {
            var toursDbContext = _context.GroupTours.Include(g => g.Service);
            return View(await toursDbContext.ToListAsync());
        }

        // GET: Admin/GroupTours/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groupTour = await _context.GroupTours
                .Include(g => g.Service)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (groupTour == null)
            {
                return NotFound();
            }

            return View(groupTour);
        }

        // GET: Admin/GroupTours/Create
        public IActionResult Create()
        {
            ViewData["ServiceId"] = new SelectList(_context.Services, "Id", "Id");
            return View();
        }

        // POST: Admin/GroupTours/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ImagePath,ImageText,Title,SubTitle,Name,Price,Description,ServiceId,UserId")] GroupTour groupTour)
        {
            if (ModelState.IsValid)
            {
                _context.Add(groupTour);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ServiceId"] = new SelectList(_context.Services, "Id", "Id", groupTour.ServiceId);
            return View(groupTour);
        }

        // GET: Admin/GroupTours/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groupTour = await _context.GroupTours.FindAsync(id);
            if (groupTour == null)
            {
                return NotFound();
            }
            ViewData["ServiceId"] = new SelectList(_context.Services, "Id", "Id", groupTour.ServiceId);
            return View(groupTour);
        }

        // POST: Admin/GroupTours/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ImagePath,ImageText,Title,SubTitle,Name,Price,Description,ServiceId,UserId")] GroupTour groupTour)
        {
            if (id != groupTour.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(groupTour);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GroupTourExists(groupTour.Id))
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
            ViewData["ServiceId"] = new SelectList(_context.Services, "Id", "Id", groupTour.ServiceId);
            return View(groupTour);
        }

        // GET: Admin/GroupTours/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groupTour = await _context.GroupTours
                .Include(g => g.Service)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (groupTour == null)
            {
                return NotFound();
            }

            return View(groupTour);
        }

        // POST: Admin/GroupTours/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var groupTour = await _context.GroupTours.FindAsync(id);
            _context.GroupTours.Remove(groupTour);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GroupTourExists(int id)
        {
            return _context.GroupTours.Any(e => e.Id == id);
        }
    }
}
