using System;
using ATZ.MVVM.Controls.ContentControl;
using ATZ.MVVM.ViewModels.Utility;

namespace ATZ.MVVM.Controls.Window
{
    public class WindowViewModel : ContentControlViewModel
    {
        public WindowViewModel()
        {
            Model = new WindowModel();
        }
    }
}
