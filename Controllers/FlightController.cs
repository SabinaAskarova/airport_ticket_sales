using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyProject.BLL.IServices;
using MyProject.DTOs.FlightDTOs;
using MyProject.DTOs.FromCityDTOs;
using MyProject.DTOs.ToCityDTOs;
using MyProject.Models;
using System.Collections.Generic;

namespace MyProject.Controllers
{
    public class FlightController : Controller
    {
        private readonly IFlightService _flightService;
        private readonly IFromCityService _fromCityService;
        private readonly IToCityService _iToCityService;

        public FlightController(IFlightService flightService, IFromCityService fromCityService, IToCityService toCityService)
        {
            _flightService = flightService;
            _fromCityService = fromCityService;
            _iToCityService = toCityService;
        }
        
        public IActionResult Get()
        {
            return View(_flightService.Get());
        }

        public IActionResult AddForm()
        {

            ViewBag.FromCities = new SelectList(_fromCityService.Get(), "FCityId", "FCityName");
            ViewBag.ToCities = new SelectList(_iToCityService.Get(), "TCityId", "TCityName");

            return View();
        }

        public IActionResult Add(FlightToAddDTO flightToAddDTO)
        {
            if (flightToAddDTO.FlightId == null)
            {
                flightToAddDTO.TotalCount = flightToAddDTO.CariCount;
                _flightService.Add(flightToAddDTO);
            }
            else
            {
                //List<int> seats=flightToAddDTO.
                FlightToUpdateDTO flightToUpdateDTO = new FlightToUpdateDTO()
                {
                    FlightId = flightToAddDTO.FlightId,
                    FCityId = flightToAddDTO.FCityId,
                    TCityId = flightToAddDTO.TCityId,
                    CariCount = flightToAddDTO.CariCount,
                    Price = flightToAddDTO.Price,
                    Time = flightToAddDTO.Time,
                    TotalCount = flightToAddDTO.TotalCount

                };
                
                _flightService.Update(flightToUpdateDTO);
            }
            return RedirectToAction("Get");
        }

        public IActionResult Update(int flightId)
        {
            ViewBag.FromCities = new SelectList(_fromCityService.Get(), "FCityId", "FCityName");
            ViewBag.ToCities = new SelectList(_iToCityService.Get(), "TCityId", "TCityName");

            FlightToListDTO flightToListDTO = _flightService.GetById(flightId);
            return View("AddForm", flightToListDTO);    
        }

        public IActionResult Delete(int flightId)
        {
            _flightService.Delete(flightId);
            return RedirectToAction("Get");
        }

        public IActionResult SaleTicket()
        {

            //List<FromCityToListDTO> fromCities = _fromCityService.Get();
            //List<ToCityToListDTO> toCities = _iToCityService.Get();

            //ViewBag.FromCities = fromCities;
            //ViewBag.ToCities = toCities;

            ViewBag.FromCities = new SelectList(_fromCityService.Get(), "FCityId", "FCityName");
            ViewBag.ToCities = new SelectList(_iToCityService.Get(), "TCityId", "TCityName");

            return View();
        }

        public IActionResult FindTicket(int fId,int tId)
        {

            List<FlightToListDTO> flightToListDTO = _flightService.Get();
            List<FlightToListDTO> flights = new List<FlightToListDTO>();

            FromCityToListDTO fromCity = _fromCityService.GetById(fId);
            ToCityToListDTO toCity = _iToCityService.GetById(tId);

            if (fromCity == null || toCity == null)
            {
                return BadRequest("bele uchush yoxdur!");

            }
            else
            {
                foreach (FlightToListDTO flight in flightToListDTO)
                {
                    if (flight.FromCity.FCityName == fromCity.FCityName && flight.ToCity.TCityName == toCity.TCityName)
                    {
                        flights.Add(flight);
                    }
                }
            }
            return View(flights);
        }
    }
}
