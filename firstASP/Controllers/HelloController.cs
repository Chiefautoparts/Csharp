using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace firstASP.controllers
{
    public class HelloController : Controller
    {
       [HttpGet]
       [Route("")]
       public IActionResult Index()
       {
           return View("Index");
       }
    }
}