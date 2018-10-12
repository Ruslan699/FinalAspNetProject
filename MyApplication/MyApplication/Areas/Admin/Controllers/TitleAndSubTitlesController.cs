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
    public class TitleAndSubTitlesController : Controller
    {
        private readonly ToursDbContext _context;

        private readonly IHostingEnvironment hostingEnvironment;

        public TitleAndSubTitlesController(ToursDbContext context, IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
            _context = context;
        }

        // GET: Admin/TitleAndSubTitles
        public async Task<IActionResult> Index()
        {
            return View(await _context.TitleAndSubTitles.ToListAsync());
        }

        // GET: Admin/TitleAndSubTitles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var titleAndSubTitle = await _context.TitleAndSubTitles
                .FirstOrDefaultAsync(m => m.Id == id);
            if (titleAndSubTitle == null)
            {
                return NotFound();
            }

            return View(titleAndSubTitle);
        }

        // GET: Admin/TitleAndSubTitles/Create
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

        // POST: Admin/TitleAndSubTitles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,StaticPage,ImagePath,ImageText,Title,SubTitle,_IsService")] TitleAndSubTitle titleAndSubTitle, IFormFile ImagePath)
        {
            CustomDateTimeFile customDateTimeFile = new CustomDateTimeFile();
            string fileName = customDateTimeFile.GetFileName(ImagePath.FileName);

            if (ModelState.IsValid)
            {
                titleAndSubTitle.ImagePath = fileName;
                if (_IsAcceptedFormat(ImagePath.ContentType))
                {

                    string path = Path.Combine(hostingEnvironment.WebRootPath, "images", fileName);
                    byte[] data = new byte[ImagePath.Length];

                    using (FileStream fileStream = new FileStream(path, FileMode.Create))
                    {
                        await ImagePath.CopyToAsync(fileStream);
                    }
                }
                await _context.AddAsync(titleAndSubTitle);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(titleAndSubTitle);
        }

        // GET: Admin/TitleAndSubTitles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var titleAndSubTitle = await _context.TitleAndSubTitles.FindAsync(id);
            if (titleAndSubTitle == null)
            {
                return NotFound();
            }
            return View(titleAndSubTitle);
        }

        // POST: Admin/TitleAndSubTitles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,StaticPage,ImagePath,ImageText,Title,SubTitle,_IsService")] TitleAndSubTitle titleAndSubTitle)
        {
            if (id != titleAndSubTitle.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(titleAndSubTitle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TitleAndSubTitleExists(titleAndSubTitle.Id))
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
            return View(titleAndSubTitle);
        }

        // GET: Admin/TitleAndSubTitles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var titleAndSubTitle = await _context.TitleAndSubTitles
                .FirstOrDefaultAsync(m => m.Id == id);
            if (titleAndSubTitle == null)
            {
                return NotFound();
            }

            return View(titleAndSubTitle);
        }

        // POST: Admin/TitleAndSubTitles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var titleAndSubTitle = await _context.TitleAndSubTitles.FindAsync(id);
            _context.TitleAndSubTitles.Remove(titleAndSubTitle);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TitleAndSubTitleExists(int id)
        {
            return _context.TitleAndSubTitles.Any(e => e.Id == id);
        }
    }
}
