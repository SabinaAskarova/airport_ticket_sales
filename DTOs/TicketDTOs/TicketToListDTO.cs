using System;

namespace MyProject.DTOs.TicketDTOs
{
    public class TicketToListDTO
    {
        public int TicketId { get; set; }

        public string NameSurname { get; set; }

        public string FromCityName { get; set; }

        public string ToCityName { get; set; }

        public int SeatNumber { get; set; }

        public int Price { get; set; }

        public DateTime Datetime { get; set; }

    }
}
