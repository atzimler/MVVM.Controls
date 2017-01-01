using ATZ.MVVM.Controls.FrameworkElement;
using ATZ.MVVM.Controls.TreeView;
using ATZ.MVVM.ViewModels.Utility;
using ATZ.MVVM.Views.Utility.Interfaces;
using System.Windows;

namespace ATZ.MVVM.Controls.Wpf
{
    /// <summary>
    /// Interaction logic for TreeViewView.xaml
    /// </summary>
    public partial class TreeViewView : IView<IViewModel<TreeViewModel>>, IView<IViewModel<FrameworkElementModel>>
    {
        public UIElement UIElement => this;

        public TreeViewView()
        {
            InitializeComponent();
        }

        private void BindModelImplementation(IViewModel<TreeViewModel> vm)
        {

        }

        public void BindModel(IViewModel<FrameworkElementModel> vm) => BindModelImplementation((IViewModel<TreeViewModel>)vm);
        public void BindModel(IViewModel<TreeViewModel> vm) => BindModelImplementation(vm);

        public void UnbindModel()
        {
        }

    }
}
