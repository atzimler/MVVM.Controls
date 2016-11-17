using ATZ.MVVM.Controls.FrameworkElement;
using ATZ.MVVM.ViewModels.Utility;

namespace ATZ.MVVM.Controls.TextBlock
{
    public class TextBlockViewModel : FrameworkElementViewModel, IViewModel<TextBlockModel>
    {
        // ReSharper disable once MemberCanBePrivate.Global => Part of public API.
        public TextBlockViewModel()
        {
            Model = new TextBlockModel();
        }

        public TextBlockViewModel(string text)
            : this()
        {
            GetModel().Text = text;
        }

        public new TextBlockModel GetModel() => GetModel<TextBlockModel>();
        public void SetModel(TextBlockModel model) => base.SetModel(model);
    }
}
