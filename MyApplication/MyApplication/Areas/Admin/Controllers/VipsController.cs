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
    public class VipsController : Controller
    {
        private readonly ToursDbContext _context;
        private readonly IHostingEnvironment hostingEnvironment;

        public VipsController(ToursDbContext context, IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
            _context = context;
        }

        // GET: Admin/Vips
        public async Task<IActionResult> Index()
        {
            var toursDbContext = _context.Vips.Include(v => v.Service);
            return View(await toursDbContext.ToListAsync());
        }

        // GET: Admin/Vips/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vip = await _context.Vips
                .Include(v => v.Service)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vip == null)
            {
                return NotFound();
            }

            return View(vip);
        }

        // GET: Admin/Vips/Create
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

        // POST: Admin/Vips/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ImagePath,ImageTitle,Title,SubTitle,Key,Value,Text,SubText,Phone,OtherPhone,Email,SiteAddress,Address,ServiceId")] Vip vip, IFormFile ImagePath)
        {
            CustomDateTimeFile customDateTimeFile = new CustomDateTimeFile();
            string fileName = customDateTimeFile.GetFileName(ImagePath.FileName);

            if (ModelState.IsValid)
            {
                vip.ImagePath = fileName;
                if (_IsAcceptedFormat(ImagePath.ContentType))
                {

                    string path = Path.Combine(hostingEnvironment.WebRootPath, "images", fileName);
                    byte[] data = new byte[ImagePath.Length];

                    using (FileStream fileStream = new FileStream(path, FileMode.Create))
                    {
                        await ImagePath.CopyToAsync(fileStream);
                    }
                }
                await _context.AddAsync(vip);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ServiceId"] = new SelectList(_context.Services, "Id", "Id", vip.ServiceId);
            return View(vip);
        }

        // GET: Admin/Vips/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vip = await _context.Vips.FindAsync(id);
            if (vip == null)
            {
                return NotFound();
            }
            ViewData["ServiceId"] = new SelectList(_context.Services, "Id", "Id", vip.ServiceId);
            return View(vip);
        }

        // POST: Admin/Vips/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ImagePath,ImageTitle,Title,SubTitle,Key,Value,Text,SubText,Phone,OtherPhone,Email,SiteAddress,Address,ServiceId")] Vip vip)
        {
            if (id != vip.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vip);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VipExists(vip.Id))
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
            ViewData["ServiceId"] = new SelectList(_context.Services, "Id", "Id", vip.ServiceId);
            return View(vip);
        }

        // GET: Admin/Vips/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vip = await _context.Vips
                .Include(v => v.Service)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vip == null)
            {
                return NotFound();
            }

            return View(vip);
        }

        // POST: Admin/Vips/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vip = await _context.Vips.FindAsync(id);
            _context.Vips.Remove(vip);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VipExists(int id)
        {
            return _context.Vips.Any(e => e.Id == id);
        }
    }
}
