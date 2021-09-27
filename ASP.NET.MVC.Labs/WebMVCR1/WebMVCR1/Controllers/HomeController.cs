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
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public string Start() 
        { 
            int hour = DateTime.Now.Hour; 
            string Greeting = hour < 12 ? "Top of the morning to ya!" : "Afternoon!"; 
            return Greeting; 
        }

        public string Index()
        {
            // return StudyCsharp.ExeSwitch(StudyCsharp.SetStatus(0));
            // return StudyCsharp.GetFunction(0, 9);
            // return StudyCsharp.ExeFactorial(0);
            // return StudyCsharp.ExeTriangle();
            return StudyCsharp.ExeCircle();
        }

        
    }
}