using ATZ.MVVM.Controls.ItemsControl;
using ATZ.MVVM.ViewModels.Utility;

namespace ATZ.MVVM.Controls.TreeView
{
    public class TreeViewViewModel : ItemsControlViewModel, IViewModel<TreeViewModel>
    {
        public TreeViewViewModel()
        {
            Model = new TreeViewModel();
        }

        public new TreeViewModel GetModel()
        {
            return GetModel<TreeViewModel>();
        }

        public void SetModel(TreeViewModel model)
        {
            base.SetModel(model);
        }
    }
}
