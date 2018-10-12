using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyApplication.Models;
using MyApplication.Models.Brons;

namespace MyApplication.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SimpleInformationsController : Controller
    {
        private readonly ToursDbContext _context;

        public SimpleInformationsController(ToursDbContext context)
        {
            _context = context;
        }

        // GET: Admin/SimpleInformations
        public async Task<IActionResult> Index()
        {
            return View(await _context.SimpleInformation.ToListAsync());
        }

        // GET: Admin/SimpleInformations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var simpleInformation = await _context.SimpleInformation
                .FirstOrDefaultAsync(m => m.Id == id);
            if (simpleInformation == null)
            {
                return NotFound();
            }

            return View(simpleInformation);
        }

        // GET: Admin/SimpleInformations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/SimpleInformations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Surname,Email,Number,Message,Tour,DateTime")] SimpleInformation simpleInformation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(simpleInformation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(simpleInformation);
        }

        // GET: Admin/SimpleInformations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var simpleInformation = await _context.SimpleInformation.FindAsync(id);
            if (simpleInformation == null)
            {
                return NotFound();
            }
            return View(simpleInformation);
        }

        // POST: Admin/SimpleInformations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Surname,Email,Number,Message,Tour,DateTime")] SimpleInformation simpleInformation)
        {
            if (id != simpleInformation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(simpleInformation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SimpleInformationExists(simpleInformation.Id))
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
            return View(simpleInformation);
        }

        // GET: Admin/SimpleInformations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var simpleInformation = await _context.SimpleInformation
                .FirstOrDefaultAsync(m => m.Id == id);
            if (simpleInformation == null)
            {
                return NotFound();
            }

            return View(simpleInformation);
        }

        // POST: Admin/SimpleInformations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var simpleInformation = await _context.SimpleInformation.FindAsync(id);
            _context.SimpleInformation.Remove(simpleInformation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SimpleInformationExists(int id)
        {
            return _context.SimpleInformation.Any(e => e.Id == id);
        }
    }
}
