using System.Web.Mvc;

namespace DotNetPokedex.Controllers
{
    public class PokedexController : Controller
    {
        public ActionResult Detail()
        {
            ViewBag.PokemonName = "Pikachu";
            ViewBag.PokemonNumber = 25;
            ViewBag.Description = "<p>Pikachu is a short, chubby rodent Pokémon. It is covered in yellow fur with two horizontal brown stripes on its back. It has a small mouth, long, pointed ears with black tips, brown eyes, and the two red circles on its cheeks contain pouches for electricity storage. </p>";
            ViewBag.Details = new string[]
                {
                    "Category: Mouse",
                    "Type: Electric",
                    "Ability: Stattic",
                    "Weakness: Ground",
                    "Evolves from: Pichu",
                    "Evolves to: Raichu"
                };
            return View();

        }
    }
}