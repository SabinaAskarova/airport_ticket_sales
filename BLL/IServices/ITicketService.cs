using MyProject.DTOs.TicketDTOs;
using System.Collections.Generic;

namespace MyProject.BLL.IServices
{
    public interface ITicketService
    {
        public List<TicketToListDTO> Get();

        public TicketToListDTO Add(TicketToAddDTO ticketToAddDTO);

        public TicketToListDTO GetById(int ticketId);

    }
}
