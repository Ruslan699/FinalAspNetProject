using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyApplication.Filters;
using MyApplication.Models;

namespace MyApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ToursDbContext _toursDbContext;

        public HomeController(ToursDbContext toursDbContext)
        {
            _toursDbContext = toursDbContext;

        }
        public ViewResult Index()
        {
            List<Tour> Tours = new List<Tour>()
            {
                new Tour { Id = 1, Name = "Quba", Description = "Quba chox gozel rayondu", Price = 950, ImagePath= "quba.jpg" },
                new Tour { Id = 2, Name = "Qusar", Description = "Qusar chox gozel rayondu", Price = 900, ImagePath="qusar.jpg" }
            };

            //var model = new ToursListModel
            //{
            //    tours = Tours
            //};
            return View(Tours);
        }


        public IActionResult Index2()
        {
            List<Tour> Tours = new List<Tour>()
            {
                new Tour { Id = 1, Name = "Quba", Description = "Quba chox gozel rayondu", Price = 950 },
                new Tour { Id = 2, Name = "Qusar", Description = "Qusar chox gozel rayondu", Price = 950, ImagePath = "quba.jpg"}
            };

            //ToursListModel model = new ToursListModel()
            //{
            //    tours = Tours
               
            //};
            return View(Tours);
        }

        [HandleException]
        public IActionResult Index5()
        {
            throw new Exception("Some bad ocurred");
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
    

        [HttpPost]
        public IActionResult Create(Tour tours)
        {
          
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Footer()
        {
            var set = await _toursDbContext.Settings.Select((x) => new
            {
                addreses = x.Address,
                faxes = x.Fax,
                numbers = x.Phone,
                mails = x.Email,
                siteadress =x.OtherAddress,
                social = x.Facebook,
                socialTwo = x.Instagram,
                socialThree = x.Twitter,
                socialFour = x.Linkedin,
                title = x.Title,
                desciption = x.Text,
                picture = x.Icon

            }).FirstOrDefaultAsync();
            return Json(set);
        }
    }
}