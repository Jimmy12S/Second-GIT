using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebTrial.Models;

namespace WebTrial.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            var UserA = new User
            {
                Id = "sdfsdfsdf",
                FirstName = "john",
                LastName = "smith",
                JobRole = "Manager"

            };

            var userList = new List<User>();
            userList.Add(UserA);

            return View(userList);
        }
    }
}