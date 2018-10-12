using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApplication.Controllers
{
    public class SessionDemoController : Controller
    {
        public string Index()
        {
            HttpContext.Session.SetInt32("age", 25);

            HttpContext.Session.SetString("name", "Ruslan");

            return "Session created";

        }

        public string GetSessions()
        {
            return String.Format("Hello {0}, your age {1}", HttpContext.Session.GetString("name"), 
                            HttpContext.Session.GetInt32("age"));
        }
    }
}