using Prism;
using Prism.Ioc;
using Mecanica.App.ViewModels;
using Mecanica.App.Views;
using Xamarin.Essentials.Interfaces;
using Xamarin.Essentials.Implementation;
using Xamarin.Forms;

namespace Mecanica.App
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
            MainPage = new MainPage();
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<CriarPerfilPage, CriarPerfilPageViewModel>();
        }
    }
}
