using System.Windows;
using ATZ.MVVM.Controls.DockPanel;
using ATZ.MVVM.ViewModels.Utility;
using ATZ.MVVM.Views.Utility.Interfaces;

namespace ATZ.MVVM.Controls.Wpf
{
    /// <summary>
    /// Interaction logic for DockPanelView.xaml
    /// </summary>
    public partial class DockPanelView : IView<IViewModel<DockPanelModel>>
    {
        public UIElement UIElement => this;

        public DockPanelView()
        {
            InitializeComponent();
        }

        public void BindModel(IViewModel<DockPanelModel> vm)
        {
        }

        public void UnbindModel()
        {
        }
    }
}
