using System.ComponentModel.DataAnnotations;

namespace WebApplication5.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string stuName { get; set; }

        public string stuPass { get; set; }

    }
}
