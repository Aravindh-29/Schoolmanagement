using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.Models
{
    public class Student
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Class { get; set;}
    }
}
