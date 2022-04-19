using MyProject.Models;
using System.Collections.Generic;

namespace MyProject.DAL.IRepositories
{
    public interface ITicketRepository
    {
        public List<Ticket> Get();

        public Ticket GetById(int ticketId);

        public Ticket Add(Ticket ticket);

    }
}
