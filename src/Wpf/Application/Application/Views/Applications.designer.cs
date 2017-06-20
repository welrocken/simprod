using System.Windows.Controls;

namespace Simprod.Application.Views
{
    public partial class Applications
    {
        private Grid grid;
        
        private void Init()
        {
            grid = new Grid();
            this.AddChild(grid);
        }
    }
}