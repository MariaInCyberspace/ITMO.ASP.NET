using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Models
{
    public class StudentTotalScore
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Entry Date")]

        public DateTime EntryDate { get; set; }
        [Display(Name = "Total Score")]

        public int TotalScore { get; set; }
    }
}