using WhosMyPokemon.Models;

namespace WhosMyPokemonCommands
{
    public class SelectMistyCommand : CommandBase
    {
        private TrainerModel TrainerModel;
        public SelectMistyCommand(TrainerModel trainerModel)
        {
            TrainerModel = trainerModel;
        }

        public override void Execute(object parameter)
        {
            TrainerModel.Name = "Misty";
        }

    }
}
