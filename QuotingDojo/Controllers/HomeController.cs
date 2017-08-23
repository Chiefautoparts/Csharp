using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Net.Http;
using DbConnection;

namespace QuotingDojo.Controllers
{
    public class HomeController : Controller
    {
        private readonly DbConnector _dbConnector;
        public HomeController(DbConnector connect)
        {
            _dbConnector = connect;
        }
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            List<Dictionary<string, object>> AllQuotes = DbConnector.Query("SELECT * FROM Quotes");
            return View();
        }

        [HttpPost]
        [Route("quote")]
        public IActionResult quotes(string name, string content)
        {
            string query = $"INSERT INTO quote (name, content, CreatedAt, UpdatedAt) VALUES (\"{name}\", \"{content}\", NOW(), NOW()";
            DbConnector.Execute(query);
            return RedirectToAction("Quotes");
        }
        [HttpGet]
        [Route("Quote")]
        public IActionResult Quote()
        {
            List<Dictionary<string, object>> AllQuotes = DbConnector.Query("SELECT * FROM Quotes");
            ViewBag.allQuotes = AllQuotes;
            return View();
        }
    }
}
