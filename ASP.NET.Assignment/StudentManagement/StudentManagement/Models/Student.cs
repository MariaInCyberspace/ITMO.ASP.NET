using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [Required(ErrorMessage = "The field can't be left empty!")]
        [MaxLength(45)]
        [DataType(DataType.Text, ErrorMessage = "Just text!")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "The field can't be left empty!")]
        [MaxLength(45)]
        [DataType(DataType.Text)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Entry Date")]
        [DataType(DataType.DateTime)]
        public DateTime EntryDate { get; set; }
        public virtual ICollection<Record> Records { get; set; }
    }
}