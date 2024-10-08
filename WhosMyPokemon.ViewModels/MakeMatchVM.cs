using System.Windows.Input;
using WhosMyPokemon.Models;
using WhosMyPokemonCommands;

namespace WhosMyPokemon.ViewModels
{
    public class MakeMatchVM : ViewModelBase
    {
        public MakeMatchVM(ITrainerModel trainerModel, IPokemonModel pokemonModel,
            IExpectedResults ExpectedResults)
        {
            EventsManager = new EventsManager();
            RegisterEventHandlers();
            MakeMatch = new MakeMatchCommand(trainerModel, pokemonModel, EventsManager, ExpectedResults);
        }

        private void RegisterEventHandlers()
        {
            EventsManager.MatchIsCorrectSetter += MatchIsCorrectSetterEventHandler;
            EventsManager.TryAgain += TryAgainEventHandler;
            EventsManager.MissingSelection += MissingSelectionEventHandler;
        }

        private void MatchIsCorrectSetterEventHandler(object sender, EventArgs args)
        {
            MatchIsCorrect = true;
            MatchIsIncorrect = false;
            MissingSelection = false;
        }

        private void TryAgainEventHandler(object sender, EventArgs args)
        {
            MatchIsCorrect = false;
            MatchIsIncorrect = true;
            MissingSelection = false;
        }

        private void MissingSelectionEventHandler(object sender, EventArgs args)
        {
            MatchIsCorrect = false;
            MatchIsIncorrect = false;
            MissingSelection = true;
        }

        public ICommand MakeMatch { get; }
        private IEventsManager EventsManager { get; }

        private string matchIsCorrectMessage = "THAT'S CORRECT!";
        private string matchIsIncorrectMessage = "TRY AGAIN!";
        private string missingSelectionMessage = "PLEASE SELECT ONE TRAINER\nAND ONE POKEMON!";
        private bool matchIsCorrect;
        private bool matchIsIncorrect;
        private bool missingSelection;

        public string MatchIsCorrectMessage
        {
            get => matchIsCorrectMessage;
            set
            {
                matchIsCorrectMessage = value;
                OnPropertyChanged(nameof(MatchIsCorrectMessage));
            }
        }

        public bool MatchIsCorrect
        {
            get => matchIsCorrect;
            set
            {
                matchIsCorrect = value;
                OnPropertyChanged(nameof(MatchIsCorrect));
            }
        }

        public string MatchIsIncorrectMessage
        {
            get => matchIsIncorrectMessage;
            set
            {
                matchIsIncorrectMessage = value;
                OnPropertyChanged(nameof(MatchIsIncorrectMessage));
            }
        }

        public bool MatchIsIncorrect
        {
            get => matchIsIncorrect;
            set
            {
                matchIsIncorrect = value;
                OnPropertyChanged(nameof(MatchIsIncorrect));
            }
        }

        public string MissingSelectionMessage
        {
            get => missingSelectionMessage;
            set
            {
                missingSelectionMessage = value;
                OnPropertyChanged(nameof(MissingSelectionMessage));
            }
        }

        public bool MissingSelection
        {
            get => missingSelection;
            set
            {
                missingSelection = value;
                OnPropertyChanged(nameof(MissingSelection));
            }
        }
    }
}
