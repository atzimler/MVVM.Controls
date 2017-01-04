using ATZ.MVVM.Controls.FrameworkElement;
using ATZ.MVVM.Controls.TreeView;
using ATZ.MVVM.ViewModels.Utility;
using ATZ.MVVM.Views.Utility.Connectors;
using ATZ.MVVM.Views.Utility.Interfaces;
using System.Windows;

namespace ATZ.MVVM.Controls.Wpf
{
    using TItemsConnector = CollectionViewToViewModelConnector<IView<IViewModel<object>>, object>;

    /// <summary>
    /// Interaction logic for TreeViewView.xaml
    /// </summary>
    public partial class TreeViewView : IView<IViewModel<TreeViewModel>>, IView<IViewModel<FrameworkElementModel>>
    {
        private TItemsConnector _itemsConnector;

        public UIElement UIElement => this;

        public TreeViewView()
        {
            InitializeComponent();
        }

        private void BindModelImplementation(IViewModel<TreeViewModel> vm)
        {
            var tvvm = (TreeViewViewModel)vm;
            _itemsConnector = new TItemsConnector
            {
                ViewModelCollection = tvvm.ItemsCollection,
                ViewCollection = Items
            };
        }

        public void BindModel(IViewModel<FrameworkElementModel> vm) => BindModelImplementation((IViewModel<TreeViewModel>)vm);
        public void BindModel(IViewModel<TreeViewModel> vm) => BindModelImplementation(vm);

        public void UnbindModel()
        {
        }

    }
}
