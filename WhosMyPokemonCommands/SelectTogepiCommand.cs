using WhosMyPokemon.Models;

namespace WhosMyPokemonCommands
{
    public class SelectTogepiCommand : CommandBase
    {
        private PokemonModel PokemonModel;
        public SelectTogepiCommand(PokemonModel pokemonModel)
        {
            PokemonModel = pokemonModel;
        }

        public override void Execute(object parameter)
        {
            PokemonModel.Name = "Togepi";
        }
    }
}
