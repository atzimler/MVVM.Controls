using ATZ.MVVM.Controls.FrameworkElement;
using ATZ.MVVM.ViewModels.Utility;

namespace ATZ.MVVM.Controls.TextBlock
{
    public class TextBlockViewModel : FrameworkElementViewModel, IViewModel<TextBlockModel>
    {
        public TextBlockViewModel()
        {
            Model = new TextBlockModel();
        }

        public new TextBlockModel GetModel() => GetModel<TextBlockModel>();
        public void SetModel(TextBlockModel model) => base.SetModel(model);
    }
}
