using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity_HiramTodd.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        // The EnrollmentID property will be the primary key; this entity uses 
        // the classnameID pattern instead of ID by itself as you saw in the 
        // Student entity
        public int EnrollmentID { get; set; }

        // The CourseID property is a foreign key, and the corresponding 
        // navigation property is Course. An Enrollment entity is associated 
        // with one Course entity
        public int CourseID { get; set; }

        // The StudentID property is a foreign key, and the corresponding 
        // navigation property is Student
        public int StudentID { get; set; } 
        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade { get; set; }

        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}

// This Enrollment class is a navigation property wich hold other entities that are related to this entity