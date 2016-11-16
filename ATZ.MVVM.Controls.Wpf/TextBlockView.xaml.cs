using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ATZ.MVVM.Controls.FrameworkElement;
using ATZ.MVVM.Controls.TextBlock;
using ATZ.MVVM.ViewModels.Utility;
using ATZ.MVVM.Views.Utility.Interfaces;

namespace ATZ.MVVM.Controls.Wpf
{
    /// <summary>
    /// Interaction logic for TextBlockView.xaml
    /// </summary>
    public partial class TextBlockView : IView<IViewModel<TextBlockModel>>, IView<IViewModel<FrameworkElementModel>>
    {
        public UIElement UIElement => this;

        public TextBlockView()
        {
            InitializeComponent();
        }

        private void BindModelImplementation(IViewModel<TextBlockModel> vm)
        {
        }

        public void BindModel(IViewModel<TextBlockModel> vm) => BindModelImplementation(vm);

        public void BindModel(IViewModel<FrameworkElementModel> vm)
            => BindModelImplementation((IViewModel<TextBlockModel>) vm);

        public void UnbindModel()
        {
        }
    }
}
