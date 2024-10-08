
namespace WhosMyPokemonCommands
{
    public interface IEventsManager
    {
        event EventHandler MatchIsCorrectSetter;
        event EventHandler TryAgain;
        event EventHandler MissingSelection;

        void RaiseCorrectEvent();
        void RaiseTryAgainEvent();
        void RaiseMissingSelectionEvent();
    }
}
