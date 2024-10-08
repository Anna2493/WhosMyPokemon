

using WhosMyPokemon.Models;

namespace WhosMyPokemonCommands
{
    public class MakeMatchCommand : CommandBase
    {
        private readonly ITrainerModel TrainerModel;
        private readonly IPokemonModel PokemonModel;
        private readonly IEventsManager EventsManager;
        private readonly IExpectedResults ExpectedResults;

        public MakeMatchCommand(ITrainerModel trainerModel, IPokemonModel pokemonModel,
            IEventsManager eventsManager, IExpectedResults expectedResults)
        {
            TrainerModel = trainerModel;
            PokemonModel = pokemonModel;
            EventsManager = eventsManager;
            ExpectedResults = expectedResults;
        }

        public override void Execute(object parameter)
        {
            var isPokemonSelected = IsPokemonSelected(PokemonModel);
            var isTrainerSelected = IsTrainerSelected(TrainerModel);

            if (!isTrainerSelected)
            {
                EventsManager.RaiseMissingSelectionEvent();
                ResetSelectedPokemon(PokemonModel);
                return;
            }
            else if (!isPokemonSelected)
            {
                EventsManager.RaiseMissingSelectionEvent();
                ResetSelectedTrainer(TrainerModel);
                return;
            }

            var isMatch = IsMatch(ExpectedResults, TrainerModel, PokemonModel);

            if(isMatch)
            {
                EventsManager.RaiseCorrectEvent();
                ResetSelectedTrainer(TrainerModel);
                ResetSelectedPokemon(PokemonModel);
            }
            else
            {
                EventsManager.RaiseTryAgainEvent();
                ResetSelectedTrainer(TrainerModel);
                ResetSelectedPokemon(PokemonModel);
            }

        }

    }
}
