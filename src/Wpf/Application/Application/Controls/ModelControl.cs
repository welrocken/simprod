using System.Windows;

namespace Simprod.Application.Controls
{
    public abstract class ModelControl<T> : UIElement
    {
        public virtual T Object { get; set; }

        public ModelControl(T @object)
        {
            Object = @object;
        }
    }
}