using System;
using System.ComponentModel.DataAnnotations;

namespace MyProject.Models
{
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }

        [Required]
        public string NameSurname { get; set; }

        [Required]
        public string FromCityName { get; set; }

        [Required]
        public string ToCityName { get; set; }

        [Required]
        public int SeatNumber { get; set; }

        [Required]
        public int Price { get; set; }

        public DateTime Datetime { get; set; }

    }
}
