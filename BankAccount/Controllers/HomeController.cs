using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using BankAccount.Models;
using DbConnection;
using System.Linq;


namespace BankAccount.Controllers
{
    public class BankController : Controller
    {
        private readonly DbConnector _dbConnector;
        private BankContext _context;
        public BankController(BankContext context) => _context = context;

        [HttpGet]
        [Route(template: "Index")]
        public IActionResult Index()
        {
            List<Dictionary<string, object>> AllUsers = _dbConnector.Query("SELECT * FROM users");
        }

        public IActionResult Create
        {
            {
                User NewUser = new User
                {
                    FirstName = "Ronnie",
                    LastName = "Dobbs",
                    Email = "Ronnie@brutalizin.me",
                    password = "Password",
                };
                _context.Add(NewUser);
                _context.SaveChanges();

            }
        }

        [HttpPost]
        [Route("register")]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                User NewUser = new User
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    password = model.Password
                };
                //Handle Success
            }
            return View(model);
        }
    }
}