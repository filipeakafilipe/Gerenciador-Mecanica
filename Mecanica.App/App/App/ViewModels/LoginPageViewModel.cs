using App.Enum;
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
        public LoginPageViewModel(INavigationService navigationService, IUsuarioLogado usuarioLogadoService) : base(navigationService)
        {
            Title = "Entrar";

            MenuPageCommand = new Command(async () =>
            {
                var usuario = new Perfil() { Login = Usuario, Senha = Senha };

                try
                {

                    //var user = PerfilService.Logar(usuario).Result;

                    //usuarioLogadoService.SetUsuarioLogado(user);

                    var user = usuario;
                    user.Id = 1;
                    user.Nome = "Filipe";
                    user.Telefone = "(31) 3300-0000";

                    if (user.Login == "admin")
                    {
                        user.RoleId = 1;
                        usuarioLogadoService.SetUsuarioLogado(user);
                        await navigationService.NavigateAsync("MenuPage");
                    }
                    if (user.Login == "mecanico")
                    {
                        user.RoleId = 2;
                        usuarioLogadoService.SetUsuarioLogado(user);
                        await navigationService.NavigateAsync("MenuMecanicoPage");
                    }
                    if (user.Login == "cliente")
                    {
                        user.RoleId = 3;
                        usuarioLogadoService.SetUsuarioLogado(user);
                        await navigationService.NavigateAsync("MenuClientePage");
                    }

                    //if (user.RoleId == (int)RolesEnum.Administrador)
                    //{
                    //    await navigationService.NavigateAsync("MenuPage");
                    //}
                    //if (user.RoleId == (int)RolesEnum.Mecanico)
                    //{
                    //    await navigationService.NavigateAsync("MenuMecanicoPage");
                    //}
                    //if (user.RoleId == (int)RolesEnum.Cliente)
                    //{
                    //    await navigationService.NavigateAsync("MenuClientePage");
                    //}
                }
                catch (Exception ex)
                {
                    await navigationService.NavigateAsync("LoginPage");
                }
            });

            //MenuPageCommand = new Command(async () =>
            //{
            //    var usuario = new Perfil() { Login = Usuario, Senha = Senha };

            //    try
            //    {
            //        var user = PerfilService.Logar(usuario).Result;

            //            usuarioLogadoService.SetUsuarioLogado(user);

            //        if (user.RoleId == (int)RolesEnum.Administrador)
            //        {
            //            await navigationService.NavigateAsync("MenuPage");
            //        }
            //        if (user.RoleId == (int)RolesEnum.Mecanico)
            //        {
            //            await navigationService.NavigateAsync("MenuMecanicoPage");
            //        }
            //        if (user.RoleId == (int)RolesEnum.Cliente)
            //        {
            //            await navigationService.NavigateAsync("MenuClientePage");
            //        }
            //    }
            //    catch(Exception ex)
            //    {
            //        await navigationService.NavigateAsync("LoginPage");
            //    }
            //});
        }

        public Command MenuPageCommand { get; }

        public string Usuario { get; set; }

        public string Senha { get; set; }
    }
}

