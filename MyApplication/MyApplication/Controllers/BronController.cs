using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyApplication.Models;
using MyApplication.Models.Brons;
using MyApplication.Models.ViewModels;

namespace MyApplication.Controllers
{
    public class BronController : Controller
    {
        private readonly ToursDbContext _toursDbContext;

        public BronController(ToursDbContext toursDbContext)
        {
            _toursDbContext = toursDbContext;

        }
        [Route("/Bron/Naftalan")]
        public IActionResult Naftalan()
        {
            ViewBag.Setting = _toursDbContext.Settings.First();

            BronNaftalanModel model = new BronNaftalanModel()
            {
                BronTitle = _toursDbContext.BronTitles.ToList(),
                BronNaftalan = _toursDbContext.BronNaftalans.FirstOrDefault(),
                BronHotels = _toursDbContext.BronHotels.Where(x=>x.TypeOf=="Naftalan").ToList(),
            };
            return View(model);
        }

        [ValidateAntiForgeryToken]
        [Route("/Bron/Naftalan")]
        [HttpPost]
        public async Task<IActionResult> Naftalan (PersonalInformation bron)
        {
            List<ValidationResult> lists = new List<ValidationResult>();
            ValidationContext contet = new ValidationContext(bron);
            Validator.TryValidateObject(bron, contet, lists, true);
            var d = lists;
            if (ModelState.IsValid)
            {
               
                await _toursDbContext.AddAsync(bron);

                await _toursDbContext.SaveChangesAsync();
            }

            else
            {
                return RedirectToAction("Error");
            }
            return Json(new { Result = "Success", Message = "Send Successfully" });
        }

        [Route("Bron/Bilgeh")]
        public IActionResult Bilgeh()
        {
            ViewBag.Setting = _toursDbContext.Settings.First();

            BronBilgehModel model = new BronBilgehModel()
            { 
                BronTitle = _toursDbContext.BronTitles.ToList(),
                BronBilgeh = _toursDbContext.BronBilgehs.FirstOrDefault(),
                BronHotels = _toursDbContext.BronHotels.Where(x => x.TypeOf == "Bilgeh").ToList(),
            };


            return View(model);
        }

        [ValidateAntiForgeryToken]
        [Route("/Bron/Bilgeh")]
        [HttpPost]
        public async Task<IActionResult> Bilgeh(PersonalInformation bron)
        {
            if (ModelState.IsValid)
            {
                await _toursDbContext.AddAsync(bron);

                await _toursDbContext.SaveChangesAsync();
            }

            else
            {
                return RedirectToAction("Error");
            }
            return Json(new { Result = "Success", Message = "Send Successfully" });
        }

        [Route("/Bron/GoyGol")]
        public IActionResult GoyGol()
        {
            ViewBag.Setting = _toursDbContext.Settings.First();
            BronGoyGolModel model = new BronGoyGolModel()
            {
                SimiliarTours = _toursDbContext.SimiliarTours.ToList(),
                BronInfo = _toursDbContext.BronInfos.Where(m => m.BronEnum == BronEnum.GoyGol).FirstOrDefault()
            };
            return View(model);
        }

        [ValidateAntiForgeryToken]
        [Route("/Bron/GoyGol")]
        [HttpPost]
        public async Task<IActionResult> GoyGol(SimpleInformation bron)

        {
            if (ModelState.IsValid)
            {
                await _toursDbContext.AddAsync(bron);

                await _toursDbContext.SaveChangesAsync();
            }

            else
            {
                return RedirectToAction("Error");
            }
            return Json(new { Result = "Success", Message = "Send Successfully" });
        }

        [Route("Bron/Lankaran")]
        public IActionResult Lankaran()
        {
            ViewBag.Setting = _toursDbContext.Settings.First();
            BronLankaranModel model = new BronLankaranModel()
            {
                BronTitle = _toursDbContext.BronTitles.ToList(),
                BronLankaran = _toursDbContext.BronLankarans.FirstOrDefault(),
                BronHotels = _toursDbContext.BronHotels.Where(x => x.TypeOf == "Lankaran").ToList()
            };
            return View(model);
        }
        [ValidateAntiForgeryToken]
        [Route("/Bron/Lankaran")]
        [HttpPost]
        public async Task<IActionResult> Lankaran(PersonalInformation bron)
        {
            if (ModelState.IsValid)
            {
                await _toursDbContext.AddAsync(bron);

                await _toursDbContext.SaveChangesAsync();
            }

            else
            {
                return RedirectToAction("Error");
            }
            return Json(new { Result = "Success", Message = "Send Successfully" });
        }
        [Route("Bron/Qabala")]
        public IActionResult Qabala()
        {
            ViewBag.Setting = _toursDbContext.Settings.First();
            BronQabalaModel model = new BronQabalaModel()
            {
                SimiliarTours = _toursDbContext.SimiliarTours.ToList(),
                BronInfo = _toursDbContext.BronInfos.Where(m => m.BronEnum == BronEnum.Qabala).FirstOrDefault()
            };
            return View(model);
        }

        [ValidateAntiForgeryToken]
        [Route("Bron/Qabala")]
        [HttpPost]
        public async Task<IActionResult> Qabala(SimpleInformation bron)
        {
            if (ModelState.IsValid)
            {
                await _toursDbContext.AddAsync(bron);

                await _toursDbContext.SaveChangesAsync();
            }

            else
            {
                return RedirectToAction("Error");
            }
            return Json(new { Result = "Success", Message = "Send Successfully" });
        }

        [Route("Bron/Qakh")]
        public IActionResult Qakh()
        {
            ViewBag.Setting = _toursDbContext.Settings.First();
            BronQakhModel model = new BronQakhModel()
            {
                SimiliarTours = _toursDbContext.SimiliarTours.ToList(),
                BronInfo = _toursDbContext.BronInfos.Where(m => m.BronEnum == BronEnum.Qakh).FirstOrDefault()
            };
            return View(model);
        }

        [ValidateAntiForgeryToken]
        [Route("Bron/Qakh")]
        [HttpPost]
        public async Task<IActionResult> Qakh(SimpleInformation bron)
        {
            if (ModelState.IsValid)
            {
                await _toursDbContext.AddAsync(bron);

                await _toursDbContext.SaveChangesAsync();
            }

            else
            {
                return RedirectToAction("Error");
            }
            return Json(new { Result = "Success", Message = "Send Successfully" });
        }

        [Route("Bron/Quba")]
        public IActionResult Quba()
        {
            ViewBag.Setting = _toursDbContext.Settings.First();
            BronQubaModel model = new BronQubaModel()
            {
                SimiliarTours = _toursDbContext.SimiliarTours.ToList(),
                BronInfo = _toursDbContext.BronInfos.Where(m => m.BronEnum == BronEnum.Quba).FirstOrDefault()
            };
            return View(model);
        }


        [ValidateAntiForgeryToken]
        [Route("/Bron/Quba")]
        [HttpPost]
        public async Task<IActionResult> Quba(SimpleInformation bron)
        {
            if (ModelState.IsValid)
            {
                await _toursDbContext.AddAsync(bron);

                await _toursDbContext.SaveChangesAsync();
            }

            else
            {
                return RedirectToAction("Error");
            }
            return Json(new { Result = "Success", Message = "Send Successfully" });
        }

        [Route("Bron/Sheki")]
        public IActionResult Sheki()
        {
            ViewBag.Setting = _toursDbContext.Settings.First();
            BronShekiModel model = new BronShekiModel()
            {
                SimiliarTours = _toursDbContext.SimiliarTours.ToList(),
                BronInfo = _toursDbContext.BronInfos.Where(m => m.BronEnum == BronEnum.Sheki).FirstOrDefault()
            };
            return View(model);
        }

        [ValidateAntiForgeryToken]
        [Route("/Bron/Sheki")]
        [HttpPost]
        public async Task<IActionResult> Sheki(SimpleInformation bron)
        {
            if (ModelState.IsValid)
            {
                await _toursDbContext.AddAsync(bron);

                await _toursDbContext.SaveChangesAsync();
            }

            else
            {
                return RedirectToAction("Error");
            }
            return Json(new { Result = "Success", Message = "Send Successfully" });
        }

        [Route("Bron/Vulkan")]
        public IActionResult Vulkan()
        {
            ViewBag.Setting = _toursDbContext.Settings.First();
            BronVulkanModel model = new BronVulkanModel()
            {
                SimiliarTours = _toursDbContext.SimiliarTours.ToList(),
                BronInfo = _toursDbContext.BronInfos.Where(m => m.BronEnum == BronEnum.Vulkan).FirstOrDefault()
            };
            return View(model);
        }

        [ValidateAntiForgeryToken]
        [Route("/Bron/Vulkan")]
        [HttpPost]
        public async Task<IActionResult> Vulkan(SimpleInformation bron)
        {
            if (ModelState.IsValid)
            {
                await _toursDbContext.AddAsync(bron);

                await _toursDbContext.SaveChangesAsync();
            }

            else
            {
                return RedirectToAction("Error");
            }
            return Json(new { Result = "Success", Message = "Send Successfully" });
        }

        [Route("Bron/YanarDag")]
        public IActionResult YanarDag()
        {
            ViewBag.Setting = _toursDbContext.Settings.First();
            BronFireMountainModel model = new BronFireMountainModel()
            {
                SimiliarTours = _toursDbContext.SimiliarTours.ToList(),
                BronInfo = _toursDbContext.BronInfos.Where(m => m.BronEnum == BronEnum.YanarDag).FirstOrDefault()
            };
            return View(model);
        }


        [ValidateAntiForgeryToken]
        [Route("/Bron/YanarDag")]
        [HttpPost]
        public async Task<IActionResult> YanarDag(SimpleInformation bron)
        {
            if (ModelState.IsValid)
            {
                await _toursDbContext.AddAsync(bron);

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