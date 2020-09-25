using Mecanica.App.Modelos;
using Prism.Navigation;
using Xamarin.Forms;

namespace Mecanica.App.ViewModels
{
    public class CriarPerfilPageViewModel : ViewModelBase
    {
        public CriarPerfilPageViewModel(INavigationService navigationService)
    : base(navigationService)
        {
            Title = "Criar perfil";

            var Roles = new Roles().Nomes;

            Cadastrar = new Command(() =>
            {

            });
        }

        Command Cadastrar { get; }
    }
}
