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
    public class QakhPagesController : Controller
    {
        private readonly ToursDbContext _context;

        private readonly IHostingEnvironment hostingEnvironment;

        public QakhPagesController(ToursDbContext context, IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
            _context = context;
        }

        // GET: Admin/QakhPages
        public async Task<IActionResult> Index()
        {
            return View(await _context.QakhPages.ToListAsync());
        }

        // GET: Admin/QakhPages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qakhPage = await _context.QakhPages
                .FirstOrDefaultAsync(m => m.Id == id);
            if (qakhPage == null)
            {
                return NotFound();
            }

            return View(qakhPage);
        }

        // GET: Admin/QakhPages/Create
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


        // POST: Admin/QakhPages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SecondAdditional,Id,ImagePath,ImageText,Title,SubTitle,Duration,Code,Price,AboutTourText,AboutTourNumber,TourImage,TourName,TourInformation,TourVideo,TourCheckIn,TourText,TourTime,TourAdditional,Number,SecondNumber,Email,SiteAddress,Address")] QakhPage qakhPage, IFormFile TourImage)
        {
            CustomDateTimeFile customDateTimeFile = new CustomDateTimeFile();
            string fileName = customDateTimeFile.GetFileName(TourImage.FileName);

            if (ModelState.IsValid)
            {
                qakhPage.TourImage = fileName;
                if (_IsAcceptedFormat(TourImage.ContentType))
                {

                    string path = Path.Combine(hostingEnvironment.WebRootPath, "images", fileName);
                    byte[] data = new byte[TourImage.Length];

                    using (FileStream fileStream = new FileStream(path, FileMode.Create))
                    {
                        await TourImage.CopyToAsync(fileStream);
                    }
                }
                await _context.AddAsync(qakhPage);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(qakhPage);
        }

        // GET: Admin/QakhPages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qakhPage = await _context.QakhPages.FindAsync(id);
            if (qakhPage == null)
            {
                return NotFound();
            }
            return View(qakhPage);
        }

        // POST: Admin/QakhPages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SecondAdditional,Id,ImagePath,ImageText,Title,SubTitle,Duration,Code,Price,AboutTourText,AboutTourNumber,TourImage,TourName,TourInformation,TourVideo,TourCheckIn,TourText,TourTime,TourAdditional,Number,SecondNumber,Email,SiteAddress,Address")] QakhPage qakhPage)
        {
            if (id != qakhPage.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(qakhPage);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QakhPageExists(qakhPage.Id))
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
            return View(qakhPage);
        }

        // GET: Admin/QakhPages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qakhPage = await _context.QakhPages
                .FirstOrDefaultAsync(m => m.Id == id);
            if (qakhPage == null)
            {
                return NotFound();
            }

            return View(qakhPage);
        }

        // POST: Admin/QakhPages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var qakhPage = await _context.QakhPages.FindAsync(id);
            _context.QakhPages.Remove(qakhPage);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QakhPageExists(int id)
        {
            return _context.QakhPages.Any(e => e.Id == id);
        }
    }
}
