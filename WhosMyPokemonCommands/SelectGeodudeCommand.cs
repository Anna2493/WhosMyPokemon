using WhosMyPokemon.Models;

namespace WhosMyPokemonCommands
{
    public class SelectGeodudeCommand : CommandBase
    {
        private PokemonModel PokemonModel;
        public SelectGeodudeCommand(PokemonModel pokemonModel)
        {
            PokemonModel = pokemonModel;
        }

        public override void Execute(object parameter)
        {
            PokemonModel.Name = "Geodude";
        }

    }
}
