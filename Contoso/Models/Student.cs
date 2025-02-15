﻿namespace Contoso.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string Secret {  get; set; }

        public ICollection<Enrollment>? Enrollments { get; set; }

    }
}
