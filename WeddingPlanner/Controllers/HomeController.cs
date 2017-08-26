using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using WeddingPlanner.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace WeddingPlanner.Controllers
{
    public class HomeController : Controller
    {
        private WeddingContext _context;
        public HomeController(WeddingContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [Route("Register")]
        public IActionResult Register(User newUser)
        {
            if (ModelState.IsValid)
            {
                User UserExists = _context.Users.SingleOrDefault(user => user.Email == model.Email);
                if (UserExists != null)
                {
                    ViewBag.Message = "Email already Registered";
                    return View("Index", wedding);
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                User NewUser = new User
                {
                    FirstName = newUser.FirstName,
                    LastName = newUser.LastName,
                    Email = newUser.Email,
                    Password = newUser.Password,
                    CreatedAt = DateTime.Now,
                };
                NewUser.Password = Hasher.HashPassword(NewUser, NewUser.Password);
                _context.Add(NewUser);
                _context.SaveChanges();
                NewUser = _context.Users.SingleOrDefault(user => user.Email == NewUser.Email);
                HttpContext.Session.SetInt32("userID", NewUser.UserID);
                return View("Index");

            }
            else
            {
                return View("Index");
            }
        }

        private IActionResult View(string v, object wedding)
        {
            throw new NotImplementedException();
        }
    }
}
