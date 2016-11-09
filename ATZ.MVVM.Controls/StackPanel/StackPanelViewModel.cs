using System;
using System.Collections.ObjectModel;
using ATZ.MVVM.ViewModels.Utility;

namespace ATZ.MVVM.Controls.StackPanel
{
    public class StackPanelViewModel : BaseViewModel<StackPanelModel>
    {
        // TODO: Set correct type, paused for development of ATZ.MVVM 3.0
        // TODO: Set correct encapsulation.
        public ObservableCollection<object> Children { get; set; }

        protected override void BindModel()
        {
        }

        protected override void UnbindModel()
        {
        }

        public override void UpdateValidity(object sender, EventArgs e)
        {
        }
    }
}
