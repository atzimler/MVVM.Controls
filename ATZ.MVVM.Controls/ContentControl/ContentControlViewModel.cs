using System;
using ATZ.MVVM.Controls.FrameworkElement;

namespace ATZ.MVVM.Controls.ContentControl
{
    public class ContentControlViewModel : FrameworkElementViewModel
    {
        public FrameworkElementViewModel Content { get; set; }

        protected override void BindModel()
        {
        }

        protected override void UnbindModel()
        {
        }

        public override void UpdateValidity(object sender, EventArgs e)
        {
        }
    }
}
