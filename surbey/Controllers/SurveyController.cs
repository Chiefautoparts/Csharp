using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace surbey.Controllers
{
    public class SurveyController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View("Index");
        }

    }
}