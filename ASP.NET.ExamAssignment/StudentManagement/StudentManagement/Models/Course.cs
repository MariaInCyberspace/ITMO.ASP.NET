using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace StudentManagement.Models
{
    public class Course
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Course Id")]
        public int CourseId { get; set; }

        [Display(Name ="Course Title")]
        public string Title { get; set; }
        public int Credits { get; set; }
        public virtual ICollection<Record> Records { get; set; }
    }
}