using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using StudentManagement.Models;

namespace StudentManagement.Controllers
{
    public class RecordController : Controller
    {
        private StudentManagementContext database = new StudentManagementContext();
        // GET: Record
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AllRecords()
        {
            var records = database.Record.Include(record => record.Course).Include(record => record.Student);
            return View(records.ToList());
        }

        [HttpGet]
        public ActionResult AddGrades(int? studentId)
        {
            Student student = database.Student.Find(studentId);
            Record record = new Record { StudentId = student.StudentId };
            ViewBag.StudentName = student.FirstName + " " + student.LastName;
            ViewBag.CourseId = new SelectList(database.Course, "CourseId", "Title");
            return View(record);
        }

        [HttpPost]
        public ActionResult AddGrades(Record record)
        {
            ViewBag.CourseId = new SelectList(database.Course, "CourseId", "Title", record.CourseId);
            if (ModelState.IsValid)
            {
                database.Record.Add(record);
                database.SaveChanges();
                return RedirectToAction(actionName: "AllRecords");
            }
            return View();
        }

        [HttpGet] 
        public ActionResult ChangeRecord(int? recordId)
        {

            Record record = database.Record.Find(recordId);
            ViewBag.CourseId = record.CourseId;
            
            return View(record);
        }

        [HttpPost]
        public ActionResult ChangeRecord(Record record)
        {
            if (ModelState.IsValid)
            {
                database.Entry(record).State = EntityState.Modified;
                database.SaveChanges();
                return RedirectToAction(actionName: "AllRecords");
            }
            return View();
        }

        [HttpGet]
        public ActionResult DeleteRecord(int? recordId)
        { 
            Record record = database.Record.Find(recordId);
            return View(record);
        }

        [HttpPost] 
        public ActionResult DeleteRecord(int recordId)
        {
            Record record = database.Record.Find(recordId);
            database.Record.Remove(record);
            database.SaveChanges();
            return RedirectToAction(actionName: "AllRecords");
        }
    }
}