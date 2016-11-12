using System.Collections.ObjectModel;
using ATZ.MVVM.Controls.FrameworkElement;
using ATZ.MVVM.ViewModels.Utility;
using ATZ.MVVM.ViewModels.Utility.Connectors;

namespace ATZ.MVVM.Controls.Panel
{
    public class PanelViewModel : FrameworkElementViewModel, IViewModel<PanelModel>
    {
        internal ObservableCollection<IViewModel<FrameworkElementModel>> ChildCollection { get; } = new ObservableCollection<IViewModel<FrameworkElementModel>>();
        public CollectionViewModelToModelConnector<FrameworkElementModel> Children { get; private set; }


        protected override void BindModel()
        {
            base.BindModel();

            Children = new CollectionViewModelToModelConnector<FrameworkElementModel>
            {
                ModelCollection = GetModel().Children,
                ViewModelCollection = ChildCollection
            };
        }

        public new PanelModel GetModel()
        {
            return (PanelModel) Model;
        }

        public void SetModel(PanelModel model)
        {
            Model = model;
        }
    }
}
