using WhosMyPokemon.Models;

namespace WhosMyPokemonCommands
{
    public interface IValidator
    {
        bool IsPokemonSelected(IPokemonModel pokemonModel);
        bool IsTrainerSelected(ITrainerModel trainerModel);
        void ResetSelectedTrainer(ITrainerModel selectedTrainer);
        void ResetSelectedPokemon(IPokemonModel selectedPokemon);
        bool IsMatch(IExpectedResults ExpectedResults, ITrainerModel TrainerModel, IPokemonModel PokemonModel);
    }
}
