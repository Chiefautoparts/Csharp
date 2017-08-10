using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Dojodachi.Controllers
{
    public class DojConttroller : Controller
    {
        public void 
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.message = ;
            ViewBag.DachiStatus = '';

        }

        [HttpPost]
        [Route("DachiMaker")]
        public IactionResut DachiMaker(string name);
        {
            int full = 20;

        }
        [HttpPost]
        [Route("Feed")]
        public IActionResult()
        {
            
        }
    }
}

