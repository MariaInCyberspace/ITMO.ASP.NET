using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVCR1.Models;


namespace WebMVCR1.Controllers
{
    public class HomeController : Controller
    {
        
        // GET: Home

        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour; 
            ViewBag.Greeting = hour < 12 ? "Wakey wakey!" : "Look alive! You definitely should be up by now!"; 
            ViewData["Mes"] = "Cheers!"; 
            return View();
        }

        [HttpGet]
        public ViewResult InputData()
        {
            return View();
        }

        [HttpPost]
        public ViewResult InputData(Person pers)
        {
            return View("Hello", pers);
        }


        public string Start() 
        { 
            int hour = DateTime.Now.Hour; 
            string Greeting = hour < 12 ? "Top of the morning to ya!" : "Afternoon!"; 
            return Greeting; 
        }

    }
}