using System.Collections.ObjectModel;
using ATZ.MVVM.Controls.Control;
using ATZ.MVVM.ViewModels.Utility;
using ATZ.MVVM.ViewModels.Utility.Connectors;

namespace ATZ.MVVM.Controls.ItemsControl
{
    public class ItemsControlViewModel : ControlViewModel, IViewModel<ItemsControlModel>
    {
        internal ObservableCollection<IViewModel<object>> ItemsCollection { get; } = new ObservableCollection<IViewModel<object>>();
        public CollectionViewModelToModelConnector<object> Items { get; private set; }

        protected override void BindModel()
        {
            base.BindModel();

            Items = new CollectionViewModelToModelConnector<object>
            {
                ModelCollection = GetModel().Items,
                ViewModelCollection = ItemsCollection
            };
        }

        public new ItemsControlModel GetModel()
        {
            return (ItemsControlModel) Model;
        }

        public void SetModel(ItemsControlModel model)
        {
            Model = model;
            Items.ModelCollection = model.Items;
        }
    }
}
