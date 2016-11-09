using System.Windows;
using ATZ.DependencyInjection;
using ATZ.MVVM.Controls.StackPanel;
using ATZ.MVVM.Controls.TextBox;
using ATZ.MVVM.Controls.Window;
using ATZ.MVVM.Controls.Wpf;
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

            Bindings.Initialize();
        }

        private void OnButtonClicked(object sender, RoutedEventArgs e)
        {
            var textBoxViewModel = new TextBoxViewModel();
            var stackPanelViewModel = new StackPanelViewModel();
            stackPanelViewModel.Children.Add(textBoxViewModel);

            // TODO: Paused for ATZ.MVVM 3.0
            //var windowViewModel = new WindowViewModel {Content = stackPanelViewModel};

            var window = DependencyResolver.Instance.Get<IModalWindow<WindowViewModel>>();
            // TODO: Paused for ATZ.MVVM 3.0
            //window.SetViewModel(windowViewModel);

            window.ShowDialog();
        }
    }
}
