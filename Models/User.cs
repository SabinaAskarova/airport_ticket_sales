using System.ComponentModel.DataAnnotations;

namespace MyProject.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required(ErrorMessage = "Please enter username")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please enter password")]
        [MinLength(8)]
        public string Password { get; set; }
        [Required]
        public int SecurityCode { get; set; }
        public bool IsDeleted { get; set; }
    }
}
