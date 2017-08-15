using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using FormSubmit.Models;

namespace FormSubmit.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.Errors = new List<string>();
            return View();
        }
        [HttpPost]
        [Route("/dashboard")]
        public IActionResult dashboard()
        {
            return View("dashboard");
        }

        [HttpPost]
        [Route("register")]
        public IActionResult ValidateUser(string firstname, string lastname, int age, string email, string password)
        {
            Console.WriteLine("FirstName = " + firstname);
            Console.WriteLine("LastName = " + lastname);
            Console.WriteLine("Age = " + age);
            Console.WriteLine("Email = " + email);
            Console.WriteLine("Password = " + password);

            

        }
    }
}
