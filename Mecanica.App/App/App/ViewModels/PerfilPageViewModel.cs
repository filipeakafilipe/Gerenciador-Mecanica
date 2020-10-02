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
    }
}
