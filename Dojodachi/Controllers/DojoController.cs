using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dojodachi.Controllers
{
    public class DojoController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
               
            return View("Index");            
        }

        [HttpPost]
        [Route("Feed")]
        public IActionResult Feed()
        {
            static Random random = new Random();
            int randomNumber = random.Next(5,11);
            int hasEated = randomNumber;
            return RedirectToAction("Index");
        }

        [HttpPost]
        [Route("Play")]
        public IActionResult Play()
        {
            Random random = new Random();
            int Plandom = random.Next(5,11);
            int Verb = Plandom;
            return RedirectToAction("Index");
        }

        [HttpPost]
        [Route("Work")]
        public IActionResult Work()
        {
            Random random =new Random();
            int NineToFive = random.Next();
            return RedirectToAction("Index");
        }

        
        [HttpPost]
        [Route("Sleep")]
        public IActionResult Sleep()
        {
            return View("Index");
        }       
        

    }
}