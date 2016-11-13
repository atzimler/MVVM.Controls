using System;
using ATZ.MVVM.ViewModels.Utility;

namespace ATZ.MVVM.Controls.FrameworkElement
{
    public class FrameworkElementViewModel : BaseViewModel<FrameworkElementModel>
    {
        protected override void BindModel()
        {
        }

        protected override void UnbindModel()
        {
        }

        // TODO: This should go into ATZ.MVVM.BaseViewModel if it works.
        protected TModel GetModel<TModel>()
            where TModel : class
        {
            return GetModel() as TModel;
        }

        public override void UpdateValidity(object sender, EventArgs e)
        {
        }
    }
}
