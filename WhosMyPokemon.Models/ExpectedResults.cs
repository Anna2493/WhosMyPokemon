namespace WhosMyPokemon.Models
{
    public class ExpectedResults : IExpectedResults
    {
        public IEnumerable<IDictionary<ITrainerModel, IPokemonModel>> ExpectedPair { get; set; }
    }
}
