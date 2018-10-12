using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyApplication.Models;

namespace MyApplication.Controllers
{
    
    public class AboutController : Controller
    {
        private readonly ToursDbContext _toursDbContext;

        public AboutController(ToursDbContext toursDbContext)
        {
            _toursDbContext = toursDbContext;

        }

        [Route("About")]
        public IActionResult About()
        {
            ViewBag.Setting = _toursDbContext.Settings.First();
            About model = _toursDbContext.Abouts.FirstOrDefault();
            return View(model);
   
        }

        [Route("/About/Profile")]
        public IActionResult Profile()
        {
            ViewBag.Setting = _toursDbContext.Settings.First();
            Profile model = _toursDbContext.Profiles.FirstOrDefault();
            return View(model);

        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        [Route("/About/Profile")]
        public async Task<IActionResult> Profile(Message mes)

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


        [Route("/About/WhyWe")]
        public IActionResult WhyWe()
        {
            ViewBag.Setting = _toursDbContext.Settings.First();
            WhyWe model = _toursDbContext.WhyWe.FirstOrDefault();
            return View(model);
        }


        [Route("/About/Compliance")]
        public IActionResult Compliance()
        {
            ViewBag.Setting = _toursDbContext.Settings.First();
            Compliance model = _toursDbContext.Compliances.FirstOrDefault();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("/About/Compliance")]
        public async Task<IActionResult> Compliance(Message mes)
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

        [Route("/About/Vip")]
        public IActionResult Vip()
        {
            ViewBag.Setting = _toursDbContext.Settings.First();
            Vip model = _toursDbContext.Vips.FirstOrDefault();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("/About/Vip")]
        public async Task<IActionResult> Vip(Message mes)
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
    }
}