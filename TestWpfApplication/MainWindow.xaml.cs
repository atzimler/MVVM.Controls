using System.Windows;
using ATZ.DependencyInjection;
using ATZ.MVVM.Controls.StackPanel;
using ATZ.MVVM.Controls.TextBox;
using ATZ.MVVM.Controls.Window;
using ATZ.MVVM.Views.Utility;
using ATZ.MVVM.Views.Utility.Interfaces;
using Ninject;

namespace TestWpfApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            ATZ.MVVM.Controls.Wpf.Bindings.Initialize();
        }

        private void OnButtonClicked(object sender, RoutedEventArgs e)
        {
            // TODO: This now works, except that it is rendered in size (0,0) because how the content is placed on the window. Probably need some additional features.

            var textBoxViewModel = new TextBoxViewModel();
            var stackPanelViewModel = new StackPanelViewModel();
            stackPanelViewModel.Children.Add(textBoxViewModel);

            var window = DependencyResolver.Instance.Get<IModalWindow<WindowViewModel>>();
            var windowViewModel = new WindowViewModel { Content = stackPanelViewModel };
            window.SetViewModel(windowViewModel);

            //var windowViewModel = window.GetViewModel();
            //windowViewModel.Content = stackPanelViewModel;

            window.ShowDialog();
        }
    }
}
