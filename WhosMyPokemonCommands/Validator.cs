using WhosMyPokemon.Models;

namespace WhosMyPokemonCommands
{
    public class Validator : IValidator
    {
        public bool IsPokemonSelected(IPokemonModel pokemonModel)
        {
            if (string.IsNullOrEmpty(pokemonModel.Name))
            {
                return false;
            }

            return true;
        }

        public bool IsTrainerSelected(ITrainerModel trainerModel)
        {
            if (string.IsNullOrEmpty(trainerModel.Name))
            {
                return false;
            }

            return true;
        }

        public bool IsMatch(IExpectedResults ExpectedResults, ITrainerModel TrainerModel, IPokemonModel PokemonModel)
        {
            foreach (var expectedPair in ExpectedResults.ExpectedPair)
            {
                var match = expectedPair
                    .Where(pair => pair.Key.Name.Equals(TrainerModel.Name))
                    .Where(pair => pair.Value.Name.Equals(PokemonModel.Name))
                    .ToList();

                if (match.Any())
                {
                    return true;
                }
            }

            return false;
            
        }

        public void ResetSelectedTrainer(ITrainerModel selectedTrainer)
        {
            selectedTrainer.Name = string.Empty;
        }

        public void ResetSelectedPokemon(IPokemonModel selectedPokemon)
        {
            selectedPokemon.Name = string.Empty;
        }
    }
}
