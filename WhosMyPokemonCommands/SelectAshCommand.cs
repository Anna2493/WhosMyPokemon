using WhosMyPokemon.Models;

namespace WhosMyPokemonCommands
{
    public class SelectAshCommand : CommandBase
    {
        private TrainerModel TrainerModel;
        public SelectAshCommand(TrainerModel trainerModel) 
        {
            TrainerModel = trainerModel;
        }
        public override void Execute(object parameter)
        {
            TrainerModel.Name = "Ash";
        }

    }
}