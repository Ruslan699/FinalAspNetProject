using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyApplication.Models;

namespace MyApplication.Controllers
{
    public class DemoStudentController : Controller
    {
        private readonly ToursDbContext _context;

        public DemoStudentController(ToursDbContext context)
        {
            _context = context;
        }

        // GET: DemoStudents
        [Authorize]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Students.ToListAsync());
        }

        // GET: DemoStudents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var demoStudent = await _context.Students
                .FirstOrDefaultAsync(m => m.Id == id);
            if (demoStudent == null)
            {
                return NotFound();
            }

            return View(demoStudent);
        }

        // GET: DemoStudents/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DemoStudents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Surname,Age")] DemoStudent demoStudent)
        {
            if (ModelState.IsValid)
            {
                _context.Add(demoStudent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(demoStudent);
        }

        // GET: DemoStudents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var demoStudent = await _context.Students.FindAsync(id);
            if (demoStudent == null)
            {
                return NotFound();
            }
            return View(demoStudent);
        }

        // POST: DemoStudents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Surname,Age")] DemoStudent demoStudent)
        {
            if (id != demoStudent.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(demoStudent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DemoStudentExists(demoStudent.Id))
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
            return View(demoStudent);
        }

        // GET: DemoStudents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var demoStudent = await _context.Students
                .FirstOrDefaultAsync(m => m.Id == id);
            if (demoStudent == null)
            {
                return NotFound();
            }

            return View(demoStudent);
        }

        // POST: DemoStudents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var demoStudent = await _context.Students.FindAsync(id);
            _context.Students.Remove(demoStudent);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DemoStudentExists(int id)
        {
            return _context.Students.Any(e => e.Id == id);
        }
    }
}
