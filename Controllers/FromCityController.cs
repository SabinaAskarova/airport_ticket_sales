using Microsoft.AspNetCore.Mvc;
using MyProject.BLL.IServices;
using MyProject.DTOs.FromCityDTOs;
using System.Collections.Generic;

namespace MyProject.Controllers
{
    public class FromCityController : Controller
    {
        public IFromCityService _fromCityService;

        public FromCityController(IFromCityService fromCityService)
        {
            _fromCityService = fromCityService;
        }

        public IActionResult Get()
        {
            List<FromCityToListDTO> cities = _fromCityService.Get();
            return View(cities);
        }

        public IActionResult AddForm()
        {
            return View();
        }

        public IActionResult Add(FromCityToAddDTO fromCityToAddDTO)
        {
            _fromCityService.Add(fromCityToAddDTO);
            return RedirectToAction("Get");
        }

        public IActionResult UpdateForm(int fCityId)
        {
            FromCityToListDTO fCity = _fromCityService.GetById(fCityId);
            return View(fCity);
        }

        public IActionResult Update(FromCityToUpdateDTO fromCityToUpdateDTO)
        {
            FromCityToListDTO fCity = _fromCityService.Update(fromCityToUpdateDTO);
            return RedirectToAction("Get");
        }

        public IActionResult Delete(int fCityId)
        {
            _fromCityService.Delete(fCityId);
            return RedirectToAction("Get");
        }

    }
}
