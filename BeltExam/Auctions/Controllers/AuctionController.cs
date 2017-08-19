using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Auctions.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Auctions.Controllers
{
    public class AuctionController : Controller
    {
        // GET: /Home/
        private AuctionsContext _context;
        public AuctionController(AuctionsContext context)
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
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                User UserValid = _context.Users.SingleOrDefault(User => User.Username == model.Username);
                if (UserValid != null)
                {
                    ViewBag.Message = "Username is already registered";
                    return View("Index", model);
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                User NewUser = new User
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Username = model.Username,
                    Password = model.Password,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                };
                NewUser.Password = Hasher.HashPassword(NewUser, NewUser.Password);
                _context.Add(NewUser);
                _context.SaveChanges();
                NewUser = _context.Users.SingleOrDefault(User => User.Username == NewUser.Username);
                HttpContext.Session.SetInt32("UserId", NewUser.UserId);
                return RedirectToAction("Auction", "Current", new { ItemNum = HttpContext.Session.GetInt32("UserId")});
            }
            else
            {
                return View("Auction", model);
            }
        }        
        [HttpGet]
        [Route("login")]
        public IActionResult loginPage()
        {
            return View("login");
        }
        [HttpPost]
        [Route("Login")]
        public IActionResult Login(string ValidName, string ValidPass)
        {
            var Hasher = new PasswordHasher<User>();
            User ValidUser = _context.Users.SingleOrDefault(User => User.Username == ValidName);
            if (ValidUser == null || 0 == Hasher.VerifyHashedPassword(ValidUser, ValidUser.Password, ValidPass))
            {
                ViewBag.Message = "Login has FAILED";
                return View("Index");
            }
            else
            {
                HttpContext.Session.SetInt32("UserId", ValidUser.UserId);
                return RedirectToAction("Current", "Auction", new { ItemNum = HttpContext.Session.GetInt32("UserId")});
            }
        }
    }
}
