using System.ComponentModel.DataAnnotations;

namespace MyProject.DTOs.FromCityDTOs
{
    public class FromCityToUpdateDTO
    {
        [Required]
        public int FCityId { get; set; }
        [Required]
        public string FCityName { get; set; }
    }
}
