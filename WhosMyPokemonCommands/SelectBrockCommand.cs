using WhosMyPokemon.Models;

namespace WhosMyPokemonCommands
{
    public class SelectBrockCommand : CommandBase
    {
        private TrainerModel TrainerModel;
        public SelectBrockCommand(TrainerModel trainerModel)
        {
            TrainerModel = trainerModel;
        }

        public override void Execute(object parameter)
        {
            TrainerModel.Name = "Brock";
        }

    }
}
