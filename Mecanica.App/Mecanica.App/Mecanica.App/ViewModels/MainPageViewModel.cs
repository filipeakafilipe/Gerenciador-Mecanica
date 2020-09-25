using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace Mecanica.App.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page xx";

            CriarPerfilCommand = new Command(() =>
            {
                var criarPerfilPage = new CriarPerfilPage();

                navigationService.NavigateAsync("CriarPerfilPage");
            });
        }

        public Command CriarPerfilCommand { get; }
    }
}
