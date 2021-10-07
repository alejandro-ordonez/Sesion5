using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;
using Application = Microsoft.Maui.Controls.Application;

namespace Sesion5
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Se configura el root page como un Navigation Page y se asigna la página de arranque
            MainPage = new NavigationPage(new MainPage());
        }
    }
}
