using AutoMapper;
using MyProject.BLL.IServices;
using MyProject.DAL.IRepositories;
using MyProject.DTOs.TicketDTOs;
using MyProject.Models;
using System.Collections.Generic;

namespace MyProject.BLL.Services
{
    public class TicketService: ITicketService
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly IMapper _mapper;

        public TicketService(IMapper mapper, ITicketRepository ticketRepository)
        {
            _mapper = mapper;
            _ticketRepository = ticketRepository;
        }

        public TicketToListDTO Add(TicketToAddDTO ticketToAddDTO)
        {
            Ticket ticket = _mapper.Map<Ticket>(ticketToAddDTO);
            Ticket addedTicket= _ticketRepository.Add(ticket);
            return _mapper.Map<TicketToListDTO>(addedTicket);
        }

        public List<TicketToListDTO> Get()
        {
            return _mapper.Map<List<TicketToListDTO>>(_ticketRepository.Get());
        }

        public TicketToListDTO GetById(int ticketId)
        {
            Ticket ticket = _ticketRepository.GetById(ticketId);
            return _mapper.Map<TicketToListDTO>(ticket);
        }
    }
}
