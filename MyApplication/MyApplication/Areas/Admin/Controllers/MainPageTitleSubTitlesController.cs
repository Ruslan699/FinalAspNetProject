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
    public class MainPageTitleSubTitlesController : Controller
    {
        private readonly ToursDbContext _context;

        public MainPageTitleSubTitlesController(ToursDbContext context)
        {
            _context = context;
        }

        // GET: Admin/MainPageTitleSubTitles
        public async Task<IActionResult> Index()
        {
            return View(await _context.MainPageTitles.ToListAsync());
        }

        // GET: Admin/MainPageTitleSubTitles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mainPageTitleSubTitle = await _context.MainPageTitles
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mainPageTitleSubTitle == null)
            {
                return NotFound();
            }

            return View(mainPageTitleSubTitle);
        }

        // GET: Admin/MainPageTitleSubTitles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/MainPageTitleSubTitles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstSlide,FirstSlideText,SecondSlide,SecondSlideText,ThirdSlide,ThirdSlideText,FourthSlide,FourthSlideText,Title")] MainPageTitleSubTitle mainPageTitleSubTitle)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mainPageTitleSubTitle);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mainPageTitleSubTitle);
        }

        // GET: Admin/MainPageTitleSubTitles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mainPageTitleSubTitle = await _context.MainPageTitles.FindAsync(id);
            if (mainPageTitleSubTitle == null)
            {
                return NotFound();
            }
            return View(mainPageTitleSubTitle);
        }

        // POST: Admin/MainPageTitleSubTitles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstSlide,FirstSlideText,SecondSlide,SecondSlideText,ThirdSlide,ThirdSlideText,FourthSlide,FourthSlideText,Title")] MainPageTitleSubTitle mainPageTitleSubTitle)
        {
            if (id != mainPageTitleSubTitle.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mainPageTitleSubTitle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MainPageTitleSubTitleExists(mainPageTitleSubTitle.Id))
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
            return View(mainPageTitleSubTitle);
        }

        // GET: Admin/MainPageTitleSubTitles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mainPageTitleSubTitle = await _context.MainPageTitles
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mainPageTitleSubTitle == null)
            {
                return NotFound();
            }

            return View(mainPageTitleSubTitle);
        }

        // POST: Admin/MainPageTitleSubTitles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mainPageTitleSubTitle = await _context.MainPageTitles.FindAsync(id);
            _context.MainPageTitles.Remove(mainPageTitleSubTitle);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MainPageTitleSubTitleExists(int id)
        {
            return _context.MainPageTitles.Any(e => e.Id == id);
        }
    }
}
