using DotNetPokedex.Models;

namespace DotNetPokedex.Data
{
    public class PokemonRepository
    {
        private static readonly Pokemon[] _pokemons = new Pokemon[]
        {
            new Pokemon()
            {
                Id = 25,
                PokemonName = "Pikachu",
                PokemonNumber = 25,
                DescriptionHtml = "<p>This Pokémon has electricity-storing pouches on its cheeks. These appear to become electrically charged during the night while Pikachu sleeps. It occasionally discharges electricity when it is dozy after waking up. </p>",
                Stats = new Stat[]
                {
                       new Stat() { Ability = "Ability: Static", Weakness ="Weakness: Ground" },


                },
                Favorite = true

            },
            new Pokemon()
            {
                Id = 26,
                PokemonName = "Raichu",
                PokemonNumber = 26,
                DescriptionHtml = "<p>This Pokémon exudes a weak electrical charge from all over its body that makes it take on a slight glow in darkness. Raichu plants its tail in the ground to discharge electricity. </p>",
                Stats = new Stat[]
                {
                       new Stat() { Ability = "Ability: Static", Weakness ="Weakness: Ground" },


                },
                Favorite = false

            },
            new Pokemon()
            {
                Id = 27,
                PokemonName = "Sandshrew",
                PokemonNumber = 27,
                DescriptionHtml = "<p>Sandshrew has a very dry hide that is extremely tough. The Pokémon can roll into a ball that repels any attack. At night, it burrows into the desert sand to sleep. </p>",
                Stats = new Stat[]
                {
                       new Stat() { Ability = "Ability: Sand Veil", Weakness ="Weakness: Grass, Ice, Water" },


                },
                Favorite = false

            }

         };

        public Pokemon GetPokemon(int id)
        {
            Pokemon pokemonToReturn = null;

            foreach (var pokemon in _pokemons)
            {
                if (pokemon.Id == id)
                {
                    pokemonToReturn = pokemon;
                    break;
                }

            }
            return pokemonToReturn;
        }
    }
}