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
    public class CompliancesController : Controller
    {
        private readonly ToursDbContext _context;
        private readonly IHostingEnvironment hostingEnvironment;

        public CompliancesController(ToursDbContext context, IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
            _context = context;
        }

        // GET: Admin/Compliances
        public async Task<IActionResult> Index()
        {
            var toursDbContext = _context.Compliances.Include(c => c.About);
            return View(await toursDbContext.ToListAsync());
        }

        // GET: Admin/Compliances/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compliance = await _context.Compliances
                .Include(c => c.About)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (compliance == null)
            {
                return NotFound();
            }

            return View(compliance);
        }

        // GET: Admin/Compliances/Create
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

        // POST: Admin/Compliances/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ImageTitle,Text,SubText,AboutId,Id,ImagePath,Title,SubTitle")] Compliance compliance, IFormFile ImagePath)
        {
            CustomDateTimeFile customDateTimeFile = new CustomDateTimeFile();
            string fileName = customDateTimeFile.GetFileName(ImagePath.FileName);

            if (ModelState.IsValid)
            {
                compliance.ImagePath = fileName;
                if (_IsAcceptedFormat(ImagePath.ContentType))
                {

                    string path = Path.Combine(hostingEnvironment.WebRootPath, "images", fileName);
                    byte[] data = new byte[ImagePath.Length];

                    using (FileStream fileStream = new FileStream(path, FileMode.Create))
                    {
                        await ImagePath.CopyToAsync(fileStream);
                    }
                }
               await _context.AddAsync(compliance);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AboutId"] = new SelectList(_context.Abouts, "Id", "Id", compliance.AboutId);
            return View(compliance);
        }

        // GET: Admin/Compliances/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compliance = await _context.Compliances.FindAsync(id);
            if (compliance == null)
            {
                return NotFound();
            }
            ViewData["AboutId"] = new SelectList(_context.Abouts, "Id", "Id", compliance.AboutId);
            return View(compliance);
        }

        // POST: Admin/Compliances/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ImageTitle,Text,SubText,AboutId,Id,ImagePath,Title,SubTitle")] Compliance compliance)
        {
            if (id != compliance.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(compliance);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ComplianceExists(compliance.Id))
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
            ViewData["AboutId"] = new SelectList(_context.Abouts, "Id", "Id", compliance.AboutId);
            return View(compliance);
        }

        // GET: Admin/Compliances/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compliance = await _context.Compliances
                .Include(c => c.About)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (compliance == null)
            {
                return NotFound();
            }

            return View(compliance);
        }

        // POST: Admin/Compliances/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var compliance = await _context.Compliances.FindAsync(id);
            _context.Compliances.Remove(compliance);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ComplianceExists(int id)
        {
            return _context.Compliances.Any(e => e.Id == id);
        }
    }
}
