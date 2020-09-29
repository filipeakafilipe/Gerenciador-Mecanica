using Prism;
using Prism.Ioc;
using App.ViewModels;
using App.Views;
using Xamarin.Essentials.Interfaces;
using Xamarin.Essentials.Implementation;
using Xamarin.Forms;

namespace App
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
#if DEBUG
            HotReloader.Current.Run(this);
#endif
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/LoginPage");

            //MainPage = new LoginPage();

        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<CriarPerfilPage, CriarPerfilPageViewModel>();
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
            containerRegistry.RegisterForNavigation<PrismContentPage1, PrismContentPage1ViewModel>();
            containerRegistry.RegisterForNavigation<MenuPage, MenuPageViewModel>();
            containerRegistry.RegisterForNavigation<AcompanhamentoPerfilPage, AcompanhamentoPerfilPageViewModel>();
            containerRegistry.RegisterForNavigation<AlterarUsuarioPage, AlterarUsuarioPageViewModel>();
            containerRegistry.RegisterForNavigation<CriarTipoDeServicoPage, CriarTipoDeServicoPageViewModel>();
        }
    }
}
