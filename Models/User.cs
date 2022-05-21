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
        [StringLength(20, MinimumLength = 5)]
        public string Password { get; set; }
        [Required]
        public int SecurityCode { get; set; }
        public bool IsDeleted { get; set; }
    }
}
