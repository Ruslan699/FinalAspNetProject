using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyApplication.Infrastructure;
using MyApplication.Models;

namespace MyApplication.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MainPagesController : Controller
    {
        private readonly ToursDbContext _context;

        private readonly IHostingEnvironment hostingEnvironment;

        public MainPagesController(ToursDbContext context, IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
            _context = context;
        }

        // GET: Admin/MainPages
        public async Task<IActionResult> Index()
        {
            return View(await _context.MainPages.ToListAsync());
        }

        // GET: Admin/MainPages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mainPage = await _context.MainPages
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mainPage == null)
            {
                return NotFound();
            }

            return View(mainPage);
        }

        // GET: Admin/MainPages/Create
        public IActionResult Create()
        {
            return View();
        }

        private bool _IsAcceptedFormat(string contentType)
        {
            if (contentType == "image/gif" || contentType == "image/jpeg" || contentType == "image/png")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // POST: Admin/MainPages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TourImage,TourName,TourPrice,TourTime,TourAction,TourDuration")] MainPage mainPage, IFormFile TourImage)
        {
            CustomDateTimeFile customDateTimeFile = new CustomDateTimeFile();
            string fileName = customDateTimeFile.GetFileName(TourImage.FileName);

            if (ModelState.IsValid)
            {
                mainPage.TourImage = fileName;
                if (_IsAcceptedFormat(TourImage.ContentType))
                {

                    string path = Path.Combine(hostingEnvironment.WebRootPath, "images", fileName);
                    byte[] data = new byte[TourImage.Length];

                    using (FileStream fileStream = new FileStream(path, FileMode.Create))
                    {
                        await TourImage.CopyToAsync(fileStream);
                    }
                }
               await _context.AddAsync(mainPage);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mainPage);
        }

        // GET: Admin/MainPages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mainPage = await _context.MainPages.FindAsync(id);
            if (mainPage == null)
            {
                return NotFound();
            }
            return View(mainPage);
        }

        // POST: Admin/MainPages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TourImage,TourName,TourPrice,TourTime,TourAction,TourDuration")] MainPage mainPage)
        {
            if (id != mainPage.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mainPage);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MainPageExists(mainPage.Id))
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
            return View(mainPage);
        }

        // GET: Admin/MainPages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mainPage = await _context.MainPages
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mainPage == null)
            {
                return NotFound();
            }

            return View(mainPage);
        }

        // POST: Admin/MainPages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mainPage = await _context.MainPages.FindAsync(id);
            _context.MainPages.Remove(mainPage);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MainPageExists(int id)
        {
            return _context.MainPages.Any(e => e.Id == id);
        }
    }
}
