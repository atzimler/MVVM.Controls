using ATZ.MVVM.Controls.ContentControl;
using ATZ.MVVM.ViewModels.Utility;

namespace ATZ.MVVM.Controls.Button
{
    public class ButtonViewModel : ContentControlViewModel, IViewModel<ButtonModel>
    {
        public new ButtonModel GetModel() => GetModel<ButtonModel>();
        public void SetModel(ButtonModel model) => base.SetModel(model);
    }
}
