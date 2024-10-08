using System.Windows;
using WhosMyPokemon.Models;
using WhosMyPokemon.ViewModels;

namespace WhosMyPokemon
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly TrainerModel TrainerModel;
        private readonly PokemonModel PokemonModel;

        public App()
        {
            TrainerModel = new TrainerModel();
            PokemonModel = new PokemonModel();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new MainVM(TrainerModel, PokemonModel)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }

}
