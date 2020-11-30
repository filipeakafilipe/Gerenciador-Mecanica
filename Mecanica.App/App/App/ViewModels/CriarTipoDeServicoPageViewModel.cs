using App.Modelos;
using App.Services;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Plugin.Toast;

namespace App.ViewModels
{
    public class CriarTipoDeServicoPageViewModel : ViewModelBase
    {
        public CriarTipoDeServicoPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Criar tipo de serviço";

            CadastrarCommand = new Command(async () =>
            {
                var tipoDeServico = new TipoDeServico()
                {
                    Nome = Nome,
                    Observacoes = Observacoes
                };

                try
                {
                    await TipoDeServicoService.Cadastrar(tipoDeServico);
                    await navigationService.NavigateAsync("MenuPage");
                    CrossToastPopUp.Current.ShowToastSuccess("Cadastrado com sucesso");
                }
                catch
                {
                    await navigationService.NavigateAsync("MenuPage");
                    CrossToastPopUp.Current.ShowToastError("Falha no cadastro");
                }
            });
        }

        public string Nome { get; set; }

        public string Observacoes { get; set; }

        public Command CadastrarCommand { get; }
    }
}
