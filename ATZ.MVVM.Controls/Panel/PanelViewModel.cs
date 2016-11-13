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
            // TODO: To verify: Having model here might not be a good idea, maybe we should remove the Model property. That would force base.SetModel() and that in turn could assure that everybody do what is expected in that stage.
            Model = model;

            // TODO: Is this enough, or should I somehow ModelCollection.Reset(), so that the reset event of the ObservableCollection is executed.?
            Children.ModelCollection = model.Children;
        }
    }
}
