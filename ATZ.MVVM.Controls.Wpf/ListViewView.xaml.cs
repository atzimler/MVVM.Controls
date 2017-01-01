using ATZ.MVVM.Controls.FrameworkElement;
using ATZ.MVVM.Controls.ListView;
using ATZ.MVVM.ViewModels.Utility;
using ATZ.MVVM.Views.Utility.Connectors;
using ATZ.MVVM.Views.Utility.Interfaces;
using System.Windows;

namespace ATZ.MVVM.Controls.Wpf
{
    using TItemsConnector = CollectionViewToViewModelConnector<IView<IViewModel<object>>, object>;

    /// <summary>
    /// Interaction logic for ListViewView.xaml
    /// </summary>
    public partial class ListViewView : IView<IViewModel<ListViewModel>>, IView<IViewModel<FrameworkElementModel>>
    {
        private TItemsConnector _itemsConnector;

        public UIElement UIElement => this;

        public ListViewView()
        {
            InitializeComponent();
        }

        private void BindModelImplementation(IViewModel<ListViewModel> vm)
        {
            var lvvm = (ListViewViewModel)vm;
            _itemsConnector = new TItemsConnector
            {
                ViewModelCollection = lvvm.ItemsCollection,
                ViewCollection = Items
            };
        }

        public void BindModel(IViewModel<FrameworkElementModel> vm) => BindModelImplementation((IViewModel<ListViewModel>)vm);
        public void BindModel(IViewModel<ListViewModel> vm) => BindModelImplementation(vm);

        public void UnbindModel()
        {
        }
    }
}
