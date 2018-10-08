using DotNetPokedex.Models;
using System.Web.Mvc;

namespace DotNetPokedex.Controllers
{
    public class PokedexController : Controller
    {
        public string PokemonName { get; private set; }

        public ActionResult Detail()
        {
            var pokemon = new Pokemon()
            {
                PokemonName = "Pikachu",
                PokemonNumber = 25,
                DescriptionHtml = "<p>Pikachu is a short, chubby rodent Pokémon. It is covered in yellow fur with two horizontal brown stripes on its back. It has a small mouth, long, pointed ears with black tips, brown eyes, and the two red circles on its cheeks contain pouches for electricity storage. </p>",
                Stats = new Stat[]
                {
                       new Stat() { Ability = "Ability: Stattic", Weakness ="Weakness: Ground" },


                }

            };





            return View(pokemon);

        }
    }
}