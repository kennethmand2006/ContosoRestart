namespace Contoso.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public int Title { get; set; }
        public int Credits { get; set; }

        public ICollection<Enrollment>? Enrollments { get; set; }
    }
}
