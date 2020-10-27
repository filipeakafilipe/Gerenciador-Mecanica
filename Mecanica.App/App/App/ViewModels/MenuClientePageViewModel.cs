using App.Modelos;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace App.ViewModels
{
    public class MenuClientePageViewModel : ViewModelBase
    {
        public MenuClientePageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Menu";

            PerfilCommand = new Command(async () =>
            {
                var dados = new NavigationParameters();
                dados.Add("usuario", Usuario);

                await navigationService.NavigateAsync("PerfilPage", dados);
            });

            MeusVeiculosCommand = new Command(async () =>
            {
                var dados = new NavigationParameters();
                dados.Add("usuarioId", Usuario.Id);

                await navigationService.NavigateAsync("MeusVeiculosPage", dados);
            });

            MinhasManutencoesCommand = new Command(async () =>
            {
                //var dados = new NavigationParameters();
                //dados.Add();

                await navigationService.NavigateAsync("MinhasManutencoesPage"/*, dados*/);
            });
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            Usuario = parameters.GetValue<Perfil>("usuario");
        }

        public Command PerfilCommand { get; }

        public Command MeusVeiculosCommand { get; }

        public Command MinhasManutencoesCommand { get; }

        private Perfil _Usuario;

        public Perfil Usuario
        {
            get { return _Usuario; }
            set { SetProperty(ref _Usuario, value); }
        }
    }
}
