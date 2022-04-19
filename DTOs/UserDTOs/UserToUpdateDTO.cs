using System.ComponentModel.DataAnnotations;

namespace MyProject.DTOs.UserDTOs
{
    public class UserToUpdateDTO
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        //public bool IsDeleted { get; set; }

    }
}
