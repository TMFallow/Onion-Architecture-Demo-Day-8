using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using OA.Service;
using OA.Data;
using Microsoft.AspNetCore.Http;
using Onion_Architecture.Models;

namespace Onion_Architecture.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService userService;
        private readonly IUserInfoService userInfoService;

        public UserController(IUserService userService, IUserInfoService userInfoService)
        {
            this.userService = userService;
            this.userInfoService = userInfoService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<UserViewModel> model = new List<UserViewModel>();
            userService.GetAll().ToList().ForEach(u =>
            {
                UserInfo userInfo = userInfoService.GetUserInfo(u.Id);
                UserViewModel user = new UserViewModel
                {
                    Id = u.Id,
                    Name = $"{userInfo.FirstName} {userInfo.LastName}",
                    Email = u.Email,
                    Address = userInfo.Address
                };
                model.Add(user);
            });
            return View(model);
        }
    }
}
