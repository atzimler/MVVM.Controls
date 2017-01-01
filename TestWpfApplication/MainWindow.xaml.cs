using ATZ.DependencyInjection;
using ATZ.MVVM.Controls.Button;
using ATZ.MVVM.Controls.ListView;
using ATZ.MVVM.Controls.StackPanel;
using ATZ.MVVM.Controls.TextBlock;
using ATZ.MVVM.Controls.TextBox;
using ATZ.MVVM.Controls.TreeView;
using ATZ.MVVM.Controls.Window;
using ATZ.MVVM.Views.Utility;
using ATZ.MVVM.Views.Utility.Interfaces;
using Ninject;
using System.Windows;

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

        private void OnShowDialogButtonClicked(object sender, RoutedEventArgs e)
        {
            var username = new TextBoxViewModel();
            var password = new TextBoxViewModel();

            var okButton = new ButtonViewModel { Content = new TextBlockViewModel("YYY") };

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

        private void OnShowListViewButtonClicked(object sender, RoutedEventArgs e)
        {
            var list = new ListViewViewModel();
            var window = DependencyResolver.Instance.Get<IModalWindow<WindowViewModel>>();
            var windowViewModel = new WindowViewModel { Content = list };
            window.SetViewModel(windowViewModel);

            list.GetModel().Items.Add(new TextBlockModel { Text = "XXX" });

            window.ShowDialog();
        }

        private void OnShowTreeViewButtonClicked(object sender, RoutedEventArgs e)
        {
            var tree = new TreeViewViewModel();
            var window = DependencyResolver.Instance.Get<IModalWindow<WindowViewModel>>();
            var windowViewModel = new WindowViewModel { Content = tree };
            window.SetViewModel(windowViewModel);

            tree.GetModel().Items.Add(new TextBlockModel { Text = "TopLevel1" });
            tree.GetModel().Items.Add(new TextBlockModel { Text = "TopLevel2" });
            //tree.GetModel().Items[0].Items.Add(new TextBlockModel { Text = "SubNode 1.1" });

            window.ShowDialog();
        }
    }
}
