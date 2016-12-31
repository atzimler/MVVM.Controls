using ATZ.MVVM.Controls.ItemsControl;
using ATZ.MVVM.ViewModels.Utility;

namespace ATZ.MVVM.Controls.ListView
{
    public class ListViewViewModel : ItemsControlViewModel, IViewModel<ListViewModel>
    {
        public ListViewViewModel()
        {
            Model = new ListViewModel();
        }

        public new ListViewModel GetModel()
        {
            return (ListViewModel) Model;
        }

        public void SetModel(ListViewModel model)
        {
            base.SetModel(model);
        }
    }
}
