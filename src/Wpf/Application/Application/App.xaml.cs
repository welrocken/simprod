using System.Windows;
using Simprod.Application.UI;
using Simprod.Application.Views;
using Simprod.Application.Windows;

namespace Simprod.Application
{
    public partial class App : System.Windows.Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var window = new MainWindow();
            window.Show();
        }
    }
}