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
    public class BronBilgehsController : Controller
    {
        private readonly ToursDbContext _context;
        private readonly IHostingEnvironment hostingEnvironment;

        public BronBilgehsController(ToursDbContext context, IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
            _context = context;
        }

        // GET: Admin/BronBilgehs
        public async Task<IActionResult> Index()
        {
            return View(await _context.BronBilgehs.ToListAsync());
        }

        // GET: Admin/BronBilgehs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bronBilgeh = await _context.BronBilgehs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bronBilgeh == null)
            {
                return NotFound();
            }

            return View(bronBilgeh);
        }

        // GET: Admin/BronBilgehs/Create
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

        // POST: Admin/BronBilgehs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ImagePath,ImageTitle,AboutTourText,AboutTourNumber")] BronBilgeh bronBilgeh, IFormFile ImagePath)
        {
            CustomDateTimeFile customDateTimeFile = new CustomDateTimeFile();
            string fileName = customDateTimeFile.GetFileName(ImagePath.FileName);

            if (ModelState.IsValid)
            {
                bronBilgeh.ImagePath = fileName;
                if (_IsAcceptedFormat(ImagePath.ContentType))
                {

                    string path = Path.Combine(hostingEnvironment.WebRootPath, "images", fileName);
                    byte[] data = new byte[ImagePath.Length];

                    using (FileStream fileStream = new FileStream(path, FileMode.Create))
                    {
                        await ImagePath.CopyToAsync(fileStream);
                    }
                }
                await _context.AddAsync(bronBilgeh);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bronBilgeh);
        }

        // GET: Admin/BronBilgehs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bronBilgeh = await _context.BronBilgehs.FindAsync(id);
            if (bronBilgeh == null)
            {
                return NotFound();
            }
            return View(bronBilgeh);
        }

        // POST: Admin/BronBilgehs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ImagePath,ImageTitle,AboutTourText,AboutTourNumber")] BronBilgeh bronBilgeh)
        {
            if (id != bronBilgeh.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bronBilgeh);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BronBilgehExists(bronBilgeh.Id))
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
            return View(bronBilgeh);
        }

        // GET: Admin/BronBilgehs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bronBilgeh = await _context.BronBilgehs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bronBilgeh == null)
            {
                return NotFound();
            }

            return View(bronBilgeh);
        }

        // POST: Admin/BronBilgehs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bronBilgeh = await _context.BronBilgehs.FindAsync(id);
            _context.BronBilgehs.Remove(bronBilgeh);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BronBilgehExists(int id)
        {
            return _context.BronBilgehs.Any(e => e.Id == id);
        }
    }
}
