using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using DbConnection;

namespace QuotingDojo.Controllers
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
        public IActionResult quote()
        {
            
        }
        [HttpGet]
        [Route("Quote")]
        public IActionResult Quote()
        {
            List<Dictionary<string, object>> AllQuotes = DbConnector.Query("SELECT * FROM Quotes");
        }
    }
}
