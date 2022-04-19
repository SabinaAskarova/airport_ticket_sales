using System.ComponentModel.DataAnnotations;

namespace MyProject.Models
{
    public class ToCity
    {
        [Key]
        public int TCityId { get; set; }
        [Required]
        public string TCityName { get; set; }
        public bool IsDeleted { get; set; }
    }
}