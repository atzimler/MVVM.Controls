using System.Windows;
using ATZ.MVVM.Controls.FrameworkElement;
using ATZ.MVVM.Controls.StackPanel;
using ATZ.MVVM.ViewModels.Utility;
using ATZ.MVVM.Views.Utility.Connectors;
using ATZ.MVVM.Views.Utility.Interfaces;

namespace ATZ.MVVM.Controls.Wpf
{
    using TChildrenConnector = CollectionViewToViewModelConnector<IView<IViewModel<FrameworkElementModel>>, FrameworkElementModel>;

    /// <summary>
    /// Interaction logic for StackPanelView.xaml
    /// </summary>
    public partial class StackPanelView : IView<IViewModel<StackPanelModel>>, IView<IViewModel<FrameworkElementModel>>
    {
        private TChildrenConnector _childrenConnector;

        public UIElement UIElement => this;

        public StackPanelView()
        {
            InitializeComponent();
        }

        private void BindModelImplementation(IViewModel<StackPanelModel> vm)
        {
            StackPanelViewModel spvm = (StackPanelViewModel) vm;
            _childrenConnector = new TChildrenConnector {ViewModelCollection = spvm.ChildCollection, ViewCollection = Children};
        }

        public void BindModel(IViewModel<FrameworkElementModel> vm) => BindModelImplementation((IViewModel<StackPanelModel>)vm);
        public void BindModel(IViewModel<StackPanelModel> vm) => BindModelImplementation(vm);

        public void UnbindModel()
        {
        }
    }
}
