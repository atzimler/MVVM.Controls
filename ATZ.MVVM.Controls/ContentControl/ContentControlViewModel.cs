using ATZ.MVVM.Controls.FrameworkElement;

namespace ATZ.MVVM.Controls.ContentControl
{
    public class ContentControlViewModel : FrameworkElementViewModel
    {
        private FrameworkElementViewModel _content;

        public FrameworkElementViewModel Content
        {
            get { return _content; }
            set
            {
                _content = value;
                GetModel<ContentControlModel>().Content = value.Model;
            }
        }
    }
}
