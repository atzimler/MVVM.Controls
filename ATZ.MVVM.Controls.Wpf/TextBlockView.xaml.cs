using ATZ.MVVM.Controls.FrameworkElement;
using ATZ.MVVM.Controls.TextBlock;
using ATZ.MVVM.ViewModels.Utility;
using ATZ.MVVM.Views.Utility.Interfaces;
using System.Windows;
using System.Windows.Data;

namespace ATZ.MVVM.Controls.Wpf
{
    /// <summary>
    /// Interaction logic for TextBlockView.xaml
    /// </summary>
    public partial class TextBlockView : IView<IViewModel<TextBlockModel>>, IView<IViewModel<FrameworkElementModel>>, IView<IViewModel<object>>
    {
        public UIElement UIElement => this;

        public TextBlockView()
        {
            InitializeComponent();
        }

        private void BindModelImplementation(IViewModel<TextBlockModel> vm)
        {
            BindingOperations.SetBinding(this, TextProperty,
                new Binding(nameof(Text)) { Mode = BindingMode.OneWay, Source = vm.GetModel() });
        }

        public void BindModel(IViewModel<object> vm) => BindModelImplementation((IViewModel<TextBlockModel>)vm);
        public void BindModel(IViewModel<FrameworkElementModel> vm) => BindModelImplementation((IViewModel<TextBlockModel>)vm);
        public void BindModel(IViewModel<TextBlockModel> vm) => BindModelImplementation(vm);

        public void UnbindModel()
        {
        }
    }
}
