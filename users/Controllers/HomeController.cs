using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace users.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Method(string Name, string Email, string Password)
        {
            User NewUser = new User
            {
                Name = Name,
                Email = Email,
                Password = Password
            };
            TryValidateModel(NewUser);
            ViewBag.errors = ModelState.Values;
            return View();
        }
    }
}
