using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting.Internal;
using MyApplication.Infrastructure;
using MyApplication.Models;

namespace MyApplication.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AzerbaijansController : Controller
    {
        private readonly ToursDbContext _context;

        private readonly IHostingEnvironment hostingEnvironment;

        public AzerbaijansController(ToursDbContext context, IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
            _context = context;
        }

        // GET: Admin/Azerbaijans
        public async Task<IActionResult> Index()
        {
            return View(await _context.Azerbaijans.ToListAsync());
        }

        // GET: Admin/Azerbaijans/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var azerbaijan = await _context.Azerbaijans
                .FirstOrDefaultAsync(m => m.Id == id);
            if (azerbaijan == null)
            {
                return NotFound();
            }

            return View(azerbaijan);
        }

        // GET: Admin/Azerbaijans/Create
        public IActionResult Create()
        {
            return View();
        }

        private bool _IsAcceptedFormat(string contentType)
        {
            if(contentType == "image/gif" || contentType == "image/jpeg" || contentType=="image/png")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       


        // POST: Admin/Azerbaijans/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TourImage,TourIcon,TourName,TourTitle,TourTime,TourAction,TourDuration")] Azerbaijan azerbaijan, IFormFile TourImage)
        {
            CustomDateTimeFile customDateTimeFile = new CustomDateTimeFile();
            string fileName = customDateTimeFile.GetFileName(TourImage.FileName);

            if (ModelState.IsValid)
            {
                azerbaijan.TourImage = fileName;
                if(_IsAcceptedFormat(TourImage.ContentType))
                {

                    string path = Path.Combine(hostingEnvironment.WebRootPath, "images", fileName);
                    byte[] data = new byte[TourImage.Length];

                    using (FileStream fileStream = new FileStream(path, FileMode.Create))
                    {
                        await TourImage.CopyToAsync(fileStream);
                    } 
                }
                await _context.AddAsync(azerbaijan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(azerbaijan);
        }

        // GET: Admin/Azerbaijans/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var azerbaijan = await _context.Azerbaijans.FindAsync(id);
            if (azerbaijan == null)
            {
                return NotFound();
            }
            return View(azerbaijan);
        }

        // POST: Admin/Azerbaijans/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TourImage,TourIcon,TourName,TourTitle,TourTime,TourAction,TourDuration")] Azerbaijan azerbaijan)
        {
            if (id != azerbaijan.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(azerbaijan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AzerbaijanExists(azerbaijan.Id))
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
            return View(azerbaijan);
        }

        // GET: Admin/Azerbaijans/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var azerbaijan = await _context.Azerbaijans
                .FirstOrDefaultAsync(m => m.Id == id);
            if (azerbaijan == null)
            {
                return NotFound();
            }

            return View(azerbaijan);
        }

        // POST: Admin/Azerbaijans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var azerbaijan = await _context.Azerbaijans.FindAsync(id);
            _context.Azerbaijans.Remove(azerbaijan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AzerbaijanExists(int id)
        {
            return _context.Azerbaijans.Any(e => e.Id == id);
        }
    }
}
