using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCCreditApp1.Models;

namespace MVCCreditApp1.Controllers
{
    public class HomeController : Controller
    {
        private CreditContext db = new CreditContext();
        public ActionResult Index()
        {
            GiveCredits();
            return View();
        }

        [HttpGet]
        public ActionResult CreateBid()
        {
            GiveBids();
            
            return View();
        }

        [HttpPost]
        public string CreateBid(Bid newBid)
        {
            newBid.bidDate = DateTime.Now; 
            // Add a new bid to the database
            db.Bids.Add(newBid); 
            // Save changes to the database
            db.SaveChanges(); 
            return "Thank you, <b>" + newBid.Name + "</b>, for choosing our bank. Your application will be reviewed in the next 10 days."; 
        }

            public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        private void GiveCredits()
        {
            var allCredits = db.Credits.ToList<Credit>();
            ViewBag.Credits = allCredits;
        }

        private void GiveBids()
        {
            GiveCredits();
            var allBids = db.Bids.ToList<Bid>();
            ViewBag.Bids = allBids;
        }
    }
}