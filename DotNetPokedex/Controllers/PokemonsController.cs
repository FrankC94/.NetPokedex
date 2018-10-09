using DotNetPokedex.Data;
using System.Web.Mvc;

namespace DotNetPokedex.Controllers
{
    public class PokemonsController : Controller
    {
        private PokemonRepository _pokemonRepository = null;

        public PokemonsController()
        {
            _pokemonRepository = new PokemonRepository();
        }

        public ActionResult Index()
        {
            var pokemons = _pokemonRepository.GetPokemons();

            return View(pokemons);
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            var pokemon = _pokemonRepository.GetPokemon((int)id);

            return View(pokemon);

        }
    }
}