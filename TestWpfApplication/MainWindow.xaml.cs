using System.Linq.Expressions;
using System.Windows;
using System.Windows.Controls;
using ATZ.DependencyInjection;
using ATZ.MVVM.Controls.DockPanel;
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

            // TODO: If this works, this call can be simplyfied to be AddVM(VM) <-- it works because after this the Children of the Model and the VM are in sync.
            // TODO: There should be a way to disable direct access from client code to internal API of StackPanelViewModel.Children.Add - probably through interface. Also in that case probably the Connector should be named as Children and the Collection as ChildCollection.
            stackPanelViewModel.ChildrenConnector.Add(textBoxViewModel.Model, textBoxViewModel);

            // TODO: Verify that the Model, View and ViewModel structures are in sync after setting the Content of the VM (in that case just the M and VM structures) and after
            // setting the VM of the View. Currently it does not seem to be in sync.
            var window = DependencyResolver.Instance.Get<IModalWindow<WindowViewModel>>();
            var windowViewModel = new WindowViewModel { Content = stackPanelViewModel };
            window.SetViewModel(windowViewModel);

            window.ShowDialog();
        }
    }
}
