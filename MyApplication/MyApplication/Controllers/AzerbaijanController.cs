using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyApplication.Models;
using MyApplication.Models.ViewModels;

namespace MyApplication.Controllers
{
    public class AzerbaijanController : Controller
    {
        private readonly ToursDbContext _toursDbContext;

        public AzerbaijanController(ToursDbContext toursDbContext)
        {
            _toursDbContext = toursDbContext;

        }

        [Route("Azerbaijan")]
        public IActionResult Azerbaijan()
        {
            ViewBag.Setting = _toursDbContext.Settings.First();

            AzerbaijanModel model = new AzerbaijanModel()
            {
                Azerbaijans = _toursDbContext.Azerbaijans.ToList(),
                AzeTitleSubtitle = _toursDbContext.AzeTitleSubTitles.FirstOrDefault()
            };
            return View(model);
        }

        [Route("/Azerbaijan/Quba")]
        public IActionResult Quba()
        {
            ViewBag.Setting = _toursDbContext.Settings.First();
            QubaPageViewModel model = new QubaPageViewModel()
            {
                QubaPageDescriptions = _toursDbContext.QubaPageDescriptions.ToList(),
                QubaPage = _toursDbContext.QubaPages.FirstOrDefault()
            };
            return View(model);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        [Route("/Azerbaijan/Quba")]
        public async Task<IActionResult> Quba(Message mes)

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

        [Route("/Azerbaijan/Qakh")]
        public IActionResult Qakh()
        {
            ViewBag.Setting = _toursDbContext.Settings.First();
            QakhViewModel model = new QakhViewModel()
            {
                QakhDescriptions = _toursDbContext.QakhDescriptions.ToList(),
                QakhPage = _toursDbContext.QakhPages.FirstOrDefault()
            };
            return View(model);
        }


        [ValidateAntiForgeryToken]
        [HttpPost]
        [Route("/Azerbaijan/Qakh")]
        public async Task<IActionResult> Qakh(Message mes)

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

        [Route("/Azerbaijan/GoyGol")]
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
        [Route("/Azerbaijan/GoyGol")]
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

        [Route("/Azerbaijan/Vulkan")]
        public IActionResult Vulkan()
        {
            ViewBag.Setting = _toursDbContext.Settings.First();
            VulkanViewModel model = new VulkanViewModel()
            {
                VulkanDescriptions = _toursDbContext.VulkanDescriptions.ToList(),
                VulkanPage = _toursDbContext.VulkanPages.FirstOrDefault()
            };
            return View(model);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        [Route("/Azerbaijan/Vulkan")]
        public async Task<IActionResult> Vulkan(Message mes)

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

        [Route("/Azerbaijan/Qabala")]
        public IActionResult Qabala()
        {
            ViewBag.Setting = _toursDbContext.Settings.First();
            QabalaViewModel model = new QabalaViewModel()
            {
                QabalaDescriptions = _toursDbContext.QabalaDescriptions.ToList(),
                QabalaPage = _toursDbContext.QabalaPages.FirstOrDefault()
            };
            return View(model);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        [Route("/Azerbaijan/Qabala")]
        public async Task<IActionResult> Qabala(Message mes)

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

        [Route("/Azerbaijan/Lankaran")]
        public IActionResult Lankaran()
        {
            ViewBag.Setting = _toursDbContext.Settings.First();

            LankaranViewModel model = new LankaranViewModel()
            {
                LankaranDescriptions = _toursDbContext.LankaranDescriptions.ToList(),

                LankaranPage = _toursDbContext.LankaranPages.FirstOrDefault()
            };

            return View(model);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        [Route("/Azerbaijan/Lankaran")]
        public async Task<IActionResult> Lankaran(Message mes)

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