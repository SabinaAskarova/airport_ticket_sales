using System.ComponentModel.DataAnnotations;

namespace MyProject.Models
{
    public class FromCity
    {
        [Key]
        public int FCityId { get; set; }
        [Required]
        public string FCityName { get;set; }
        public bool IsDeleted { get; set; }
    }
}
