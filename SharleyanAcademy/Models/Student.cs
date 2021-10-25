using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharleyanAcademy.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "First/Middle Name")]
        public string FirstMidName { get; set; }

        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }
        public int Age { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}