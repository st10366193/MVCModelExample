using System.ComponentModel.DataAnnotations;

namespace MVCModelExample.Models
{
    public class user
    {

        [Required (ErrorMessage ="You can not leave id blank")]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int age { get; set; }
        public string Email { get; set; } 
        public string role { get; set; }
    }
}
