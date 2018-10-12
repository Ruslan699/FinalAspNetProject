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
    public class CruizsController : Controller
    {
        private readonly ToursDbContext _context;
        private readonly IHostingEnvironment hostingEnvironment;

        public CruizsController(ToursDbContext context, IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
            _context = context;
        }

        // GET: Admin/Cruizs
        public async Task<IActionResult> Index()
        {
            var toursDbContext = _context.Cruizs.Include(c => c.Service);
            return View(await toursDbContext.ToListAsync());
        }

        // GET: Admin/Cruizs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cruiz = await _context.Cruizs
                .Include(c => c.Service)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cruiz == null)
            {
                return NotFound();
            }

            return View(cruiz);
        }

        // GET: Admin/Cruizs/Create
        public IActionResult Create()
        {
            ViewData["ServiceId"] = new SelectList(_context.Services, "Id", "Id");
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

        // POST: Admin/Cruizs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,ImagePath,ImageTitle,Title,SubTitle,Price,UserId,ServiceId")] Cruiz cruiz, IFormFile ImagePath)
        {
            CustomDateTimeFile customDateTimeFile = new CustomDateTimeFile();
            string fileName = customDateTimeFile.GetFileName(ImagePath.FileName);

            if (ModelState.IsValid)
            {
                cruiz.ImagePath = fileName;
                if (_IsAcceptedFormat(ImagePath.ContentType))
                {

                    string path = Path.Combine(hostingEnvironment.WebRootPath, "images", fileName);
                    byte[] data = new byte[ImagePath.Length];

                    using (FileStream fileStream = new FileStream(path, FileMode.Create))
                    {
                        await ImagePath.CopyToAsync(fileStream);
                    }
                }
                await _context.AddAsync(cruiz);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ServiceId"] = new SelectList(_context.Services, "Id", "Id", cruiz.ServiceId);
            return View(cruiz);
        }

        // GET: Admin/Cruizs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cruiz = await _context.Cruizs.FindAsync(id);
            if (cruiz == null)
            {
                return NotFound();
            }
            ViewData["ServiceId"] = new SelectList(_context.Services, "Id", "Id", cruiz.ServiceId);
            return View(cruiz);
        }

        // POST: Admin/Cruizs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,ImagePath,ImageTitle,Title,SubTitle,Price,UserId,ServiceId")] Cruiz cruiz)
        {
            if (id != cruiz.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cruiz);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CruizExists(cruiz.Id))
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
            ViewData["ServiceId"] = new SelectList(_context.Services, "Id", "Id", cruiz.ServiceId);
            return View(cruiz);
        }

        // GET: Admin/Cruizs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cruiz = await _context.Cruizs
                .Include(c => c.Service)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cruiz == null)
            {
                return NotFound();
            }

            return View(cruiz);
        }

        // POST: Admin/Cruizs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cruiz = await _context.Cruizs.FindAsync(id);
            _context.Cruizs.Remove(cruiz);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CruizExists(int id)
        {
            return _context.Cruizs.Any(e => e.Id == id);
        }
    }
}
