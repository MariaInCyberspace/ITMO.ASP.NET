using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentManagement.Models;

namespace StudentManagement.Controllers
{
    public class StudentController : Controller
    {
        private StudentManagementContext database = new StudentManagementContext();

        // GET: Student
        public ActionResult Index()
        {
            // The view has a link to another (AllStudents) action and nothing else
            return View();
        }
        public ActionResult AllStudents()
        {
            return View(database.Student.ToList());
        }

        // View detailed info for a selected student and their total score
        public ActionResult TotalScore(int? studentId)
        {
            int totalScore = 0;
            var allGrades = from r in database.Record where r.StudentId == studentId select r.Grade;
            foreach (int grade in allGrades)
            {
                totalScore += grade;
            }
            ViewBag.TotalScore = totalScore;
            Student student = database.Student.Find(studentId);
            return View(student);
        }

        // Check out the top five students in this establishment
        public ActionResult TopFive()
        {
            int sum = 0;
            var query = database.Student.ToList();
            List<StudentTotalScore> totalScore = new List<StudentTotalScore>();
            foreach (Student s in query)
            {
                var grades = from rec in database.Record where rec.StudentId == s.StudentId select rec.Grade;
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

        [HttpGet]
        public ActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddStudent(Student student)
        {
            if (ModelState.IsValid)
            {
                database.Student.Add(student);
                database.SaveChanges();
                return RedirectToAction(actionName: "AllStudents");
            }
            return View();
        }

        [HttpGet]
        public ActionResult ChangeName(int? studentId)
        {
            Student student = database.Student.Find(studentId);
            return View(student);
        }

        [HttpPost] 
        public ActionResult ChangeName(Student student)
        {
            if (ModelState.IsValid)
            {
                database.Entry(student).State = System.Data.Entity.EntityState.Modified;
                database.SaveChanges();
                return RedirectToAction(actionName: "AllStudents");
            }
            return View();
        }

        [HttpGet]
        public ActionResult DeleteStudent(int? studentId)
        {
            Student student = database.Student.Find(studentId);
            return View(student);
        }

        [HttpPost]
        public ActionResult DeleteStudent(int studentId)
        {
            Student student = database.Student.Find(studentId);
            database.Student.Remove(student);
            database.SaveChanges();
            return RedirectToAction(actionName: "AllStudents");
        }

    }
}