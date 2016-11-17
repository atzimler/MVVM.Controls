using System;
using ATZ.MVVM.Controls.ContentControl;
using ATZ.MVVM.Controls.FrameworkElement;
using ATZ.MVVM.ViewModels.Utility;
using ATZ.MVVM.Views.Utility.Connectors;
using ATZ.MVVM.Views.Utility.Interfaces;

namespace ATZ.MVVM.Controls.Wpf
{
    public class ContentConnector : CompositeViewToViewModelConnector<ContentControlModel, IView<IViewModel<ContentControlModel>>, FrameworkElementModel, IView<IViewModel<FrameworkElementModel>>>
    {
        public ContentConnector(IView<IViewModel<FrameworkElementModel>> componentView,
            IViewModel<ContentControlModel> viewModel,
            Func<IViewModel<ContentControlModel>, IViewModel<FrameworkElementModel>> componentViewModel,
            Func<IViewModel<ContentControlModel>, FrameworkElementModel> componentModel)
            : base(componentView, viewModel, componentViewModel, componentModel)
        {
        }
    }
}
