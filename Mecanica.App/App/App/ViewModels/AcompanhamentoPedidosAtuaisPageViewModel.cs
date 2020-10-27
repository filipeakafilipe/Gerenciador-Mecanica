using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace App.ViewModels
{
    public class AcompanhamentoPedidosAtuaisPageViewModel : ViewModelBase
    {
        public AcompanhamentoPedidosAtuaisPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Pedidos Atuais";
        }
    }
}
