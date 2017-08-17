using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using users.Models;

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
       public IActionResult Register(RegisterViewModel model)
        {
            if(ModelState.IsValid)
            {
                User NewUser = new users
                {
                    Name = model.Name,
                    Email = model.Email,
                    Password = model.Password
                };
            }
            return View(model);
        }
        [HttpPost]
        [Route("blog")]
        public IActionResult Blog()
        {
            List<Post> Posts = _context.Posts.INclude(Post => Post.Blog).ToList();
        }
    }
}
