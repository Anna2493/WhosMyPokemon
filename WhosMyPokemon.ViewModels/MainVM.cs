using WhosMyPokemon.Models;

namespace WhosMyPokemon.ViewModels
{
    public class MainVM
    {
        public ViewModelBase pairSelectorVM { get; set; }
        public ViewModelBase makeMatchVM { get; set; }

        public MainVM(TrainerModel trainerModel, PokemonModel pokemonModel)
        {
            var expectedResults = CreateExpectedResults();
            pairSelectorVM = new PairSelectorVM(trainerModel, pokemonModel);

            makeMatchVM = new MakeMatchVM(trainerModel, pokemonModel, expectedResults);

        }

        public IExpectedResults CreateExpectedResults()
        {
            var ExpectedResults = new ExpectedResults();
            ExpectedResults.ExpectedPair = new List<IDictionary<ITrainerModel, IPokemonModel>>()
            {
                new Dictionary<ITrainerModel, IPokemonModel>(){ { new TrainerModel() { Name = "Ash" }, new PokemonModel() { Name = "Pikachu" } } },
                new Dictionary<ITrainerModel, IPokemonModel>(){ { new TrainerModel() { Name = "Misty" }, new PokemonModel() { Name = "Togepi" } } },
                new Dictionary<ITrainerModel, IPokemonModel>(){ { new TrainerModel() { Name = "Brock" }, new PokemonModel() { Name = "Geodude" } } }

            };

            return ExpectedResults;
        }
    }
}
