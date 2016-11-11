using System;
using System.Collections.ObjectModel;
using ATZ.MVVM.Controls.FrameworkElement;
using ATZ.MVVM.Controls.Panel;
using ATZ.MVVM.ViewModels.Utility;
using ATZ.MVVM.ViewModels.Utility.Connectors;

namespace ATZ.MVVM.Controls.StackPanel
{
    public class StackPanelViewModel : PanelViewModel, IViewModel<StackPanelModel>
    {
        public StackPanelViewModel()
        {
            Model = new StackPanelModel();
        }

        public new StackPanelModel GetModel()
        {
            return (StackPanelModel) Model;
        }

        public void SetModel(StackPanelModel model)
        {
            Model = model;
        }
    }
}
