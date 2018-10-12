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
    public class NaftalanPagesController : Controller
    {
        private readonly ToursDbContext _context;

        private readonly IHostingEnvironment hostingEnvironment;

        public NaftalanPagesController(ToursDbContext context, IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
            _context = context;
        }

        // GET: Admin/NaftalanPages
        public async Task<IActionResult> Index()
        {
            return View(await _context.NaftalanPages.ToListAsync());
        }

        // GET: Admin/NaftalanPages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var naftalanPage = await _context.NaftalanPages
                .FirstOrDefaultAsync(m => m.Id == id);
            if (naftalanPage == null)
            {
                return NotFound();
            }

            return View(naftalanPage);
        }

        // GET: Admin/NaftalanPages/Create
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


        // POST: Admin/NaftalanPages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ImagePath,ImageText,Title,SubTitle,Duration,Code,Price,AboutTourText,AboutTourNumber,TourImage,TourName,TourInformation,TourVideo,TourCheckIn,TourText,TourTime,TourAdditional,TourAdditionalSecond,Number,SecondNumber,Email,SiteAddress,Address")] NaftalanPage naftalanPage, IFormFile TourImage)
        {
            CustomDateTimeFile customDateTimeFile = new CustomDateTimeFile();
            string fileName = customDateTimeFile.GetFileName(TourImage.FileName);

            if (ModelState.IsValid)
            {
                naftalanPage.TourImage = fileName;
                if (_IsAcceptedFormat(TourImage.ContentType))
                {

                    string path = Path.Combine(hostingEnvironment.WebRootPath, "images", fileName);
                    byte[] data = new byte[TourImage.Length];

                    using (FileStream fileStream = new FileStream(path, FileMode.Create))
                    {
                        await TourImage.CopyToAsync(fileStream);
                    }
                }
                await _context.AddAsync(naftalanPage);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(naftalanPage);
        }

        // GET: Admin/NaftalanPages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var naftalanPage = await _context.NaftalanPages.FindAsync(id);
            if (naftalanPage == null)
            {
                return NotFound();
            }
            return View(naftalanPage);
        }

        // POST: Admin/NaftalanPages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ImagePath,ImageText,Title,SubTitle,Duration,Code,Price,AboutTourText,AboutTourNumber,TourImage,TourName,TourInformation,TourVideo,TourCheckIn,TourText,TourTime,TourAdditional,TourAdditionalSecond,Number,SecondNumber,Email,SiteAddress,Address")] NaftalanPage naftalanPage)
        {
            if (id != naftalanPage.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(naftalanPage);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NaftalanPageExists(naftalanPage.Id))
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
            return View(naftalanPage);
        }

        // GET: Admin/NaftalanPages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var naftalanPage = await _context.NaftalanPages
                .FirstOrDefaultAsync(m => m.Id == id);
            if (naftalanPage == null)
            {
                return NotFound();
            }

            return View(naftalanPage);
        }

        // POST: Admin/NaftalanPages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var naftalanPage = await _context.NaftalanPages.FindAsync(id);
            _context.NaftalanPages.Remove(naftalanPage);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NaftalanPageExists(int id)
        {
            return _context.NaftalanPages.Any(e => e.Id == id);
        }
    }
}
