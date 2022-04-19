using MyProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyProject.DTOs.FlightDTOs
{
    public class FlightToUpdateDTO
    {
        [Required]
        public int? FlightId { get; set; }
        [Required]
        public int FCityId { get; set; }

        [Required]
        public int TCityId { get; set; }

        public FromCity FromCity { get; set; }
        public ToCity ToCity { get; set; }

        [Required]
        public DateTime Time { get; set; }

        [Required]
        public int TotalCount { get; set; }
        [Required]
        public int CariCount { get; set; }
        [Required]
        public List<int> Seats { get; set; }
        [Required]
        public int Price { get; set; }
    }
}
