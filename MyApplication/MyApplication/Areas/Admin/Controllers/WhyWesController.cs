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
    public class WhyWesController : Controller
    {
        private readonly ToursDbContext _context;

        private readonly IHostingEnvironment hostingEnvironment;

        public WhyWesController(ToursDbContext context, IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
            _context = context;
        }

        // GET: Admin/WhyWes
        public async Task<IActionResult> Index()
        {
            var toursDbContext = _context.WhyWe.Include(w => w.About);
            return View(await toursDbContext.ToListAsync());
        }

        // GET: Admin/WhyWes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var whyWe = await _context.WhyWe
                .Include(w => w.About)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (whyWe == null)
            {
                return NotFound();
            }

            return View(whyWe);
        }

        // GET: Admin/WhyWes/Create
        public IActionResult Create()
        {
            ViewData["AboutId"] = new SelectList(_context.Abouts, "Id", "Id");
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

        // POST: Admin/WhyWes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ImageTitle,AboutId,Id,ImagePath,Title,SubTitle")] WhyWe whyWe, IFormFile ImagePath)
        {
            CustomDateTimeFile customDateTimeFile = new CustomDateTimeFile();
            string fileName = customDateTimeFile.GetFileName(ImagePath.FileName);

            if (ModelState.IsValid)
            {
                whyWe.ImagePath = fileName;
                if (_IsAcceptedFormat(ImagePath.ContentType))
                {

                    string path = Path.Combine(hostingEnvironment.WebRootPath, "images", fileName);
                    byte[] data = new byte[ImagePath.Length];

                    using (FileStream fileStream = new FileStream(path, FileMode.Create))
                    {
                        await ImagePath.CopyToAsync(fileStream);
                    }
                }
                await _context.AddAsync(whyWe);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AboutId"] = new SelectList(_context.Abouts, "Id", "Id", whyWe.AboutId);
            return View(whyWe);
        }

        // GET: Admin/WhyWes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var whyWe = await _context.WhyWe.FindAsync(id);
            if (whyWe == null)
            {
                return NotFound();
            }
            ViewData["AboutId"] = new SelectList(_context.Abouts, "Id", "Id", whyWe.AboutId);
            return View(whyWe);
        }

        // POST: Admin/WhyWes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ImageTitle,AboutId,Id,ImagePath,Title,SubTitle")] WhyWe whyWe)
        {
            if (id != whyWe.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(whyWe);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WhyWeExists(whyWe.Id))
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
            ViewData["AboutId"] = new SelectList(_context.Abouts, "Id", "Id", whyWe.AboutId);
            return View(whyWe);
        }

        // GET: Admin/WhyWes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var whyWe = await _context.WhyWe
                .Include(w => w.About)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (whyWe == null)
            {
                return NotFound();
            }

            return View(whyWe);
        }

        // POST: Admin/WhyWes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var whyWe = await _context.WhyWe.FindAsync(id);
            _context.WhyWe.Remove(whyWe);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WhyWeExists(int id)
        {
            return _context.WhyWe.Any(e => e.Id == id);
        }
    }
}
