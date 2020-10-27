using App.Modelos;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace App.ViewModels
{
    public class PerfilPageViewModel : ViewModelBase
    {
        public PerfilPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Meu Perfil";
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            Usuario = parameters.GetValue<Perfil>("usuario");
        }

        private Perfil _Usuario;

        public Perfil Usuario
        {
            get { return _Usuario; }
            set { SetProperty(ref _Usuario, value); }
        }
    }
}
