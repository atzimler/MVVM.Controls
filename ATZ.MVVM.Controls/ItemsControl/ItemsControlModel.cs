using System.Collections.ObjectModel;
using ATZ.MVVM.Controls.Control;

namespace ATZ.MVVM.Controls.ItemsControl
{
    public class ItemsControlModel : ControlModel
    {
        public ObservableCollection<object> Items { get; } = new ObservableCollection<object>();
    }
}
