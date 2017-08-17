using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

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
        public PerformAction (string action)
        {
            GameState EditDachi = HttpContext.Session.GetObjectFromJson<GameState>("GS");
            Random RandObject = new Random();
            ViewBag.GameStatus = "running";
            switch(action)
            {
                case "feed":
                    if(EditDatchi.Meals > 0){
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

                    }
                    else
                    {
                        ViewBag.reaction = ":(";
                        ViewBag.Message = "No Food Head to Soup Kitchen";
                    }
                    break;
                case "play":
                    if(EditDachi.Energy > 4)
                    {
                        EditDachi.Energy -= 5;
                        if(RandObject.Next(0, 4) > 0)
                        {
                            EditDachi.Happiness += RandObject.Next(5, 11);
                            ViewBag.Reaction = ":)";
                            ViewBag.Message = "Fun";
                        }
                        else
                        {
                            ViewBag.Reaction = ":("
                            ViewBag.Message = "That Sucked";
                        }
                    break;
                case "work":
                    if(EditDachi.ENergy > 4)
                    {
                        EditDachi.Energy -= 5;
                        EditDachi.Meals += RandObject.Next(1, 4);
                        ViewBag.Reaction =":)";
                        ViewBag.Message = "I lift bro, do you?";
                    }
                    else
                    {
                        ViewBag.Reaction = ":(";
                        ViewBag.Message = "No work out, must eat nachos instead";
                    }
                    break;
                case "sleep":
                    EditDachi.Energy += 15;
                    EditDachi.Fullness -= 5;
                    EditDachi.Happiness -= 5;
                    ViewBag.Reaction = ":)";
                    ViewBag.Message = "Time to Catch Some ZZZ's";
                    break;
                default:
                    ViewBag.Reaction = "ABC123";
                    ViewBag.Message = "Danger Will Robinson Danger";
                    break;
                    }
                    if(EditDachi.Fullness < 1 || EditDachi.Happiness < 1)
                    {
                        ViewBag.Reaction = "X(";
                        ViewBag.Message = "I cant't Go on. Tell my Wife I LO.............";
                        ViewBag.GameStatus = "Your Dachi has Died YOu have Fail at taking care of a digital creature......";
                    }
                    else if(EditDachi.Fullness > 99 && EditDachi.Happiness > 99)
                    {
                        ViewBag.Reaction = "I HAVE THE POWER";
                        ViewBag.Message = "NExt Level";
                        EditDachi.Fullness = 20;
                        EditDachi.Happiness = 20;
                        EditDachi.Meals = 3;
                        EditDachi.Energy = 50;
                        EditDachi.Level++;
                    }
                    else if(EditDachi.Level == 6 && EditDachi.Fullness > 99 && EditDachi.Happiness > 99)
                    {
                        ViewBag.Reaction = "Whistles Go WOOT WOOT";
                        ViewBag.Message = "Victory is yours";
                        ViewBag.GameStatus = "end";
                    }
                    HttpContext.Session.SetObjectAsJson("GS", EditDachi);
                    ViewBag.GameStatus = EditDachi;
                    return View("Index");
            }
        }
        [HttpGet]
        [Route("reset")]
        public IActionResult Reset()
        {
            HttpContext.Session.Clear();
            return RedirectToActionResult("Index");
        }
        public static class SessionExtension
        {
            public static void SetObjectAsJson(this ISession session, string key, object value)
            {
                session.SetString(key JsonConvert.SerializeObject(value));
            }
            public static T GetObjecFromJson<T>(this ISession session, string key)
            {
                string value = session.GetString(key);
                return value == null ? default(T): JsonConvert.DeserializeObject<T>(value);
            }
        }
    }
