using Microsoft.AspNetCore.Mvc;
using MyProject.BLL.IServices;
using MyProject.DTOs.FlightDTOs;
using MyProject.DTOs.FromCityDTOs;
using MyProject.DTOs.TicketDTOs;
using MyProject.DTOs.ToCityDTOs;
using MyProject.Models;
using System;
using System.Collections.Generic;

namespace MyProject.Controllers
{
    public class TicketController : Controller
    {
        private readonly ITicketService _ticketService;
        private readonly IFlightService _flightService;
        private readonly IFromCityService _fromCityService;
        private readonly IToCityService _iToCityService;

        public TicketController(ITicketService ticketService,IFlightService flightService, IFromCityService fromCityService, IToCityService toCityService)
        {
            _ticketService = ticketService;
            _flightService = flightService;
            _fromCityService = fromCityService;
            _iToCityService = toCityService;
        }

        public IActionResult Get()
        {
            List<TicketToListDTO> tickets = _ticketService.Get();
            return View(tickets);
        }

        public IActionResult AddForm(int flightId)
        {
            FlightToListDTO flight = _flightService.GetById(flightId);
            return View(flight);
        }

        public IActionResult Add(int flightId,string nameSurname,string fromCityName,string toCityName,int caricount, int  number,int price, DateTime datetime,int seatnumber)
        {
            if (caricount == 0 )
            {
                return BadRequest("bilet qutarib!!!");
            }
            else if (number>caricount)
            {
                return BadRequest("bu sayda bilet qalmayib!");
            }
            else {
                TicketToAddDTO ticketToAddDTO = new TicketToAddDTO()
                {
                    NameSurname = nameSurname,
                    FromCityName = fromCityName,
                    ToCityName = toCityName,
                    Datetime = datetime,
                    SeatNumber = seatnumber,
                    Price = price
                };
                _ticketService.Add(ticketToAddDTO);
                FlightToListDTO flightToListDTO = _flightService.GetById(flightId);
                FromCity fromCity = new FromCity()
                {
                    FCityId = flightToListDTO.FromCity.FCityId,
                    FCityName = flightToListDTO.FromCity.FCityName
                };

                ToCity toCity = new ToCity()
                {
                    TCityId = flightToListDTO.ToCity.TCityId,
                    TCityName = flightToListDTO.ToCity.TCityName
                };
                flightToListDTO.CariCount = flightToListDTO.CariCount - 1;
                List<int> seats = flightToListDTO.Seats;
                foreach (var item in seats)
                {
                    if(item== seatnumber)
                    {
                        seats.Remove(item);
                        break;
                    }
                }
                FlightToUpdateDTO flightToUpdateDTO = new FlightToUpdateDTO() {
                    FlightId = flightToListDTO.FlightId,
                    FCityId = flightToListDTO.FCityId,
                    FromCity = fromCity,
                    TCityId = flightToListDTO.TCityId,
                    ToCity = toCity,
                    CariCount = flightToListDTO.CariCount,
                    Price = flightToListDTO.Price,
                    Time = flightToListDTO.Time,
                    Seats = seats,
                    TotalCount = flightToListDTO.TotalCount
                };
                _flightService.Update(flightToUpdateDTO);
                return RedirectToAction("Get");
            }
        }

        public IActionResult Show(int ticketId)
        {
            TicketToListDTO ticketToListDTO = _ticketService.GetById(ticketId);
            return View(ticketToListDTO);
        }
    }
}
