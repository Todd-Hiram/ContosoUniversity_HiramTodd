using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity_HiramTodd.Models
{
    public class Student : Person
    {
        // ID is Primary Key for the database Label that corresponds to this class
        //public int ID { get; set; } 
        //public string LastName { get; set; }
        //public string FirstMidName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
        //public object FirstMidName { get; internal set; }
    }
}