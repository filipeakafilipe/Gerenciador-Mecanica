using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace App.ViewModels
{
    public class MeusVeiculosPageViewModel : ViewModelBase
    {
        public MeusVeiculosPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Meus Veículos";
        }
    }
}
