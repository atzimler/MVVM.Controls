using ATZ.MVVM.Controls.ContentControl;
using ATZ.MVVM.ViewModels.Utility;

namespace ATZ.MVVM.Controls.Window
{
    public class WindowViewModel : ContentControlViewModel, IViewModel<WindowModel>
    {
        public WindowViewModel()
        {
            Model = new WindowModel();
        }

        public new WindowModel GetModel() => GetModel<WindowModel>();
        public void SetModel(WindowModel model) => base.SetModel(model);
    }
}
