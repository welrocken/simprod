using System.Windows;

namespace Simprod.Application.UI
{
    public partial class ViewWindow : Window
    {
        public View View
        {
            get
            {
                return ContentArea.Content as View;
            }
            set
            {
                ContentArea.Content = value;
            }
        }

        public ViewWindow()
        {
            InitializeComponent();
        }
    }
}