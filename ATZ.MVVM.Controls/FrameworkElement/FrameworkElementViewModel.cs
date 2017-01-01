using ATZ.DependencyInjection;
using ATZ.DependencyInjection.System;
using ATZ.MVVM.ViewModels.Utility;
using Ninject;
using System;
using System.Reflection;

namespace ATZ.MVVM.Controls.FrameworkElement
{
    public class FrameworkElementViewModel : BaseViewModel<FrameworkElementModel>, IViewModel<object>
    {
        protected override void BindModel()
        {
        }

        protected override void UnbindModel()
        {
        }

        // TODO: This should go into ATZ.MVVM.BaseViewModel if it works.
        // TODO: GetModel calls should be transformed to this instead casting in the GetModel().
        protected TModel GetModel<TModel>()
            where TModel : class
        {
            return GetModel() as TModel;
        }

        public new object GetModel()
        {
            return base.GetModel();
        }

        public override void UpdateValidity(object sender, EventArgs e)
        {
        }

        public void SetModel(object model)
        {
            var frameworkElementModel = model as FrameworkElementModel;
            if (model != null && frameworkElementModel == null)
            {
                DependencyResolver.Instance.Get<IDebug>().WriteLine($"Unable to handle model object of type {model.GetType()} in {MethodBase.GetCurrentMethod().Name}!");
            }

            base.SetModel(frameworkElementModel);
        }
    }
}
