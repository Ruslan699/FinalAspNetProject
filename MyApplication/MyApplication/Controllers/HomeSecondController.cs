using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyApplication.Models;
using MyApplication.Models.ViewModels;

namespace MyApplication.Controllers
{
    public class HomeSecondController : Controller
    {
        private readonly ToursDbContext _toursDbContext;

        public HomeSecondController(ToursDbContext toursDbContext)
        {
            _toursDbContext = toursDbContext;
        }

        [Route("Index")]
        public IActionResult Index()
        {
            ViewBag.Setting = _toursDbContext.Settings.First();

            MainPageModel model = new MainPageModel()
            {
                MainPages = _toursDbContext.MainPages.ToList(),
                MainPageTitleSubTitle = _toursDbContext.MainPageTitles.FirstOrDefault()
            };
            return View(model);
        }

        [Route("Index/Naftalan")]
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
        [Route("Index/Naftalan")]
        public async Task <IActionResult> Naftalan(Message mes)
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

        [Route("Index/GoyGol")]
        public IActionResult GoyGol()
        {
            ViewBag.Setting = _toursDbContext.Settings.First();
            GoyGolPageModel model = new GoyGolPageModel()
            {
                GoyGolDescriptions = _toursDbContext.GoyGolDescriptions.ToList(),
                GoyGolPage = _toursDbContext.GoyGolPages.FirstOrDefault()
            };
            return View(model);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        [Route("Index/GoyGol")]
        public async Task<IActionResult> GoyGol(Message mes)

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

        [Route("Index/YanarDag")]
        public IActionResult YanarDag()
        {
            ViewBag.Setting = _toursDbContext.Settings.First();
            FireMountainModel model = new FireMountainModel()
            {
                FireMountainDescriptions = _toursDbContext.FireMountainDescriptions.ToList(),
                FireMountainPage = _toursDbContext.FireMountainPages.FirstOrDefault()
            };
            return View(model);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        [Route("Index/YanarDag")]
        public async Task<IActionResult> YanarDag(Message mes)

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

        [Route("Index/Sheki")]
        public IActionResult Sheki()
        {
            ViewBag.Setting = _toursDbContext.Settings.First();
            ShakiPageModel model = new ShakiPageModel()
            {
                ShakiPageDescriptions = _toursDbContext.ShakiPageDescriptions.ToList(),
                ShakiPage = _toursDbContext.ShakiPages.FirstOrDefault()
            };
            return View(model);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        [Route("Index/Sheki")]
        public async Task<IActionResult> Sheki(Message mes)

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