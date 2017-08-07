using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CallingCard
{
    public class CallingController : Controller
    {
        [HttpGet]
        [Route("card/{FirstName}/{LastName}/{Age}/{FavoriteColor}")]
        public JsonResult CallCard(string FirstName, string LastName, int Age, string FavoriteColor)
        {
            return Json(new {FirstName = FirstName, LastName = LastName, Age = Age, FavoriteColor = FavoriteColor});
        }
    
    }
}