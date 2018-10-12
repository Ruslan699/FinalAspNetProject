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
    public class BakuJarasController : Controller
    {
        private readonly ToursDbContext _context;
        private readonly IHostingEnvironment hostingEnvironment;

        public BakuJarasController(ToursDbContext context, IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
            _context = context;
        }

        // GET: Admin/BakuJaras
        public async Task<IActionResult> Index()
        {
            var toursDbContext = _context.BakuJaras.Include(b => b.Event);
            return View(await toursDbContext.ToListAsync());
        }

        // GET: Admin/BakuJaras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bakuJara = await _context.BakuJaras
                .Include(b => b.Event)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bakuJara == null)
            {
                return NotFound();
            }

            return View(bakuJara);
        }

        // GET: Admin/BakuJaras/Create
        public IActionResult Create()
        {
            ViewData["EventId"] = new SelectList(_context.Events, "Id", "Id");
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

        // POST: Admin/BakuJaras/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ImagePath,ImageText,Title,SubTitle,Duration,Code,Price,AboutTourText,AboutTourNumber,TourImage,TourName,TourInformation,TourVideo,TourCheckIn,TourText,TourTime,TourAdditional,TourSecondAdditional,Number,SecondNumber,Email,SiteAddress,Address,EventId")] BakuJara bakuJara, IFormFile ImagePath)
        {
            CustomDateTimeFile customDateTimeFile = new CustomDateTimeFile();
            string fileName = customDateTimeFile.GetFileName(ImagePath.FileName);

            if (ModelState.IsValid)
            {
                bakuJara.ImagePath = fileName;
                if (_IsAcceptedFormat(ImagePath.ContentType))
                {

                    string path = Path.Combine(hostingEnvironment.WebRootPath, "images", fileName);
                    byte[] data = new byte[ImagePath.Length];

                    using (FileStream fileStream = new FileStream(path, FileMode.Create))
                    {
                        await ImagePath.CopyToAsync(fileStream);
                    }
                }
                await _context.AddAsync(bakuJara);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EventId"] = new SelectList(_context.Events, "Id", "Id", bakuJara.EventId);
            return View(bakuJara);
        }

        // GET: Admin/BakuJaras/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bakuJara = await _context.BakuJaras.FindAsync(id);
            if (bakuJara == null)
            {
                return NotFound();
            }
            ViewData["EventId"] = new SelectList(_context.Events, "Id", "Id", bakuJara.EventId);
            return View(bakuJara);
        }

        // POST: Admin/BakuJaras/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ImagePath,ImageText,Title,SubTitle,Duration,Code,Price,AboutTourText,AboutTourNumber,TourImage,TourName,TourInformation,TourVideo,TourCheckIn,TourText,TourTime,TourAdditional,TourSecondAdditional,Number,SecondNumber,Email,SiteAddress,Address,EventId")] BakuJara bakuJara)
        {
            if (id != bakuJara.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bakuJara);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BakuJaraExists(bakuJara.Id))
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
            ViewData["EventId"] = new SelectList(_context.Events, "Id", "Id", bakuJara.EventId);
            return View(bakuJara);
        }

        // GET: Admin/BakuJaras/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bakuJara = await _context.BakuJaras
                .Include(b => b.Event)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bakuJara == null)
            {
                return NotFound();
            }

            return View(bakuJara);
        }

        // POST: Admin/BakuJaras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bakuJara = await _context.BakuJaras.FindAsync(id);
            _context.BakuJaras.Remove(bakuJara);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BakuJaraExists(int id)
        {
            return _context.BakuJaras.Any(e => e.Id == id);
        }
    }
}
