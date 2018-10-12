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
    public class IncomingsController : Controller
    {
        private readonly ToursDbContext _context;

        private readonly IHostingEnvironment hostingEnvironment;

        public IncomingsController(ToursDbContext context, IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
            _context = context;
        }

        // GET: Admin/Incomings
        public async Task<IActionResult> Index()
        {
            var toursDbContext = _context.Incoming.Include(i => i.Service).Include(i => i.Tour);
            return View(await toursDbContext.ToListAsync());
        }

        // GET: Admin/Incomings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var incoming = await _context.Incoming
                .Include(i => i.Service)
                .Include(i => i.Tour)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (incoming == null)
            {
                return NotFound();
            }

            return View(incoming);
        }

        // GET: Admin/Incomings/Create
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


        // POST: Admin/Incomings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TourImage,TourIcon,TourName,TourTitle,TourTime,TourAction,ServiceId,Duration,TourId")] Incoming incoming, IFormFile TourImage)
        {
            //CustomDateTimeFile customDateTimeFile = new CustomDateTimeFile();
            //string fileName = customDateTimeFile.GetFileName(TourImage.FileName);

            if (ModelState.IsValid)
            {
                //incoming.TourImage = fileName;
                //if (_IsAcceptedFormat(TourImage.ContentType))
                //{

                //    string path = Path.Combine(hostingEnvironment.WebRootPath, "images", fileName);
                //    byte[] data = new byte[TourImage.Length];

                //    using (FileStream fileStream = new FileStream(path, FileMode.Create))
                //    {
                //        await TourImage.CopyToAsync(fileStream);
                //    }
                //}
                await _context.AddAsync(incoming);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ServiceId"] = new SelectList(_context.Services, "Id", "Id", incoming.ServiceId);
            ViewData["TourId"] = new SelectList(_context.Tours, "Id", "ImagePath", incoming.TourId);
            return View(incoming);
        }

        // GET: Admin/Incomings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var incoming = await _context.Incoming.FindAsync(id);
            if (incoming == null)
            {
                return NotFound();
            }
            ViewData["ServiceId"] = new SelectList(_context.Services, "Id", "Id", incoming.ServiceId);
            ViewData["TourId"] = new SelectList(_context.Tours, "Id", "ImagePath", incoming.TourId);
            return View(incoming);
        }

        // POST: Admin/Incomings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TourImage,TourIcon,TourName,TourTitle,TourTime,TourAction,ServiceId,Duration,TourId")] Incoming incoming)
        {
            if (id != incoming.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(incoming);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IncomingExists(incoming.Id))
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
            ViewData["ServiceId"] = new SelectList(_context.Services, "Id", "Id", incoming.ServiceId);
            ViewData["TourId"] = new SelectList(_context.Tours, "Id", "ImagePath", incoming.TourId);
            return View(incoming);
        }

        // GET: Admin/Incomings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var incoming = await _context.Incoming
                .Include(i => i.Service)
                .Include(i => i.Tour)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (incoming == null)
            {
                return NotFound();
            }

            return View(incoming);
        }

        // POST: Admin/Incomings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var incoming = await _context.Incoming.FindAsync(id);
            _context.Incoming.Remove(incoming);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IncomingExists(int id)
        {
            return _context.Incoming.Any(e => e.Id == id);
        }
    }
}
