using WhosMyPokemon.Models;
using WhosMyPokemonCommands;

namespace WhosMyPokemon.Tests
{
    public class ValidatorTests
    {
        private readonly IValidator sut = new Validator();

        [Fact]
        public void Validator_PokemonWithValidName_ReturnsTrue()
        {
            var pokemonModel = new PokemonModel();
            pokemonModel.Name = "Test";

            var pokemonHasName = sut.IsPokemonSelected(pokemonModel);

            Assert.True(pokemonHasName);
        }

        [Fact]
        public void Validator_PokemonWithEmptyName_ReturnsFalse()
        {
            var pokemonModel = new PokemonModel();
            pokemonModel.Name = "";

            var pokemonHasName = sut.IsPokemonSelected(pokemonModel);

            Assert.False(pokemonHasName);
        }

        [Fact]
        public void Validator_TrainerWithValidName_ReturnsTrue()
        {
            var trainerModel = new TrainerModel();
            trainerModel.Name = "Test";

            var trainerHasName = sut.IsTrainerSelected(trainerModel);

            Assert.True(trainerHasName);
        }

        [Fact]
        public void Validator_TrainerWithEmptyName_ReturnsFalse()
        {
            var trainerModel = new TrainerModel();
            trainerModel.Name = "";

            var trainerHasName = sut.IsTrainerSelected(trainerModel);

            Assert.False(trainerHasName);
        }

        [Fact]
        public void Validator_IsMatchWithValidData_ReturnsTrue()
        {
            var expectedResults = new ExpectedResults();
            expectedResults.ExpectedPair = new List<IDictionary<ITrainerModel, IPokemonModel>>()
            {
                new Dictionary<ITrainerModel, IPokemonModel>(){ { new TrainerModel() { Name = "TestTrainer" }, new PokemonModel() { Name = "TestPokemon" } } }
            };

            var trainerModel = new TrainerModel();
            trainerModel.Name = "TestTrainer";

            var pokemonModel = new PokemonModel();
            pokemonModel.Name = "TestPokemon";

            var isMatch = sut.IsMatch(expectedResults, trainerModel, pokemonModel);

            Assert.True(isMatch);
        }

        [Fact]
        public void Validator_IsMatchWithInvalidTrainer_ReturnsFalse()
        {
            var expectedResults = new ExpectedResults();
            expectedResults.ExpectedPair = new List<IDictionary<ITrainerModel, IPokemonModel>>()
            {
                new Dictionary<ITrainerModel, IPokemonModel>(){ { new TrainerModel() { Name = "TestTrainer" }, new PokemonModel() { Name = "TestPokemon" } } }
            };

            var trainerModel = new TrainerModel();
            trainerModel.Name = "InvalidTrainer";

            var pokemonModel = new PokemonModel();
            pokemonModel.Name = "TestPokemon";

            var isMatch = sut.IsMatch(expectedResults, trainerModel, pokemonModel);

            Assert.False(isMatch);
        }

        [Fact]
        public void Validator_IsMatchWithInvalidPokemon_ReturnsFalse()
        {
            var expectedResults = new ExpectedResults();
            expectedResults.ExpectedPair = new List<IDictionary<ITrainerModel, IPokemonModel>>()
            {
                new Dictionary<ITrainerModel, IPokemonModel>(){ { new TrainerModel() { Name = "TestTrainer" }, new PokemonModel() { Name = "TestPokemon" } } }
            };

            var trainerModel = new TrainerModel();
            trainerModel.Name = "TestTrainer";

            var pokemonModel = new PokemonModel();
            pokemonModel.Name = "InvalidPokemon";

            var isMatch = sut.IsMatch(expectedResults, trainerModel, pokemonModel);

            Assert.False(isMatch);
        }

        [Fact]
        public void Validator_IsMatchWithInvalidData_ReturnsFalse()
        {
            var expectedResults = new ExpectedResults();
            expectedResults.ExpectedPair = new List<IDictionary<ITrainerModel, IPokemonModel>>()
            {
                new Dictionary<ITrainerModel, IPokemonModel>(){ { new TrainerModel() { Name = "TestTrainer" }, new PokemonModel() { Name = "TestPokemon" } } }
            };

            var trainerModel = new TrainerModel();
            trainerModel.Name = "InvalidTrainer";

            var pokemonModel = new PokemonModel();
            pokemonModel.Name = "InvalidPokemon";

            var isMatch = sut.IsMatch(expectedResults, trainerModel, pokemonModel);

            Assert.False(isMatch);
        }
    }
}