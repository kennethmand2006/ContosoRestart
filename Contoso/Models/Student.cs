namespace Contoso.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int EnrollmentDate { get; set; }

        //public ICollection<Enrollment>? Enrollments { get; set; }

    }
}
