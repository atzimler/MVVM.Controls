using System.Collections.ObjectModel;
using ATZ.MVVM.Controls.FrameworkElement;

namespace ATZ.MVVM.Controls.Panel
{
    public class PanelModel : FrameworkElementModel
    {
        public ObservableCollection<FrameworkElementModel> Children { get; } = new ObservableCollection<FrameworkElementModel>();
    }
}
