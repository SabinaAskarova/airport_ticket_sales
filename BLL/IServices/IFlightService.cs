using MyProject.DTOs.FlightDTOs;
using System.Collections.Generic;

namespace MyProject.BLL.IServices
{
    public interface IFlightService
    {
        public List<FlightToListDTO> Get();

        public FlightToListDTO Add(FlightToAddDTO flightToAddDTO);

        public FlightToListDTO Update(FlightToUpdateDTO flightToUpdateDTO);

        public FlightToListDTO GetById(int flightId);

        public void Delete(int flightId);
    }
}
