using System.ComponentModel.DataAnnotations;

namespace MyProject.DTOs.FromCityDTOs
{
    public class FromCityToAddDTO
    {
        [Required]
        public string FCityName { get; set; }
    }
}
