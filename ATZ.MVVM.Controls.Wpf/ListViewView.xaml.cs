using System.Windows;
using ATZ.MVVM.Controls.ListView;
using ATZ.MVVM.ViewModels.Utility;
using ATZ.MVVM.Views.Utility.Connectors;
using ATZ.MVVM.Views.Utility.Interfaces;

namespace ATZ.MVVM.Controls.Wpf
{
    using TItemsConnector = CollectionViewToViewModelConnector<IView<IViewModel<object>>, object>;

    /// <summary>
    /// Interaction logic for ListViewView.xaml
    /// </summary>
    public partial class ListViewView : IView<IViewModel<ListViewModel>>
    {
        private TItemsConnector _itemsConnector;

        public UIElement UIElement => this;

        public ListViewView()
        {
            InitializeComponent();
        }

        public void BindModel(IViewModel<ListViewModel> vm)
        {
            var lvvm = (ListViewViewModel) vm;
            _itemsConnector = new TItemsConnector
            {
                ViewModelCollection = lvvm.ItemsCollection,
                ViewCollection = Items
            };
        }

        public void UnbindModel()
        {
        }
    }
}
