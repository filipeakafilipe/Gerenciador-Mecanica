using App.Dictionary;
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
    public class CriarPedidoPageViewModel : ViewModelBase
    {
        public CriarPedidoPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Cadastrar pedido";

            CadastrarCommand = new Command(async () =>
            {
                ValorMaoDeObra.Replace(",", ".");
                ValorPecas.Replace(",", ".");

                double valorMaoDeObra = double.Parse(ValorMaoDeObra);
                double valorPecas = double.Parse(ValorPecas);

                var a = SelectedItem.Key;

                var pedido = new Pedido()
                {
                    TipoDeServicoId = SelectedItem.Key,
                    VeiculoId = VeiculoId,
                    ValorMaoDeObra = valorMaoDeObra,
                    ValorPecas = valorPecas,
                    SLA = SelectedSLAItem.Value
                };

                try
                {
                    await PedidoService.Cadastrar(pedido);
                    await navigationService.NavigateAsync("MenuPage");
                    CrossToastPopUp.Current.ShowToastSuccess("Cadastrado com sucesso");
                }
                catch(Exception ex)
                {
                    await navigationService.NavigateAsync("MenuPage");
                    CrossToastPopUp.Current.ShowToastError("Falha no cadastro");
                }
            });
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            VeiculoId = parameters.GetValue<int>("veiculoId");
        }

        private int _VeiculoId;

        public int VeiculoId
        {
            get { return _VeiculoId; }
            set { SetProperty(ref _VeiculoId, value); }
        }

        public string ValorMaoDeObra { get; set; }

        public string ValorPecas { get; set; }

        private Dictionary<int, string> SLAs = new SLADictionary().Nomes;

        public List<KeyValuePair<int, string>> PickerSLAItemList
        {
            get => SLAs.ToList();
        }

        private KeyValuePair<int, string> _selectedSLAItem;
        public KeyValuePair<int, string> SelectedSLAItem
        {
            get => _selectedSLAItem;
            set => _selectedSLAItem = value;
        }

        public Command CadastrarCommand { get; }

        public List<KeyValuePair<int, string>> PickerItemList
        {
            get => new TipoDeServico().PopulaTipos();
        }

        private KeyValuePair<int, string> _selectedItem;
        public KeyValuePair<int, string> SelectedItem
        {
            get => _selectedItem;
            set => _selectedItem = value;
        }
    }
}
