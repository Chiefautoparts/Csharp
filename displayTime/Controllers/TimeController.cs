using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace displayTime
{
    public class TimeController : Controller
    {
        [HttpGet]
        [Route("index")]
        public IActionResult index()
        {
            return View();
        }
    }
}