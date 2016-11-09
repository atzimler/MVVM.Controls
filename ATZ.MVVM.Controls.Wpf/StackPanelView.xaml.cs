using System.Windows;
using ATZ.MVVM.Controls.FrameworkElement;
using ATZ.MVVM.Controls.StackPanel;
using ATZ.MVVM.Views.Utility.Connectors;
using ATZ.MVVM.Views.Utility.Interfaces;

namespace ATZ.MVVM.Controls.Wpf
{
    using TChildrenConnector = CollectionViewToViewModelConnector<IView<StackPanelViewModel>, StackPanelViewModel, StackPanelModel>;

    /// <summary>
    /// Interaction logic for StackPanelView.xaml
    /// </summary>
    public partial class StackPanelView : IView<StackPanelViewModel>, IView<FrameworkElementViewModel>
    {
        private TChildrenConnector _childrenConnector;

        public UIElement UIElement => this;

        public StackPanelView()
        {
            InitializeComponent();
        }

        // TODO: Need ATZ.MVVM 3.0
        //private void BindModelImplementation(StackPanelViewModel vm)
        private void BindModelImplementation(FrameworkElementViewModel vm)
        {
            // TODO: Need ATZ.MVVM 3.0 - otherwise cannot establish connection between Children collections, because there is no cast to get back the StackPanelViewModel
            //_childrenConnector = new TChildrenConnector
        }

        //public void BindModel(FrameworkElementViewModel vm) => BindModelImplementation((StackPanelViewModel)vm);
        public void BindModel(FrameworkElementViewModel vm) => BindModelImplementation(vm);
        // TODO: Need ATZ.MVVM 3.0
        //public void BindModel(StackPanelViewModel vm) => BindModelImplementation(vm);
        public void BindModel(StackPanelViewModel vm) => BindModelImplementation(null);

        public void UnbindModel()
        {
        }
    }
}
