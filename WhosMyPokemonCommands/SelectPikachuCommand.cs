using WhosMyPokemon.Models;

namespace WhosMyPokemonCommands
{
    public class SelectPikachuCommand : CommandBase
    {
        private PokemonModel PokemonModel;
        public SelectPikachuCommand(PokemonModel pokemonModel)
        {
            PokemonModel = pokemonModel;
        }

        public override void Execute(object parameter)
        {
            PokemonModel.Name = "Pikachu";
        }

    }
}
