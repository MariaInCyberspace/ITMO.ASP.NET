using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Net;
using StudentManagement.Models;

namespace StudentManagement.Controllers
{
    public class RecordController : Controller
    {
        StudentManagementContext db = new StudentManagementContext();

        public ActionResult Index()
        {
            var record = db.Record.Include(e => e.Course).Include(e => e.Student);
            return View(record.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.CourseId = new SelectList(db.Course, "CourseId", "Title");
            ViewBag.StudentId = new SelectList(db.Student, "StudentId", "FirstName");
            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "RecordId,CourseId,StudentId,Grade")] Record record)
        {
            if (ModelState.IsValid)
            {
                db.Record.Add(record);
                db.SaveChanges();
                return RedirectToAction("Index");

            }
           // var query = from r in db.Record join s in db.Student on r.StudentId equals s.StudentId select r;
            //if (!query.Any(r => r.CourseId == record.CourseId))
           // {
                
                ViewBag.CourseId = new SelectList(db.Course, "CourseId", "Title", record.CourseId);
                ViewBag.StudentId = new SelectList(db.Student, "StudentId", "FirstName", record.StudentId);
                return View(record);

            // }

        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            Record record = db.Record.Find(id);
            
            ViewBag.CourseId = new SelectList(db.Course, "CourseId", "Title", record.CourseId);
            ViewBag.StudentId = new SelectList(db.Student, "StudentId", "FirstName", record.StudentId);
            return View(record);
        }

        [HttpPost]
        public ActionResult Edit([Bind(Include = "RecordId,CourseId,StudentId,Grade")] Record record)
        {
            if (ModelState.IsValid)
            {
                db.Entry(record).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CourseId = new SelectList(db.Course, "CourseId", "Title", record.CourseId);
            ViewBag.StudentId = new SelectList(db.Student, "StudentId", "FirstName", record.StudentId);
            return View(record);
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            
            Record record = db.Record.Find(id);
            
            return View(record);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Record record = db.Record.Find(id);
            db.Record.Remove(record);
            db.SaveChanges();
            return RedirectToAction("Index", "Student");
        }
    }
}