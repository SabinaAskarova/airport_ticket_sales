using System.ComponentModel.DataAnnotations;

namespace MyProject.DTOs.UserDTOs
{
    public class UserToAddDTO
    {       
        [Required]
        public string UserName { get; set; }
        [Required]
        [MinLength(8)]
        public string Password { get; set; }
        public int SecurityCode { get; set; }
    }
}

