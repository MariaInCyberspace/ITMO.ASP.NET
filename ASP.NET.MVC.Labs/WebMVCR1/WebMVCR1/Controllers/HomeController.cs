using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVCR1.Models;


namespace WebMVCR1.Controllers
{
    public class MyController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour; 
            ViewBag.Greeting = hour < 12 ? "Wakey wakey!" : "Look alive! You definitely should be up by now!"; 
            ViewData["Mes"] = "Cheers!"; 
            return View();
        }

        public ViewResult InputData()
        {
            return View();
        }

        public string Start() 
        { 
            int hour = DateTime.Now.Hour; 
            string Greeting = hour < 12 ? "Top of the morning to ya!" : "Afternoon!"; 
            return Greeting; 
        }

    }
}