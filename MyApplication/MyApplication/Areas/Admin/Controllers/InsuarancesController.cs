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

namespace MyApplication.Areas.Admin
{
    [Area("Admin")]
    public class InsuarancesController : Controller
    {
        private readonly ToursDbContext _context;

        private readonly IHostingEnvironment hostingEnvironment;

        public InsuarancesController(ToursDbContext context, IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
            _context = context;
        }

        // GET: Admin/Insuarances
        public async Task<IActionResult> Index()
        {
            var toursDbContext = _context.Insuarances.Include(i => i.Service);
            return View(await toursDbContext.ToListAsync());
        }

        // GET: Admin/Insuarances/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuarance = await _context.Insuarances
                .Include(i => i.Service)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (insuarance == null)
            {
                return NotFound();
            }

            return View(insuarance);
        }

        // GET: Admin/Insuarances/Create
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

        // POST: Admin/Insuarances/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ImagePath,ImageTitle,Title,SubTitle,Text,SubText,Phone,OtherPhone,Email,SiteAddress,Address,ServiceId")] Insuarance insuarance, IFormFile ImagePath)
        {
            CustomDateTimeFile customDateTimeFile = new CustomDateTimeFile();
            string fileName = customDateTimeFile.GetFileName(ImagePath.FileName);

            if (ModelState.IsValid)
            {
                insuarance.ImagePath = fileName;
                if (_IsAcceptedFormat(ImagePath.ContentType))
                {

                    string path = Path.Combine(hostingEnvironment.WebRootPath, "images", fileName);
                    byte[] data = new byte[ImagePath.Length];

                    using (FileStream fileStream = new FileStream(path, FileMode.Create))
                    {
                        await ImagePath.CopyToAsync(fileStream);
                    }
                }
                await _context.AddAsync(insuarance);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ServiceId"] = new SelectList(_context.Services, "Id", "Id", insuarance.ServiceId);
            return View(insuarance);
        }

        // GET: Admin/Insuarances/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuarance = await _context.Insuarances.FindAsync(id);
            if (insuarance == null)
            {
                return NotFound();
            }
            ViewData["ServiceId"] = new SelectList(_context.Services, "Id", "Id", insuarance.ServiceId);
            return View(insuarance);
        }

        // POST: Admin/Insuarances/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ImagePath,ImageTitle,Title,SubTitle,Text,SubText,Phone,OtherPhone,Email,SiteAddress,Address,ServiceId")] Insuarance insuarance)
        {
            if (id != insuarance.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(insuarance);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InsuaranceExists(insuarance.Id))
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
            ViewData["ServiceId"] = new SelectList(_context.Services, "Id", "Id", insuarance.ServiceId);
            return View(insuarance);
        }

        // GET: Admin/Insuarances/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuarance = await _context.Insuarances
                .Include(i => i.Service)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (insuarance == null)
            {
                return NotFound();
            }

            return View(insuarance);
        }

        // POST: Admin/Insuarances/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var insuarance = await _context.Insuarances.FindAsync(id);
            _context.Insuarances.Remove(insuarance);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InsuaranceExists(int id)
        {
            return _context.Insuarances.Any(e => e.Id == id);
        }
    }
}
