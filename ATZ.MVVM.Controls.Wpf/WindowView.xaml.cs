using ATZ.MVVM.Controls.ContentControl;
using ATZ.MVVM.Controls.Window;
using ATZ.MVVM.ViewModels.Utility;
using ATZ.MVVM.Views.Utility;
using ATZ.MVVM.Views.Utility.Interfaces;
using System.Windows;

namespace ATZ.MVVM.Controls.Wpf
{
    /// <summary>
    /// Interaction logic for WindowView.xaml
    /// </summary>
    public partial class WindowView : IModalWindow<IViewModel<WindowModel>>, IView<IViewModel<ContentControlModel>>
    {
        private ContentConnector _contentConnector;

        public UIElement UIElement => this;

        public WindowView()
        {
            InitializeComponent();

            this.SetViewModel(new WindowViewModel());
        }

        private void BindModelImplementation(IViewModel<WindowModel> viewModel)
        {
            ContentControlViewHelper.BindModel(this, (ContentControlViewModel)viewModel, ref _contentConnector);
        }

        public void BindModel(IViewModel<WindowModel> viewModel) => BindModelImplementation(viewModel);
        public void BindModel(IViewModel<ContentControlModel> viewModel)
            => BindModelImplementation((IViewModel<WindowModel>)viewModel);

        public void UnbindModel()
        {
        }
    }
}
