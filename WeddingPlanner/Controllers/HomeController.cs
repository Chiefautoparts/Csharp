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
        public HomeController(WeddingContext context) => _context = context;

    
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [Route("Register")]
        public IActionResult Register()
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
                
            }
            else
            {
                return View("Index", model);
            }
        }
    }
}
