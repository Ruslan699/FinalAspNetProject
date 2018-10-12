using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyApplication.Models;

namespace MyApplication.Controllers
{
    public class OnlinePaymentController : Controller
    {
        private readonly ToursDbContext _toursDbContext;

        public OnlinePaymentController(ToursDbContext toursDbContext)
        {

            _toursDbContext = toursDbContext;
        }

        [Route("/OnlinePayment")]
        public IActionResult OnlinePayment()
        {
            ViewBag.Setting = _toursDbContext.Settings.First();

            return View();
        }

    }
}