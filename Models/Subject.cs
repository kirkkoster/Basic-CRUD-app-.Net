using System.ComponentModel.DataAnnotations;

namespace EFMVC.Models
{
    public class Subject
    {
        [Key]
        public int SubjectId { get; set; }
        public string? SubjectName { get; set; }
        public string? SubjectTerm { get; set; }
        public int SubjectCredits { get; set; }
        public List<Teacher> SubjectTeachers { get; set; } = new List<Teacher>();
    }
}
