using System.ComponentModel.DataAnnotations;

namespace StudentRegistration.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        public string CourseCode { get; set; }

        [Required]
        public string CourseName { get; set; }

        [Range(1, 10)]
        public int Credits { get; set; }

        [Required]
        public string Instructor { get; set; }
    }
}