using System.Windows;
using ATZ.DependencyInjection;
using ATZ.MVVM.Controls.FrameworkElement;
using ATZ.MVVM.Controls.Window;
using ATZ.MVVM.Views.Utility;
using ATZ.MVVM.Views.Utility.Connectors;
using ATZ.MVVM.Views.Utility.Interfaces;

namespace ATZ.MVVM.Controls.Wpf
{
    using TContentConnector = CompositeViewToViewModelConnector<
        WindowModel, WindowView, WindowViewModel,
        FrameworkElementModel, IView<FrameworkElementViewModel>, FrameworkElementViewModel>;

    /// <summary>
    /// Interaction logic for WindowView.xaml
    /// </summary>
    public partial class WindowView : IModalWindow<WindowViewModel>
    {
        private TContentConnector _contentConnector;

        public UIElement UIElement => this;

        public WindowView()
        {
            InitializeComponent();
        }

        public void BindModel(WindowViewModel viewModel)
        {
            var content = DependencyResolver.Instance.GetInterface<IView<FrameworkElementViewModel>>(typeof(IView<>), viewModel.Content.GetType());
            Content = content;

            _contentConnector = new TContentConnector(
                content,
                viewModel,
                vm => vm.Content,
                vm => vm.Model.Content);
        }

        public void UnbindModel()
        {
        }
    }
}
