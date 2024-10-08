
using WhosMyPokemonCommands;
using System.Windows.Input;
using WhosMyPokemon.Models;

namespace WhosMyPokemon.ViewModels
{
    public class PairSelectorVM : ViewModelBase
    {
        public PairSelectorVM(TrainerModel trainerModel, PokemonModel pokemonModel)
        {
            SelectAsh = new SelectAshCommand(trainerModel);
            SelectMisty = new SelectMistyCommand(trainerModel);
            SelectBrock = new SelectBrockCommand(trainerModel);
            SelectPikachu = new SelectPikachuCommand(pokemonModel);
            SelectTogepi = new SelectTogepiCommand(pokemonModel);
            SelectGeodude = new SelectGeodudeCommand(pokemonModel);
        }

        public ICommand SelectAsh { get; }
        public ICommand SelectMisty { get; }
        public ICommand SelectBrock { get; }
        public ICommand SelectPikachu { get; }
        public ICommand SelectTogepi { get; }
        public ICommand SelectGeodude { get; }
    }
}
