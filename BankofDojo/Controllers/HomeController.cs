using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using BankofDojo.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

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
        [HttpGet]
        [Route("login")]
        public IActionResult loginPage()
        {
            return View("login");
        }

        [HttpPost]
        [Route("Login")]
        public IActionResult Login(string ValidEmail, string ValidPassword)
        {
            var Hasher = new PasswordHasher<User>();
            User ValidUser = _context.Users.SingleOrDefault(user => user.Email == ValidEmail);
            if (ValidUser == null || 0 == Hasher.VerifyHashedPassword(ValidUser, ValidUser.Password, ValidPassword))
            {
                ViewBag.Message = "Failed to Login";
                return View("Index");
            }
            else
            {
                HttpContext.Session.SetInt32("userID", ValidUser.userID);
                return RedirectToAction("Show", "Account", new { TransactionNum = HttpContext.Session.GetInt32("userID")});
            }
        }
        [HttpPost]
        [Route("Register")]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                User UserExists = _context.Users.SingleOrDefault(user => user.Email == model.Email);
                if (UserExists != null)
                {
                    ViewBag.Message = "Email already Registered";
                    return View("Index", model);
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                User NewUser = new User
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    Password = model.Password,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                };
                NewUser.Password = Hasher.HashPassword(NewUser, NewUser.Password);
                _context.Add(NewUser);
                _context.SaveChanges();
                NewUser = _context.Users.SingleOrDefault(user => user.Email == NewUser.Email);
                HttpContext.Session.SetInt32("userID", NewUser.userID);
                return RedirectToAction("Show", "Account", new { TransactionNum = HttpContext.Session.GetInt32("userID")});
            }
            else
            {
                return View("Index", model);
            }
        }
        [HttpGet]
        [Route("logoff")]
        public IActionResult Logoff()
        {
            HttpContext.Session.Clear();
            return View("Index");
        }
    }
}