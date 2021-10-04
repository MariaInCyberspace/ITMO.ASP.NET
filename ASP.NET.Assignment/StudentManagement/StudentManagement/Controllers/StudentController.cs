using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using StudentManagement.Models;
using System.Net;

namespace StudentManagement.Controllers
{
    public class StudentController : Controller
    {
        private StudentManagementContext db = new StudentManagementContext();

        // Index
        // GET: Student
        public ActionResult Index()
        {
            return View(db.Student.ToList());
        }


        // Details
        [HttpGet]
        public ActionResult Details(int? id)
        {
            int total = 0;
            var totalScore = from r in db.Record where r.StudentId == id select r.Grade;
            foreach (int grade in totalScore)
            {
                total += grade;
            }
            ViewBag.TotalScore = total;
            Student student = db.Student.Find(id);
            return View(student);
        }


        // Get Student-entity creation form
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


        // Create Student entity
        [HttpPost]
        public ActionResult Create([Bind(Include = "FirstName, LastName, EntryDate")] Student student)
        {
            if (ModelState.IsValid)
            {
                db.Student.Add(student);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(student);
        }

        // Add grades for created Student using Record controller
        public ActionResult Enroll()
        {
            return RedirectToAction("Create", "Record");
        }

        public ActionResult TopFive()
        {
            int sum = 0;
            var query = db.Student.ToList();
            List<StudentTotalScore> totalScore = new List<StudentTotalScore>();
            foreach (Student s in query)
            {
                var grades = from rec in db.Record where rec.StudentId == s.StudentId select rec.Grade;
                foreach (int g in grades)
                {
                    sum += g;
                }
                totalScore.Add(new StudentTotalScore { FirstName = s.FirstName, LastName = s.LastName, EntryDate = s.EntryDate, TotalScore = sum });
                sum = 0;
            }
            var total = from t in totalScore orderby t.TotalScore descending select t;
            return View(total.ToList().Take(5));
        }

        // Get edit Student form
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            Student student = db.Student.Find(id);
            return View(student);
        }

        // Save changes in the edited Student entity
        [HttpPost]
        public ActionResult Edit([Bind(Include = "FirstName,LastName,EntryDate")] Student student)
        {
            if (ModelState.IsValid)
            {
                db.Entry(student).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        }

        
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            Student student = db.Student.Find(id);
            return View(student);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Student student = db.Student.Find(id);
            db.Student.Remove(student);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}