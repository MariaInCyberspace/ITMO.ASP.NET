using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace StudentManagement.Models
{
    public class Record
    {
        [Display(Name = "Record ID")]
        public int RecordId { get; set; }

        [Required(ErrorMessage = "This field cannot be left empty!")]
        [Display(Name = "Course ID")]
        public int CourseId { get; set; }
        [Display(Name = "Student ID")]
        public int StudentId { get; set; }

        [Range(0, 100, ErrorMessage = "Grade value should be between 0 to 100")]
        [Required(ErrorMessage = "This field cannot be left empty!")]
        // nullable
        public int? Grade { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}