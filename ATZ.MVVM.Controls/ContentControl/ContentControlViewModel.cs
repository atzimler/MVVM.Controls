using System;
using ATZ.MVVM.Controls.FrameworkElement;
using ATZ.MVVM.ViewModels.Utility;

namespace ATZ.MVVM.Controls.ContentControl
{
    public class ContentControlViewModel : FrameworkElementViewModel, IViewModel<ContentControlModel>
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

        public new ContentControlModel GetModel() => GetModel<ContentControlModel>();
        public void SetModel(ContentControlModel model) => base.SetModel(model);
    }
}
