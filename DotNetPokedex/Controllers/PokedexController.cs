using System;
using System.Web.Mvc;

namespace DotNetPokedex.Controllers
{
    public class PokedexController : Controller
    {
        public ActionResult Detail()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Friday)
            {
                return Redirect("/");
                
            }
            return Content("Hello from the Pokedex Controller");
           
        }
    }
}