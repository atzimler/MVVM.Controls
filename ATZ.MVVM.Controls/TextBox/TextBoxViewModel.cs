using ATZ.MVVM.Controls.Control;
using ATZ.MVVM.ViewModels.Utility;

namespace ATZ.MVVM.Controls.TextBox
{
    public class TextBoxViewModel : ControlViewModel, IViewModel<TextBoxModel>
    {
        public TextBoxViewModel()
        {
            Model = new TextBoxModel();
        }

        public new TextBoxModel GetModel()
        {
            return (TextBoxModel) Model;
        }

        public void SetModel(TextBoxModel model)
        {
            Model = model;
        }
    }
}
