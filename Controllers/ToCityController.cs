using Microsoft.AspNetCore.Mvc;
using MyProject.BLL.IServices;
using MyProject.DTOs.ToCityDTOs;
using System.Collections.Generic;

namespace MyProject.Controllers
{
    public class ToCityController : Controller
    {
        public IToCityService _toCityService;

        public ToCityController(IToCityService toCityService)
        {
            _toCityService = toCityService;
        }

        public IActionResult Get()
        {
            List<ToCityToListDTO> cities = _toCityService.Get();
            return View(cities);
        }

        public IActionResult Add(ToCityAddDTO toCityAddDTO)
        {
            if (ModelState.IsValid)
            {
                _toCityService.Add(toCityAddDTO);
                return RedirectToAction("Get");
            }
            return View("AddForm",toCityAddDTO);
            
        }

        public IActionResult AddForm()
        {
            return View();
        }

        public IActionResult UpdateForm(int tCityId)
        {
            if (ModelState.IsValid)
            {
                ToCityToListDTO tCity = _toCityService.GetById(tCityId);
                return View(tCity);
            }
            return View("UpdateForm");
        }

        public IActionResult Update(ToCityToUpdateDTO toCityToUpdateDTO)
        {
            ToCityToListDTO fCity = _toCityService.Update(toCityToUpdateDTO);
            return RedirectToAction("Get");
        }

        public IActionResult Delete(int tCityId)
        {
            _toCityService.Delete(tCityId);
            return RedirectToAction("Get");
        }

    }
}
