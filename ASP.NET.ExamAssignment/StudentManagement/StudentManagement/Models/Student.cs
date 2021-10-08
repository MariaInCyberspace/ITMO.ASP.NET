using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace StudentManagement.Models
{
    public class Student
    {
        [Display(Name = "Student ID")]
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

        [Required(ErrorMessage = "The field can't be left empty!")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy}")]
        public DateTime EntryDate { get; set; }
        public virtual ICollection<Record> Records { get; set; }
    }
}