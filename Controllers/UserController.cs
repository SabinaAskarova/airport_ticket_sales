using FluentValidation.Results;
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

        public IActionResult Login(UserToAddDTO userToAddDTO)
        {
            UserValidator userValidator = new UserValidator();
            ValidationResult validationResult = userValidator.Validate(userToAddDTO);
            if (validationResult.IsValid)
            {
                List<UserToListDTO> users = _userService.Get();
                foreach (UserToListDTO user in users)
                {
                    if (user.UserName == userToAddDTO.UserName && user.Password == userToAddDTO.Password)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View("Index");
            }
            return RedirectToAction("Login");
        }

        public IActionResult Registr(UserToAddDTO userToAddDTO)
        {
            UserValidator userValidator = new UserValidator();
            ValidationResult validationResult = userValidator.Validate(userToAddDTO);
            if (validationResult.IsValid)
            {
                List<UserToListDTO> users = _userService.Get();

                foreach (UserToListDTO user in users)
                {
                    if (user.UserName == userToAddDTO.UserName && user.Password == userToAddDTO.Password)
                    {
                        return View("Index");
                    }

                    else
                    {
                        _userService.Add(userToAddDTO);
                        break;
                    }
                }
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View("Index");
            }
            return RedirectToAction("Index");
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


