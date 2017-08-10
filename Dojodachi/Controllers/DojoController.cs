using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Dojodachi.Controllers
{
    public class DojoController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            if(HttpContext.Session.GetObjectFromJson<GameState>("GS") == null)
            {
                HttpContext.Session.SetObjectAsJson("GS)", new GameState());
            }
            ViewBag.GameState = HttpContext.Session.GetObjectFronmJson<GameState>("GS");
            ViewBag.Message = "Feed, Play, Work, or Sleep";
            ViewBag.GameStatus = "Running!";
            ViewBag.Reaction = "";

            return View();
        }
        [HttpPost]
        [Route("performAction")]
        public JsonResult (string action)
        {
            GameState EditDachi = HttpContext.Session.GetObjectFromJson<GameState>("GS");
            Random RandObject = new Random();
            ViewBag.GameStatus = "running";
            switch(action)
            {
                case "feed":
                    if(EditDatchi.Meals > 0{
                        EditDachi.Meals -= 1;
                        if(RandObject.Next(0,4) > 0)
                        {
                            EditDachi.Fullness += RandObject.Next(5, 11);
                            ViewBag.Reaction = ":)";
                            ViewBag.Message = "NOM NOM NOM";
                        }
                        else
                        {
                            ViewBag.Reaction = ">:(";
                            ViewBag.Message = "NO Megusta";
                        }
                    else
                    {
                        ViewBag.reaction = ":(;
                        ViewBag.Message = "No Food Head to Soup Kitchen";
                    }
                    })
            }
        }
        // [Route("")]
        // public IActionResult Index()
        // {
               
        //     return View("Index");            
        // }

        [HttpPost]
        [Route("Feed")]
        public IActionResult Feed()
        {
            Random random = new Random();
            int randomNumber = random.Next(5,11);
            int hasEated = randomNumber;
            return RedirectToAction("Index");
        }

        // [HttpPost]
        // [Route("Play")]
        // public IActionResult Play()
        // {
        //     Random random = new Random();
        //     int Plandom = random.Next(5,11);
        //     int Verb = Plandom;
        //     return RedirectToAction("Index");
        // }

        // [HttpPost]
        // [Route("Work")]
        // public IActionResult Work()
        // {
        //     Random random =new Random();
        //     int NineToFive = random.Next();
        //     return RedirectToAction("Index");
        // }

        
        // [HttpPost]
        // [Route("Sleep")]
        // public IActionResult Sleep()
        // {
        //     return View("Index");
        // }       
        

    }
}