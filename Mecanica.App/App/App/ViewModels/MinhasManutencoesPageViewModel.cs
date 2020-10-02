using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace App.ViewModels
{
    public class MinhasManutencoesPageViewModel : ViewModelBase
    {
        public MinhasManutencoesPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Minhas Manutenções";
        }
    }
}
