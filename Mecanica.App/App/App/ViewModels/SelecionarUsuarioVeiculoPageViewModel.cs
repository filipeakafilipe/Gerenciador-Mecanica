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
    public class SelecionarUsuarioVeiculoPageViewModel : ViewModelBase
    {
        public SelecionarUsuarioVeiculoPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Selecionar usuário";

            //try
            //{
            Perfis = new List<Perfil>();
            Perfis.Add(new Perfil() { Id = 1, Login = "Login 1", Nome = "Nome 1", RoleId = 1, Senha = "Senha user 1", Telefone = "Telefone 1" });
            Perfis.Add(new Perfil() { Id = 2, Login = "Login 2", Nome = "Nome 2", RoleId = 2, Senha = "Senha user 2", Telefone = "Telefone 2" });
            //    Perfis = PerfilService.GetPerfis().Result;
            //}
            //catch
            //{
            //    navigationService.NavigateAsync("MenuPage");
            //}

            SelectedUsuarioVeiculoChangeCommand = new Command(async () =>
            {
                //var perfilVM = SelectedPerfil;

                //var dados = new NavigationParameters();
                //dados.Add("id", perfilVM.Id);

                await navigationService.NavigateAsync("CadastrarVeiculoPage"/*, dados*/);
            });
        }

        public List<Perfil> Perfis { get; set; }

        public Perfil SelectedPerfil { get; set; }

        public Command SelectedUsuarioVeiculoChangeCommand { get; }
    }
}
