using System.Windows;
using ATZ.MVVM.Controls.FrameworkElement;
using ATZ.MVVM.Controls.StackPanel;
using ATZ.MVVM.Views.Utility.Interfaces;

namespace ATZ.MVVM.Controls.Wpf
{
    /// <summary>
    /// Interaction logic for StackPanelView.xaml
    /// </summary>
    public partial class StackPanelView : IView<StackPanelViewModel>, IView<FrameworkElementViewModel>
    {
        public UIElement UIElement => this;

        public StackPanelView()
        {
            InitializeComponent();
        }

        private void BindModelImplementation(FrameworkElementViewModel vm)
        {
        }

        public void BindModel(FrameworkElementViewModel vm) => BindModelImplementation(vm);
        public void BindModel(StackPanelViewModel vm) => BindModelImplementation(vm);

        public void UnbindModel()
        {
        }
    }
}
