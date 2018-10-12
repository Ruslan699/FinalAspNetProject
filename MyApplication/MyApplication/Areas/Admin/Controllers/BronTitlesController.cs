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
    public class BronTitlesController : Controller
    {
        private readonly ToursDbContext _context;
        private readonly IHostingEnvironment hostingEnvironment;

        public BronTitlesController(ToursDbContext context, IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
            _context = context;
        }

        // GET: Admin/BronTitles
        public async Task<IActionResult> Index()
        {
            return View(await _context.BronTitles.ToListAsync());
        }

        // GET: Admin/BronTitles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bronTitle = await _context.BronTitles
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bronTitle == null)
            {
                return NotFound();
            }

            return View(bronTitle);
        }

        // GET: Admin/BronTitles/Create
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

        // POST: Admin/BronTitles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TourIncludedText,TourIncludedIcon")] BronTitle bronTitle, IFormFile TourIncludedIcon)
        {
            CustomDateTimeFile customDateTimeFile = new CustomDateTimeFile();
            string fileName = customDateTimeFile.GetFileName(TourIncludedIcon.FileName);

            if (ModelState.IsValid)
            {
                bronTitle.TourIncludedIcon = fileName;
                if (_IsAcceptedFormat(TourIncludedIcon.ContentType))
                {

                    string path = Path.Combine(hostingEnvironment.WebRootPath, "images", fileName);
                    byte[] data = new byte[TourIncludedIcon.Length];

                    using (FileStream fileStream = new FileStream(path, FileMode.Create))
                    {
                        await TourIncludedIcon.CopyToAsync(fileStream);
                    }
                }
                 await _context.AddAsync(bronTitle);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bronTitle);
        }

        // GET: Admin/BronTitles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bronTitle = await _context.BronTitles.FindAsync(id);
            if (bronTitle == null)
            {
                return NotFound();
            }
            return View(bronTitle);
        }

        // POST: Admin/BronTitles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TourIncludedText,TourIncludedIcon")] BronTitle bronTitle)
        {
            if (id != bronTitle.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bronTitle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BronTitleExists(bronTitle.Id))
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
            return View(bronTitle);
        }

        // GET: Admin/BronTitles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bronTitle = await _context.BronTitles
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bronTitle == null)
            {
                return NotFound();
            }

            return View(bronTitle);
        }

        // POST: Admin/BronTitles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bronTitle = await _context.BronTitles.FindAsync(id);
            _context.BronTitles.Remove(bronTitle);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BronTitleExists(int id)
        {
            return _context.BronTitles.Any(e => e.Id == id);
        }
    }
}
