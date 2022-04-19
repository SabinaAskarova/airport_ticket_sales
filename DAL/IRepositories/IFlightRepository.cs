using MyProject.Models;
using System.Collections.Generic;

namespace MyProject.DAL.IRepositories
{
    public interface IFlightRepository
    {
        public List<Flight> Get();

        public Flight GetById(int flightId);

        public Flight Add(Flight flight);

        public Flight Update(Flight flight);

        public void Delete(int flightId);
    }
}
