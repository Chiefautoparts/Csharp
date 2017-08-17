using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace quotingDojo.Controllers
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
        [HttpPost]
        [Route("quote")]
        public IActionResult AddQoute(string Name, string Context)
        {
            String q = $"INSERT INTO quote(Name, Context) VALUES('{Name}', '{Context}')";
            DbConnector.Query(q);
            return RedirectToAction("Quotes");

        }
        [HttpGet]
        [Route("quote")]
        public IActionResult Quote()
        {
            List<Dictionary<string,object>> Quote = DbConnector.Query("SELECT * FROM quote");
            ViewBag.quotes=Quote;
            return View();
        }
    }
}
