using ATZ.MVVM.Controls.Panel;
using ATZ.MVVM.ViewModels.Utility;

namespace ATZ.MVVM.Controls.DockPanel
{
    public class DockPanelViewModel : PanelViewModel, IViewModel<DockPanelModel>
    {
        public new DockPanelModel GetModel()
        {
            return (DockPanelModel) Model;
        }

        public void SetModel(DockPanelModel model)
        {
            Model = model;
        }
    }
}
