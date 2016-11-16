using System.Windows;
using ATZ.MVVM.Controls.Button;
using ATZ.MVVM.Controls.FrameworkElement;
using ATZ.MVVM.ViewModels.Utility;
using ATZ.MVVM.Views.Utility.Interfaces;

namespace ATZ.MVVM.Controls.Wpf
{
    /// <summary>
    /// Interaction logic for ButtonView.xaml
    /// </summary>
    public partial class ButtonView : IView<IViewModel<ButtonModel>>, IView<IViewModel<FrameworkElementModel>>
    {
        public UIElement UIElement => this;

        public ButtonView()
        {
            InitializeComponent();
        }

        private void BindModelImplementation(IViewModel<ButtonModel> vm)
        {
        }

        public void BindModel(IViewModel<ButtonModel> vm) => BindModelImplementation(vm);
        public void BindModel(IViewModel<FrameworkElementModel> vm) => BindModelImplementation((IViewModel<ButtonModel>) vm);

        public void UnbindModel()
        {
        }
    }
}
