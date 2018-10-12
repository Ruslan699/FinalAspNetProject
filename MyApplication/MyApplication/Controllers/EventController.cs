using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyApplication.Models;
using MyApplication.Models.ViewModels;

namespace MyApplication.Controllers
{
    public class EventController : Controller
    {
        private readonly ToursDbContext _toursDbContext;

        public EventController(ToursDbContext toursDbContext)
        {
            _toursDbContext = toursDbContext;

        }
        [Route("Event")]
        public IActionResult Event()
        {
            ViewBag.Setting = _toursDbContext.Settings.First();
            EventModel model = new EventModel()
            {
                Events = _toursDbContext.Events.ToList(),
                TitleAndSubTitle = _toursDbContext.TitleAndSubTitles.Where(m => m.StaticPage == StaticPage.Event).FirstOrDefault()
            };


            return View(model);
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        [Route("/Event")]
        public async Task<IActionResult> Event(Message mes)
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

        [Route("/Formula")]
        public IActionResult Formula()
        {
            ViewBag.Setting = _toursDbContext.Settings.First();
            FormulaPage model = _toursDbContext.FormulaPages.FirstOrDefault();
            return View(model);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        [Route("/Formula")]
        public async Task<IActionResult> Formula(Message mes)
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

        [Route("/Festival")]
        public IActionResult NarFestivali ()
        {
            ViewBag.Setting = _toursDbContext.Settings.First();
            Festival model = _toursDbContext.Festivals.FirstOrDefault();
            return View(model);
        }


        [ValidateAntiForgeryToken]
        [HttpPost]
        [Route("/Festival")]
        public async Task<IActionResult> NarFestivali(Message mes)
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

        [Route("/Jara")]
        public IActionResult Jara()
        {
            ViewBag.Setting = _toursDbContext.Settings.First();
            BakuJara model = _toursDbContext.BakuJaras.FirstOrDefault();
            return View(model);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        [Route("/Jara")]
        public async Task<IActionResult> Jara(Message mes)
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