using MyProject.DTOs.FromCityDTOs;
using MyProject.DTOs.ToCityDTOs;
using MyProject.Models;
using System;
using System.Collections.Generic;

namespace MyProject.DTOs.FlightDTOs
{
    public class FlightToListDTO
    {
        public int? FlightId { get; set; }

        public FromCityToListDTO FromCity { get; set; }

        public int FCityId { get; set; }

        public ToCityToListDTO ToCity { get; set; }

        public int TCityId { get; set; }

        public DateTime Time { get; set; }
        
        public int TotalCount { get; set; }
        
        public int CariCount { get; set; }
        public List<int> Seats { get; set; }
        
        public int Price { get; set; }
        
        public bool IsDeleted { get; set; }
    }
}
