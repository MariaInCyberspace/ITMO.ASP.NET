using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace StudentManagement.Models
{
    public class Record
    {
        public int RecordId { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }

        [Range(0, 100, ErrorMessage = "Grade value should be between 0 to 100")]
        // nullable
        public int? Grade { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}