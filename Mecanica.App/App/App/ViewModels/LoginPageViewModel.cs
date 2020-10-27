using App.Modelos;
using App.Services;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace App.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {
        public LoginPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Entrar";

            MenuPageCommand = new Command(async () =>
            {
                var usuario = new Perfil() { Login = Usuario, Senha = Senha };

                try
                {
                    var user = PerfilService.Logar(usuario).Result;

                    Perfil = user;

                    if (user.RoleId == 1)
                    {
                        await navigationService.NavigateAsync("MenuPage");
                    }
                    if (user.RoleId == 2)
                    {
                        await navigationService.NavigateAsync("MenuMecanicoPage");
                    }
                    if (user.RoleId == 3)
                    {
                        await navigationService.NavigateAsync("MenuClientePage");
                    }
                }
                catch
                {
                    await navigationService.NavigateAsync("LoginPage");
                }
            });
        }

        public Command MenuPageCommand { get; }

        public string Usuario { get; set; }

        public string Senha { get; set; }
    }
}

