namespace AspNetCoreDemo.Models

    public class Student
    {
        public int Id { get; set; }          // Primary key
        public string Name { get; set; }     // Student's name
        public int Age { get; set; }         // Student's age
        public string Email { get; set; }    // Optional: contact info
        public DateTime EnrollmentDate { get; set; } // Optional: track when they joined
    }
