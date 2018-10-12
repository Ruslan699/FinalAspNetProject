using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyApplication.Models;
using MyApplication.Models.ViewModels;
namespace MyApplication.Controllers
{
    public class ServiceController : Controller
    {
        private readonly ToursDbContext _toursDbContext;

        public ServiceController(ToursDbContext toursDbContext)
        {
            _toursDbContext = toursDbContext;

        }

        [Route("Service")]
        public IActionResult Service()
        {

            ViewBag.Setting = _toursDbContext.Settings.First();
            Service model = _toursDbContext.Services.FirstOrDefault();
            return View(model);
        }

        [Route("/Service/Cruiz")]
        public IActionResult Cruiz()
        {
            ViewBag.Setting = _toursDbContext.Settings.First();
            Cruiz model = _toursDbContext.Cruizs.FirstOrDefault();
            return View(model);
        }


        [ValidateAntiForgeryToken]
        [HttpPost]
        [Route("/Service/Cruiz")]
        public async Task<IActionResult> Cruiz(Message mes)
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

        [Route("/Service/Transport")]
        public IActionResult Transport()
        {
            ViewBag.Setting = _toursDbContext.Settings.First();

            TransportViewModel model = new TransportViewModel()
            {
                TransportDescriptions = _toursDbContext.TransportDescriptions.ToList(),
                Transport = _toursDbContext.Transports.FirstOrDefault()
            };
            return View(model);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        [Route("/Service/Transport")]

        public async Task<IActionResult> Transport(Message mes)
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

        [Route("/Service/GroupTour")]
        public IActionResult GroupTour()
        {
            ViewBag.Setting = _toursDbContext.Settings.First();
            GroupTour model = _toursDbContext.GroupTours.FirstOrDefault();
            return View(model);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        [Route("/Service/GroupTour")]
        public async Task<IActionResult> GroupTour(Message mes)
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

        [Route("/Service/Vip")]
        public IActionResult Vip()
        {
            ViewBag.Setting = _toursDbContext.Settings.First();
            Vip model = _toursDbContext.Vips.FirstOrDefault();
            return View(model);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        [Route("/Service/Vip")]
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

        //[Route("/Service/Incoming")]
        public IActionResult Incoming()
        {

            ViewBag.Setting = _toursDbContext.Settings.First();

            IncomingModel model = new IncomingModel()
            {
                Incomings = _toursDbContext.Incoming.ToList(),
                TitleAndSubTitle = _toursDbContext.TitleAndSubTitles.Where(m => m.StaticPage == StaticPage.Incoming).FirstOrDefault()
            };
            return View(model);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        [Route("/Service/Incoming")]
        public async Task<IActionResult> Incoming(Message mes)
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


        [Route("/Service/Health")]
        public IActionResult Health()
        {

            ViewBag.Setting = _toursDbContext.Settings.First();

            HealthModel model = new HealthModel()
            {
                Healths = _toursDbContext.Healths.ToList(),
                TitleAndSubTitles = _toursDbContext.TitleAndSubTitles.Where(m => m.StaticPage == StaticPage.Health).FirstOrDefault()
            };
            return View(model);

        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        [Route("/Service/Health")]
        public async Task<IActionResult> Health(Message mes)
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


        [Route("/Service/Event")]
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
        [Route("/Service/Event")]
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


        [Route("/Service/Transfer")]
        public IActionResult Transfer()
        {

            ViewBag.Setting = _toursDbContext.Settings.First();
            Transfer model = _toursDbContext.Transfers.FirstOrDefault();
            return View(model);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        [Route("/Service/Transfer")]
        public async Task<IActionResult> Transfer(Message mes)
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

        [Route("/Service/Advice")]
        public IActionResult Advice()
        {
            ViewBag.Setting = _toursDbContext.Settings.First();
            Advice model = _toursDbContext.Advices.FirstOrDefault();
            return View(model);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        [Route("/Service/Advice")]
        public async Task<IActionResult> Advice(Message mes)
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

        public IActionResult Insuarance()
        {
            ViewBag.Setting = _toursDbContext.Settings.First();
            InsuaranceViewModel model = new InsuaranceViewModel()
            {
                InsuaranceDescriptions = _toursDbContext.InsuaranceDescriptions.ToList(),
                Insuarance = _toursDbContext.Insuarances.FirstOrDefault()
            };
            return View(model);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        [Route("/Service/Insuarance")]
        public async Task<IActionResult> Insuarance(Message mes)
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

        [Route("/Service/Emergency")]
        public IActionResult Emergency()
        {
            ViewBag.Setting = _toursDbContext.Settings.First();
            Emergency model = _toursDbContext.Emergencies.FirstOrDefault();
            return View(model);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        [Route("/Service/Emergency")]
        public async Task<IActionResult> Emergency(Message mes)
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

        [Route("/Service/HotelList")]
        public IActionResult HotelList()
        {
            ViewBag.Setting = _toursDbContext.Settings.First();
            HotelListModel model = new HotelListModel()
            {
                HotelListDescriptions = _toursDbContext.HotelListDescriptions.ToList(),
                HotelList = _toursDbContext.HotelLists.FirstOrDefault()
            };
            return View(model);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        [Route("/Service/HotelList")]
        public async Task<IActionResult> HotelList(Message mes)
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