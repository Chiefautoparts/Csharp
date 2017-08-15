using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using quotesPRAC.Models;
using System.Collections.Generic;
using System.Linq;

namespace quotesPRAC.Controllers
{
    public class QuotesController : Controller
    {
        private QuotesContext _context;
        public QuotesController(QuotesContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            List<quote>qoutes = _context.Quotes.ToList();
        }

    }
}