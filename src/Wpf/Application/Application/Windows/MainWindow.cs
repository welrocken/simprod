using Simprod.Application.UI;
using Simprod.Application.Views;

namespace Simprod.Application.Windows
{
    public class MainWindow : ViewWindow
    {
        public MainWindow()
        {
            View = new Applications(null);
        }
    }
}