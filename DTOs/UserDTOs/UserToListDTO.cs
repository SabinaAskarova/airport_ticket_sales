namespace MyProject.DTOs.UserDTOs
{
    public class UserToListDTO
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int SecurityCode { get; set; }
        public bool IsDeleted { get; set; }
    }
}
