using System.ComponentModel.DataAnnotations;

namespace MyProject.DTOs.ToCityDTOs
{
    public class ToCityToUpdateDTO
    {
        [Required]
        public int TCityId { get; set; }
        [Required]
        public string TCityName { get; set; }
    }
}
