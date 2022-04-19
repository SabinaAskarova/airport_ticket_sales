using System.ComponentModel.DataAnnotations;

namespace MyProject.DTOs.ToCityDTOs
{
    public class ToCityAddDTO
    {
        [Required]
        public string TCityName { get; set; }
    }
}
