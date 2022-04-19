using Microsoft.EntityFrameworkCore;
using MyProject.DAL.DataContext;
using MyProject.DAL.IRepositories;
using MyProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace MyProject.DAL.Repositories
{
    public class FlightRepository:IFlightRepository
    {
        private readonly TestDbContext _ctx;
        public FlightRepository(TestDbContext ctx)
        {
            _ctx = ctx;
        }

        public Flight Add(Flight flight)
        {
            List<int> seats = new List<int>();
            for (int i = 0; i < flight.CariCount; i++)
            {
                seats.Add(i + 1);
            }
            flight.Seats = seats;
            _ctx.Flights.Add(flight);
            _ctx.SaveChanges();
            return flight;
        }
        public void Delete(int flightId)
        {
            Flight flight = _ctx.Flights.Find(flightId);
            flight.IsDeleted = true;
            _ctx.SaveChanges();
        }
        public List<Flight> Get()
        {
            return _ctx.Flights.Include("FromCity").Include("ToCity").OrderBy(m => m.FlightId).ToList();
        }
        public Flight GetById(int flightId)
        {
            Flight flight = _ctx.Flights.AsNoTracking().Include("FromCity").Include("ToCity").FirstOrDefault(m => m.FlightId == flightId);
            return flight;
        }
        public Flight Update(Flight flight)
        {
            
            //flight.Seats = seats;
            _ctx.Flights.Update(flight);
            _ctx.SaveChanges();
            return flight;
        }
    }
}
