using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Models
{
    public class Flight
    {
        [Key]
        public int FlightId { get; set; }

        public virtual FromCity FromCity { get; set; }
        [Required]
        [ForeignKey("FromCity")]
        public int FCityId { get; set; }

        public virtual ToCity ToCity { get; set; }
        [Required]
        [ForeignKey("ToCity")]
        public int TCityId { get; set; }

        [Required]
        public DateTime Time { get; set; }
        [Required]
        public int TotalCount { get; set; }//umumi biletlerin sayi
        public int CariCount { get; set; }//qalan biletlerin sayi
        public List<int> Seats { get; set; }
        [Required]
        public int Price { get; set; }
        public bool IsDeleted { get; set; }
    }
}
