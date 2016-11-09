using System.Collections.ObjectModel;
using ATZ.MVVM.Controls.FrameworkElement;

namespace ATZ.MVVM.Controls.Panel
{
    public class PanelViewModel : FrameworkElementViewModel
    {
        public ObservableCollection<FrameworkElementViewModel> Children { get; } = new ObservableCollection<FrameworkElementViewModel>();
    }
}
