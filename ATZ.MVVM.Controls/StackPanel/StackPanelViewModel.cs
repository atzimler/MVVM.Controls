using ATZ.MVVM.Controls.Panel;
using ATZ.MVVM.ViewModels.Utility;

namespace ATZ.MVVM.Controls.StackPanel
{
    public class StackPanelViewModel : PanelViewModel, IViewModel<StackPanelModel>
    {
        public StackPanelViewModel()
        {
            Model = new StackPanelModel();
        }

        public new StackPanelModel GetModel()
        {
            return (StackPanelModel) Model;
        }

        public void SetModel(StackPanelModel model)
        {
            //Model = model;
            base.SetModel(model);
        }
    }
}
