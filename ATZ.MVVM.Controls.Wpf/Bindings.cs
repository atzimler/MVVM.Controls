using ATZ.DependencyInjection;
using ATZ.MVVM.Controls.StackPanel;
using ATZ.MVVM.Controls.TextBox;
using ATZ.MVVM.Controls.Window;
using ATZ.MVVM.Views.Utility.Interfaces;
using System.Linq;
using ATZ.MVVM.Controls.Button;
using ATZ.MVVM.Controls.TextBlock;
using ATZ.MVVM.Views.Utility;

namespace ATZ.MVVM.Controls.Wpf
{
    public static class Bindings
    {
        private static readonly MvvmTuple[] MvvmTuples = {
            new MvvmTuple { Model = typeof(ButtonModel), View = typeof(ButtonView), ViewModel = typeof(ButtonViewModel) },
            new MvvmTuple { Model = typeof(StackPanelModel), View = typeof(StackPanelView), ViewModel = typeof(StackPanelViewModel) },
            new MvvmTuple { Model = typeof(TextBlockModel), View = typeof(TextBlockView), ViewModel = typeof(TextBlockViewModel) },
            new MvvmTuple { Model = typeof(TextBoxModel), View = typeof(TextBoxView), ViewModel = typeof(TextBoxViewModel) }
        };

        public static void Initialize()
        {
            Views.Utility.Bindings.Initialize();

            DependencyResolver.Instance.Bind<IModalWindow<WindowViewModel>>().To<WindowView>();

            MvvmTuples.ToList().ForEach(tuple => tuple.RegisterBindings());
        }
    }
}
