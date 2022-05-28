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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(FromCityToAddDTO fromCityToAddDTO)
        {
            if (ModelState.IsValid)
            {
                _fromCityService.Add(fromCityToAddDTO);
                return RedirectToAction("Get");
            }
            return View("AddForm",fromCityToAddDTO);
        }

        public IActionResult UpdateForm(int fCityId)
        {
            if (ModelState.IsValid)
            {
                FromCityToListDTO fCity = _fromCityService.GetById(fCityId);
                return View(fCity);
            }
            return View("UpdateForm");
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
