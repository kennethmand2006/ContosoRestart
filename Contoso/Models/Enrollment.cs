using System.ComponentModel.DataAnnotations.Schema;

namespace Contoso.Models
{
    public enum Grade
    {
        A, B, C, D, E, F
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Course Course { get; set; }
        public Grade? Grade { get; set; }
        [NotMapped]
        public Student Student { get; set; }

        public ICollection<Course>? Courses { get; set; }
        public ICollection<Student>? Students { get; set; }
    }
}
