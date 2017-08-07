using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace firstASP.controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        [Route("index")]
        public string Index()
        {
            return "Hello World";
        }

        [HttpGet]
        [Route("displayint")]
        public JsonResult DisplayInt()
        {
            var AnonObject = new {
                                FirstName = "Raz",
                                LastName = "Aquato",
                                Age = 10
                            };
            return Json(AnonObject);
        }

        [HttpGet]
        [Route("dispayhuman")]
        public JsonResult DisplayHuman()
        {
            return Json(new Human());
        }
        [HttpPost]
        [Route("")]
        public IActionResult Other()
        {

        }
    }
}