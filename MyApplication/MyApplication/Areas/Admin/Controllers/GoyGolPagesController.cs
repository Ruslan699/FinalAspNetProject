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
    public class GoyGolPagesController : Controller
    {
        private readonly ToursDbContext _context;

        private readonly IHostingEnvironment hostingEnvironment;

        public GoyGolPagesController(ToursDbContext context, IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
            _context = context;
        }

        // GET: Admin/GoyGolPages
        public async Task<IActionResult> Index()
        {
            return View(await _context.GoyGolPages.ToListAsync());
        }

        // GET: Admin/GoyGolPages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var goyGolPage = await _context.GoyGolPages
                .FirstOrDefaultAsync(m => m.Id == id);
            if (goyGolPage == null)
            {
                return NotFound();
            }

            return View(goyGolPage);
        }

        // GET: Admin/GoyGolPages/Create
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


        // POST: Admin/GoyGolPages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ImagePath,ImageText,Title,SubTitle,Duration,Code,Price,AboutTourText,AboutTourNumber,TourImage,TourName,TourInformation,TourVideo,TourCheckIn,TourText,TourTime,TourAdditional,Number,SecondNumber,Email,SiteAddress,Address")] GoyGolPage goyGolPage, IFormFile TourImage)
        {
            CustomDateTimeFile customDateTimeFile = new CustomDateTimeFile();
            string fileName = customDateTimeFile.GetFileName(TourImage.FileName);

            if (ModelState.IsValid)
            {
                goyGolPage.TourImage = fileName;
                if (_IsAcceptedFormat(TourImage.ContentType))
                {

                    string path = Path.Combine(hostingEnvironment.WebRootPath, "images", fileName);
                    byte[] data = new byte[TourImage.Length];

                    using (FileStream fileStream = new FileStream(path, FileMode.Create))
                    {
                        await TourImage.CopyToAsync(fileStream);
                    }
                }
                await _context.AddAsync(goyGolPage);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(goyGolPage);
        }

        // GET: Admin/GoyGolPages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var goyGolPage = await _context.GoyGolPages.FindAsync(id);
            if (goyGolPage == null)
            {
                return NotFound();
            }
            return View(goyGolPage);
        }

        // POST: Admin/GoyGolPages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ImagePath,ImageText,Title,SubTitle,Duration,Code,Price,AboutTourText,AboutTourNumber,TourImage,TourName,TourInformation,TourVideo,TourCheckIn,TourText,TourTime,TourAdditional,Number,SecondNumber,Email,SiteAddress,Address")] GoyGolPage goyGolPage)
        {
            if (id != goyGolPage.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(goyGolPage);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GoyGolPageExists(goyGolPage.Id))
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
            return View(goyGolPage);
        }

        // GET: Admin/GoyGolPages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var goyGolPage = await _context.GoyGolPages
                .FirstOrDefaultAsync(m => m.Id == id);
            if (goyGolPage == null)
            {
                return NotFound();
            }

            return View(goyGolPage);
        }

        // POST: Admin/GoyGolPages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var goyGolPage = await _context.GoyGolPages.FindAsync(id);
            _context.GoyGolPages.Remove(goyGolPage);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GoyGolPageExists(int id)
        {
            return _context.GoyGolPages.Any(e => e.Id == id);
        }
    }
}
