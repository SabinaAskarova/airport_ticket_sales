using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.BLL.IServices;
using MyProject.Core.Validations;
using MyProject.DTOs.UserDTOs;
using System.Collections.Generic;

namespace MyProject.Controllers
{
    public class UserController : Controller
    {
       
        public IUserService _userService;
 
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(UserToAddDTO userToAddDTO)
        {
            int security = 12345;

            ///*UserValidator*/ userValidator = new UserValidator();
            //ValidationResult validationResult = userValidator.Validate(userToAddDTO);
            if (ModelState.IsValid)
            {
                List<UserToListDTO> users = _userService.Get();
                foreach (UserToListDTO user in users)
                {
                    if (user.UserName == userToAddDTO.UserName && user.Password == userToAddDTO.Password)
                    {
                        if (security == user.SecurityCode)
                        {
                            TempData["SecurityCode"] = security;
                            return RedirectToAction("SaleTicket", "Flight");
                        }
                        else
                        {
                            TempData["SecurityCode"] = null;
                            return RedirectToAction("SaleTicket", "Flight");

                        }
                    }
                }
            }
            //else
            //{
            //    foreach (var item in validationResult.Errors)
            //    {
            //        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            //    }
            //    return View("Index");
            //}
            return View("Index",userToAddDTO);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Registr(UserToAddDTO userToAddDTO)
        {
            //UserValidator userValidator = new UserValidator();
            //ValidationResult validationResult = userValidator.Validate(userToAddDTO);
            if (ModelState.IsValid)
            {
                _userService.Add(userToAddDTO);
                                   
            }
            //else
            //{
            //    foreach (var item in validationResult.Errors)
            //    {
            //        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            //    }
            //    return View("Index");
            //}
            return View("Index", userToAddDTO);
        }

        public IActionResult Get()
        {
            List<UserToListDTO> users = _userService.Get();
            return View(users);
        }

        public IActionResult UpdateForm(int userId)
        {
            UserToListDTO user = _userService.GetById(userId);
            return View(user);
        }

        public IActionResult Update(UserToUpdateDTO userToUpdateDTO)
        {
           UserToListDTO user = _userService.Update(userToUpdateDTO);
            return RedirectToAction("Get");
        }

        public IActionResult Delete(int userId)
        {
            _userService.Delete(userId);
            return RedirectToAction("Get");
        }
    }
}


