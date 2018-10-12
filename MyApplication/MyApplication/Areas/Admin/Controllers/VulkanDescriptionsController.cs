using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyApplication.Models;

namespace MyApplication.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class VulkanDescriptionsController : Controller
    {
        private readonly ToursDbContext _context;

        public VulkanDescriptionsController(ToursDbContext context)
        {
            _context = context;
        }

        // GET: Admin/VulkanDescriptions
        public async Task<IActionResult> Index()
        {
            return View(await _context.VulkanDescriptions.ToListAsync());
        }

        // GET: Admin/VulkanDescriptions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vulkanDescription = await _context.VulkanDescriptions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vulkanDescription == null)
            {
                return NotFound();
            }

            return View(vulkanDescription);
        }

        // GET: Admin/VulkanDescriptions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/VulkanDescriptions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AboutTour")] VulkanDescription vulkanDescription)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vulkanDescription);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vulkanDescription);
        }

        // GET: Admin/VulkanDescriptions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vulkanDescription = await _context.VulkanDescriptions.FindAsync(id);
            if (vulkanDescription == null)
            {
                return NotFound();
            }
            return View(vulkanDescription);
        }

        // POST: Admin/VulkanDescriptions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AboutTour")] VulkanDescription vulkanDescription)
        {
            if (id != vulkanDescription.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vulkanDescription);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VulkanDescriptionExists(vulkanDescription.Id))
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
            return View(vulkanDescription);
        }

        // GET: Admin/VulkanDescriptions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vulkanDescription = await _context.VulkanDescriptions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vulkanDescription == null)
            {
                return NotFound();
            }

            return View(vulkanDescription);
        }

        // POST: Admin/VulkanDescriptions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vulkanDescription = await _context.VulkanDescriptions.FindAsync(id);
            _context.VulkanDescriptions.Remove(vulkanDescription);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VulkanDescriptionExists(int id)
        {
            return _context.VulkanDescriptions.Any(e => e.Id == id);
        }
    }
}
