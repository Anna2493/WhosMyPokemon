

namespace WhosMyPokemonCommands
{
    public class EventsManager : IEventsManager
    {
        public event EventHandler MatchIsCorrectSetter;
        public event EventHandler TryAgain;
        public event EventHandler MissingSelection;

        public void RaiseCorrectEvent()
        {
            MatchIsCorrectSetter?.Invoke(this, null);
        }

        public void RaiseTryAgainEvent()
        {
            TryAgain?.Invoke(this, null);
        }

        public void RaiseMissingSelectionEvent()
        {
            MissingSelection?.Invoke(this, null);
        }

    }
}
