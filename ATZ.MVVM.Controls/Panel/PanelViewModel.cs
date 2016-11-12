using System.Collections.ObjectModel;
using ATZ.MVVM.Controls.FrameworkElement;
using ATZ.MVVM.ViewModels.Utility;
using ATZ.MVVM.ViewModels.Utility.Connectors;

namespace ATZ.MVVM.Controls.Panel
{
    public class PanelViewModel : FrameworkElementViewModel, IViewModel<PanelModel>
    {
        internal ObservableCollection<IViewModel<FrameworkElementModel>> Children { get; } = new ObservableCollection<IViewModel<FrameworkElementModel>>();
        public CollectionViewModelToModelConnector<FrameworkElementModel> ChildrenConnector { get; private set; }


        protected override void BindModel()
        {
            base.BindModel();

            ChildrenConnector = new CollectionViewModelToModelConnector<FrameworkElementModel>
            {
                ModelCollection = GetModel().Children,
                ViewModelCollection = Children
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
