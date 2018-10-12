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
    public class AdvicesController : Controller
    {
        private readonly ToursDbContext _context;
        private readonly IHostingEnvironment hostingEnvironment;

        public AdvicesController(ToursDbContext context, IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
            _context = context;
        }

        // GET: Admin/Advices
        public async Task<IActionResult> Index()
        {
            var toursDbContext = _context.Advices.Include(a => a.Service);
            return View(await toursDbContext.ToListAsync());
        }

        // GET: Admin/Advices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var advice = await _context.Advices
                .Include(a => a.Service)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (advice == null)
            {
                return NotFound();
            }

            return View(advice);
        }

        // GET: Admin/Advices/Create
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

        // POST: Admin/Advices/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Text,ImagePath,ImageTitle,Title,SubTitle,ServiceId")] Advice advice, IFormFile ImagePath)
        {
            CustomDateTimeFile customDateTimeFile = new CustomDateTimeFile();
            string fileName = customDateTimeFile.GetFileName(ImagePath.FileName);

            if (ModelState.IsValid)
            {
                advice.ImagePath = fileName;
                if (_IsAcceptedFormat(ImagePath.ContentType))
                {

                    string path = Path.Combine(hostingEnvironment.WebRootPath, "images", fileName);
                    byte[] data = new byte[ImagePath.Length];

                    using (FileStream fileStream = new FileStream(path, FileMode.Create))
                    {
                        await ImagePath.CopyToAsync(fileStream);
                    }
                }
                await _context.AddAsync(advice);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ServiceId"] = new SelectList(_context.Services, "Id", "Id", advice.ServiceId);
            return View(advice);
        }

        // GET: Admin/Advices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var advice = await _context.Advices.FindAsync(id);
            if (advice == null)
            {
                return NotFound();
            }
            ViewData["ServiceId"] = new SelectList(_context.Services, "Id", "Id", advice.ServiceId);
            return View(advice);
        }

        // POST: Admin/Advices/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Text,ImagePath,ImageTitle,Title,SubTitle,ServiceId")] Advice advice)
        {
            if (id != advice.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(advice);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdviceExists(advice.Id))
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
            ViewData["ServiceId"] = new SelectList(_context.Services, "Id", "Id", advice.ServiceId);
            return View(advice);
        }

        // GET: Admin/Advices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var advice = await _context.Advices
                .Include(a => a.Service)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (advice == null)
            {
                return NotFound();
            }

            return View(advice);
        }

        // POST: Admin/Advices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var advice = await _context.Advices.FindAsync(id);
            _context.Advices.Remove(advice);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdviceExists(int id)
        {
            return _context.Advices.Any(e => e.Id == id);
        }
    }
}
