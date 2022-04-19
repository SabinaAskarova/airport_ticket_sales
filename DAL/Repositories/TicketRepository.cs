using MyProject.DAL.DataContext;
using MyProject.DAL.IRepositories;
using MyProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace MyProject.DAL.Repositories
{
    public class TicketRepository:ITicketRepository
    {
        private readonly TestDbContext _ctx;
        public TicketRepository(TestDbContext ctx)
        {
            _ctx = ctx;
        }

        public Ticket Add(Ticket ticket)
        {
            _ctx.Add(ticket);
            _ctx.SaveChanges();
            return ticket;
        }

        public List<Ticket> Get()
        {
            return _ctx.Tickets.OrderBy(m => m.TicketId).ToList();
        }

        public Ticket GetById(int ticketId)
        {
            Ticket ticket = _ctx.Tickets.Find(ticketId);
            return ticket;
        }
    }
}
