using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyApplication.Models;
using MyApplication.Models.ViewModels;

namespace MyApplication.Controllers
{
    public class HealthController : Controller
    {
        private readonly ToursDbContext _toursDbContext;

        public HealthController(ToursDbContext toursDbContext)
        {
            _toursDbContext = toursDbContext;
        }
        [Route("/Health/Naftalan")]
        public IActionResult Naftalan()
        {
            ViewBag.Setting = _toursDbContext.Settings.First();

            NaftalanPageModel model = new NaftalanPageModel()
            {
                NaftalanDescriptions = _toursDbContext.NaftalanDescriptions.ToList(),
                NaftalanPage = _toursDbContext.NaftalanPages.FirstOrDefault()
            };
            return View(model);
        }


        [ValidateAntiForgeryToken]
        [HttpPost]
        [Route("/Health/Naftalan")]
        public async Task<IActionResult> Naftalan(Message mes)
        {
            if (ModelState.IsValid)
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

        [Route("/Health/Bilgeh")]
        public IActionResult Bilgeh()
        {
            ViewBag.Setting = _toursDbContext.Settings.First();

            BilgehPageModel model = new BilgehPageModel()
            {
                BilgehDescriptions = _toursDbContext.BilgehDescriptions.ToList(),
                BilgehPage = _toursDbContext.BilgehPages.FirstOrDefault()
            };
            return View(model);
        }
    }
}