using System.Windows;
using System.Windows.Media.Imaging;

namespace Simprod.Application.Controls
{
    public class ApplicationShortcutControl : ShortcutControl
    {
        public Models.Application Application { get; }

        public ApplicationShortcutControl(Models.Application application)
        {
            Application = application;

            Init();
        }

        private void Init()
        {
            if (Application == null)
                return;
            
            //image.
            //image.Source = new BitmapImage(Application.ImageUri);
            //label.Content = Application.Name;
        }
    }
}