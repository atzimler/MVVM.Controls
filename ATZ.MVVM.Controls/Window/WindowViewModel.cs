using ATZ.MVVM.Controls.ContentControl;
using ATZ.MVVM.ViewModels.Utility;
using ATZ.MVVM.Views.Utility.Connectors;

namespace ATZ.MVVM.Controls.Window
{
    public class WindowViewModel : ContentControlViewModel, IViewModel<WindowModel>
    {
        public WindowViewModel()
        {
            Model = new WindowModel();
        }

        public new WindowModel GetModel()
        {
            return (WindowModel) Model;
        }

        public void SetModel(WindowModel model)
        {
            Model = model;
        }
    }
}
