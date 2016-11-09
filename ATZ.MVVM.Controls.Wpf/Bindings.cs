using ATZ.DependencyInjection;
using ATZ.MVVM.Controls.StackPanel;
using ATZ.MVVM.Controls.Window;
using ATZ.MVVM.Views.Utility.Interfaces;

namespace ATZ.MVVM.Controls.Wpf
{
    public static class Bindings
    {
        public static void Initialize()
        {
            DependencyResolver.Instance.Bind<IModalWindow<WindowViewModel>>().To<WindowView>();

            DependencyResolver.Instance.Bind<IView<StackPanelViewModel>>().To<StackPanelView>();
        }
    }
}
