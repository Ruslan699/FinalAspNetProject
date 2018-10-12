using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyApplication.Models;

namespace MyApplication.Controllers
{
    public class ContactController : Controller
    {
        private readonly ToursDbContext _toursDbContext;

        public ContactController(ToursDbContext toursDbContext)
        {
            _toursDbContext = toursDbContext;

        }
       
        [Route("/Contact")]
        public IActionResult Contact()
        {
            ViewBag.Setting = _toursDbContext.Settings.First();
            Contact model = _toursDbContext.Contacts.FirstOrDefault();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("/Contact")]
        public async Task<IActionResult> Contact(Message mes)
        {
            if(ModelState.IsValid)
            {
                await _toursDbContext.AddAsync(mes);
                await _toursDbContext.SaveChangesAsync();

            }

            else
            {
                return RedirectToAction("Error");
            }

            return Json(new { Result = "Success", Message = "Send Successfully" });
        }


    }
}