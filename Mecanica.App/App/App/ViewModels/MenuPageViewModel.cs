using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace App.ViewModels
{
    public class MenuPageViewModel : ViewModelBase
    {
        public MenuPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Página Menu";

            CriarPerfilCommand = new Command(async () =>
            {
                await navigationService.NavigateAsync("CriarPerfilPage");
            });
        }

        public Command CriarPerfilCommand { get; }
    }
}
