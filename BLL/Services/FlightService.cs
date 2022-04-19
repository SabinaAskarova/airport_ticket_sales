using AutoMapper;
using MyProject.BLL.IServices;
using MyProject.DAL.IRepositories;
using MyProject.DTOs.FlightDTOs;
using MyProject.Models;
using System.Collections.Generic;

namespace MyProject.BLL.Services
{
    public class FlightService: IFlightService
    {
        private readonly IFlightRepository _flightRepository;
        private readonly IMapper _mapper;
        public FlightService(IFlightRepository flightRepository, IMapper mapper)
        {
            _flightRepository = flightRepository;
            _mapper = mapper;
        }

        public FlightToListDTO Add(FlightToAddDTO flightToAddDTO)
        {
            Flight flight = _mapper.Map<Flight>(flightToAddDTO);
         
            Flight addedflight = _flightRepository.Add(flight);
            return _mapper.Map<FlightToListDTO>(addedflight);
        }

        public void Delete(int flightId)
        {
            _flightRepository.Delete(flightId);
        }

        public List<FlightToListDTO> Get()
        {
            return _mapper.Map<List<FlightToListDTO>>(_flightRepository.Get());
        }

        public FlightToListDTO GetById(int flightId)
        {
            Flight flight = _flightRepository.GetById(flightId);
            return _mapper.Map<FlightToListDTO>(flight);
        }

        public FlightToListDTO Update(FlightToUpdateDTO flightToUpdateDTO)
        {
            Flight flight = _mapper.Map<Flight>(flightToUpdateDTO);
            Flight updatedflight = _flightRepository.Update(flight);
            return _mapper.Map<FlightToListDTO>(updatedflight);
        }
    }
}
