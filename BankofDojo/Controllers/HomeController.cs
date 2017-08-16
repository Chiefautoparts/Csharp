using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using BankofDojo.Models;
using System.Linq;

namespace BankofDojo.Controllers
{
    public class HomeController : Controller
    {
        private AccountContext _context;
        public HomeController(AccountContext context)
        {
            _context = context;
        }

        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            User NewUser = new User{
                FirstName = "Ronwell",
                LastName = "Dobbs",
                Email = "R.Dobbs@yallbrutalizin.me",
                Password = "password"
            };
        }
        [HttpPost]
        [Route("register")]
        public IActionResult Register(RegisterViewModel model)
        {
            if(ModelState.IsValid)
            {
                User NewUser = new user
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    Password = model.Password
                };
                // Succes
            }
            return View(model);
        }
    }
}
