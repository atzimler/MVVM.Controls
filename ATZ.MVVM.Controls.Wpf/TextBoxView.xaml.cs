using System.Windows;
using ATZ.MVVM.Controls.FrameworkElement;
using ATZ.MVVM.Controls.TextBox;
using ATZ.MVVM.ViewModels.Utility;
using ATZ.MVVM.Views.Utility.Interfaces;

namespace ATZ.MVVM.Controls.Wpf
{
    /// <summary>
    /// Interaction logic for TextBoxView.xaml
    /// </summary>
    public partial class TextBoxView : IView<IViewModel<TextBoxModel>>, IView<IViewModel<FrameworkElementModel>>
    {
        public UIElement UIElement => this;

        public TextBoxView()
        {
            InitializeComponent();
        }

        private static void BindModelImplementation(IViewModel<TextBoxModel> vm)
        {
        }

        public void BindModel(IViewModel<TextBoxModel> vm) => BindModelImplementation(vm);
        public void BindModel(IViewModel<FrameworkElementModel> vm) => BindModelImplementation((IViewModel<TextBoxModel>)vm);

        public void UnbindModel()
        {
        }
    }
}
