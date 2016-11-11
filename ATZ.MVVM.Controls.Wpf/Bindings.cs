using ATZ.DependencyInjection;
using ATZ.MVVM.Controls.StackPanel;
using ATZ.MVVM.Controls.TextBox;
using ATZ.MVVM.Controls.Window;
using ATZ.MVVM.ViewModels.Utility;
using ATZ.MVVM.Views.Utility.Interfaces;

namespace ATZ.MVVM.Controls.Wpf
{
    public static class Bindings
    {
        public static void Initialize()
        {
            Views.Utility.Bindings.Initialize();

            DependencyResolver.Instance.Bind<IModalWindow<WindowViewModel>>().To<WindowView>();

            DependencyResolver.Instance.Bind<IView<StackPanelViewModel>>().To<StackPanelView>();
            DependencyResolver.Instance.Bind<IView<TextBoxViewModel>>().To<TextBoxView>();

            DependencyResolver.Instance.Bind<IView<IViewModel<StackPanelModel>>>().To<StackPanelView>();
            DependencyResolver.Instance.Bind<IView<IViewModel<TextBoxModel>>>().To<TextBoxView>();
        }
    }
}
