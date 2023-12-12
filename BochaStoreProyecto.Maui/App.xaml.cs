using BochaStoreProyecto.Maui.Services;
using BochaStoreProyecto.Maui.Views;

namespace BochaStoreProyecto.Maui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            APIService apiservice = new APIService();
            //MainPage = new NavigationPage(new LoginPage(apiservice));
            MainPage = new FlyoutPageT(apiservice);
        }
    }
}
