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
        private static PersonRepository db = new PersonRepository();
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
            if (ModelState.IsValid)
            {
                db.AddResponse(pers);
                return View("Hello", pers);
            }
            else
            {
                return View();
            }
        }

        public ViewResult OutputData()
        {
            ViewBag.Pers = db.GetAllResponses;
            ViewBag.Count = db.NumberOfPersons;
            return View("ListPerson");
        }

        public string Start() 
        { 
            int hour = DateTime.Now.Hour; 
            string Greeting = hour < 12 ? "Top of the morning to ya!" : "Afternoon!"; 
            return Greeting; 
        }

    }
}