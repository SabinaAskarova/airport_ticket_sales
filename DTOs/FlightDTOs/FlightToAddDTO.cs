using System;
using System.ComponentModel.DataAnnotations;

namespace MyProject.DTOs.FlightDTOs
{
    public class FlightToAddDTO
    {
        public int? FlightId { get; set; }
        [Required]
        public int FCityId { get; set; }

        [Required]
        public int TCityId { get; set; }

        [Required]
        public DateTime Time { get; set; }

        [Required]
        public int TotalCount { get; set; }
        [Required]
        public int CariCount { get; set; }
        
        [Required]
        public int Price { get; set; }
    }
}
