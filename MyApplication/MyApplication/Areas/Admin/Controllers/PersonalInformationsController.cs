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
    public class PersonalInformationsController : Controller
    {
        private readonly ToursDbContext _context;

        public PersonalInformationsController(ToursDbContext context)
        {
            _context = context;
        }

        // GET: Admin/PersonalInformations
        public async Task<IActionResult> Index()
        {
            return View(await _context.PersonalInfos.ToListAsync());
        }

        // GET: Admin/PersonalInformations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personalInformation = await _context.PersonalInfos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (personalInformation == null)
            {
                return NotFound();
            }

            return View(personalInformation);
        }

        // GET: Admin/PersonalInformations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/PersonalInformations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Surname,Email,Number,PassportNumber,Birth,Parent,Child,Baby,Message")] PersonalInformation personalInformation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personalInformation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personalInformation);
        }

        // GET: Admin/PersonalInformations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personalInformation = await _context.PersonalInfos.FindAsync(id);
            if (personalInformation == null)
            {
                return NotFound();
            }
            return View(personalInformation);
        }

        // POST: Admin/PersonalInformations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Surname,Email,Number,PassportNumber,Birth,Parent,Child,Baby,Message")] PersonalInformation personalInformation)
        {
            if (id != personalInformation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personalInformation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonalInformationExists(personalInformation.Id))
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
            return View(personalInformation);
        }

        // GET: Admin/PersonalInformations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personalInformation = await _context.PersonalInfos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (personalInformation == null)
            {
                return NotFound();
            }

            return View(personalInformation);
        }

        // POST: Admin/PersonalInformations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var personalInformation = await _context.PersonalInfos.FindAsync(id);
            _context.PersonalInfos.Remove(personalInformation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonalInformationExists(int id)
        {
            return _context.PersonalInfos.Any(e => e.Id == id);
        }
    }
}
