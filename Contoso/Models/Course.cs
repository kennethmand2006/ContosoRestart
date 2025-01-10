using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contoso.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        [NotMapped]
        public ICollection<Enrollment>? Enrollments { get; set; }

    }
}
