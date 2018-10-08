namespace DotNetPokedex.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string PokemonName { get; set; }
        public int PokemonNumber { get; set; }
        public string DescriptionHtml { get; set; }
        public ElementType[] ElementType { get; set; }
        public bool Favorite { get; set; }
    }
}