using System.Windows;
using ATZ.DependencyInjection;
using ATZ.MVVM.Controls.Button;
using ATZ.MVVM.Controls.StackPanel;
using ATZ.MVVM.Controls.TextBlock;
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
            var username = new TextBoxViewModel();
            var password = new TextBoxViewModel();

            var okButton = new ButtonViewModel {Content = new TextBlockViewModel("YYY")};

            var buttonPanel = new StackPanelViewModel();
            buttonPanel.Children.Add(okButton);

            var contentPanel = new StackPanelViewModel();
            contentPanel.Children.Add(username);
            contentPanel.Children.Add(password);
            contentPanel.Children.Add(buttonPanel);

            var window = DependencyResolver.Instance.Get<IModalWindow<WindowViewModel>>();
            var windowViewModel = new WindowViewModel { Content = contentPanel };
            window.SetViewModel(windowViewModel);

            window.ShowDialog();
        }
    }
}
