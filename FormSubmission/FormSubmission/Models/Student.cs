using FormSubmission.Annotation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormSubmission.Models
{
    public class Student
    {
        [Required(ErrorMessage ="Fill the Name")]
        [ValidName]
        [StringLength(100)]
        public string Name { get; set; }
        [Required(ErrorMessage ="Fill the Username")]
        [StringLength(10)]
        public string Username { get; set; }
        [Required(ErrorMessage ="Fill the Valid ID")]
        [StringLength (10,MinimumLength =5)]
        public string Id { get; set; }
        [Required(ErrorMessage ="Fill the Email")]
        public string Email { get; set; }
    }
}