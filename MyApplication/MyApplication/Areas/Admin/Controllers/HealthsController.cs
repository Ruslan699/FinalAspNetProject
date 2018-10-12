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
    public class HealthsController : Controller
    {
        private readonly ToursDbContext _context;

        private readonly IHostingEnvironment hostingEnvironment;

        public HealthsController(ToursDbContext context, IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
            _context = context;
        }

        // GET: Admin/Healths
        public async Task<IActionResult> Index()
        {
            var toursDbContext = _context.Healths.Include(h => h.Service).Include(h => h.Tour);
            return View(await toursDbContext.ToListAsync());
        }

        // GET: Admin/Healths/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var health = await _context.Healths
                .Include(h => h.Service)
                .Include(h => h.Tour)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (health == null)
            {
                return NotFound();
            }

            return View(health);
        }

        // GET: Admin/Healths/Create
        public IActionResult Create()
        {
            ViewData["ServiceId"] = new SelectList(_context.Services, "Id", "Id");
            ViewData["TourId"] = new SelectList(_context.Tours, "Id", "ImagePath");
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


        // POST: Admin/Healths/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TourImage,TourIcon,TourName,TourTitle,TourTime,TourAction,Duration,ServiceId,TourId")] Health health, IFormFile TourImage)
        {
            CustomDateTimeFile customDateTimeFile = new CustomDateTimeFile();
            string fileName = customDateTimeFile.GetFileName(TourImage.FileName);

            if (ModelState.IsValid)
            {
                health.TourImage = fileName;
                if (_IsAcceptedFormat(TourImage.ContentType))
                {

                    string path = Path.Combine(hostingEnvironment.WebRootPath, "images", fileName);
                    byte[] data = new byte[TourImage.Length];

                    using (FileStream fileStream = new FileStream(path, FileMode.Create))
                    {
                        await TourImage.CopyToAsync(fileStream);
                    }
                }
                await _context.AddAsync(health);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ServiceId"] = new SelectList(_context.Services, "Id", "Id", health.ServiceId);
            ViewData["TourId"] = new SelectList(_context.Tours, "Id", "ImagePath", health.TourId);
            return View(health);
        }

        // GET: Admin/Healths/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var health = await _context.Healths.FindAsync(id);
            if (health == null)
            {
                return NotFound();
            }
            ViewData["ServiceId"] = new SelectList(_context.Services, "Id", "Id", health.ServiceId);
            ViewData["TourId"] = new SelectList(_context.Tours, "Id", "ImagePath", health.TourId);
            return View(health);
        }

        // POST: Admin/Healths/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TourImage,TourIcon,TourName,TourTitle,TourTime,TourAction,Duration,ServiceId,TourId")] Health health)
        {
            if (id != health.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(health);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HealthExists(health.Id))
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
            ViewData["ServiceId"] = new SelectList(_context.Services, "Id", "Id", health.ServiceId);
            ViewData["TourId"] = new SelectList(_context.Tours, "Id", "ImagePath", health.TourId);
            return View(health);
        }

        // GET: Admin/Healths/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var health = await _context.Healths
                .Include(h => h.Service)
                .Include(h => h.Tour)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (health == null)
            {
                return NotFound();
            }

            return View(health);
        }

        // POST: Admin/Healths/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var health = await _context.Healths.FindAsync(id);
            _context.Healths.Remove(health);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HealthExists(int id)
        {
            return _context.Healths.Any(e => e.Id == id);
        }
    }
}
