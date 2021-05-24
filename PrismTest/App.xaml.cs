using Prism.Ioc;
using PrismTest.Views;
using System.Windows;

namespace PrismTest
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<LandingPage>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
        protected override void OnInitialized()
        {
            var login = Container.Resolve<Login>();
            var result = login.ShowDialog();
            if (result.Value)
                base.OnInitialized();
            else
                Application.Current.Shutdown();
        }
    }
}
