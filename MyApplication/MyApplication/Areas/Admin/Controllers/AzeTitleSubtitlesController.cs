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
    public class AzeTitleSubtitlesController : Controller
    {
        private readonly ToursDbContext _context;

        public AzeTitleSubtitlesController(ToursDbContext context)
        {
            _context = context;
        }

        // GET: Admin/AzeTitleSubtitles
        public async Task<IActionResult> Index()
        {
            return View(await _context.AzeTitleSubTitles.ToListAsync());
        }

        // GET: Admin/AzeTitleSubtitles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var azeTitleSubtitle = await _context.AzeTitleSubTitles
                .FirstOrDefaultAsync(m => m.Id == id);
            if (azeTitleSubtitle == null)
            {
                return NotFound();
            }

            return View(azeTitleSubtitle);
        }

        // GET: Admin/AzeTitleSubtitles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/AzeTitleSubtitles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstSlide,FirstSlideText,SecondSlide,SecondSlideText,ThirdSlide,ThirdSlideText,FourthSlide,FourthSlideText,Title,SubTitle")] AzeTitleSubtitle azeTitleSubtitle)
        {
            if (ModelState.IsValid)
            {
                _context.Add(azeTitleSubtitle);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(azeTitleSubtitle);
        }

        // GET: Admin/AzeTitleSubtitles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var azeTitleSubtitle = await _context.AzeTitleSubTitles.FindAsync(id);
            if (azeTitleSubtitle == null)
            {
                return NotFound();
            }
            return View(azeTitleSubtitle);
        }

        // POST: Admin/AzeTitleSubtitles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstSlide,FirstSlideText,SecondSlide,SecondSlideText,ThirdSlide,ThirdSlideText,FourthSlide,FourthSlideText,Title,SubTitle")] AzeTitleSubtitle azeTitleSubtitle)
        {
            if (id != azeTitleSubtitle.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(azeTitleSubtitle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AzeTitleSubtitleExists(azeTitleSubtitle.Id))
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
            return View(azeTitleSubtitle);
        }

        // GET: Admin/AzeTitleSubtitles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var azeTitleSubtitle = await _context.AzeTitleSubTitles
                .FirstOrDefaultAsync(m => m.Id == id);
            if (azeTitleSubtitle == null)
            {
                return NotFound();
            }

            return View(azeTitleSubtitle);
        }

        // POST: Admin/AzeTitleSubtitles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var azeTitleSubtitle = await _context.AzeTitleSubTitles.FindAsync(id);
            _context.AzeTitleSubTitles.Remove(azeTitleSubtitle);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AzeTitleSubtitleExists(int id)
        {
            return _context.AzeTitleSubTitles.Any(e => e.Id == id);
        }
    }
}
