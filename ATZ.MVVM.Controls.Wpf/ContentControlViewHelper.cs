using ATZ.DependencyInjection;
using ATZ.MVVM.Controls.ContentControl;
using ATZ.MVVM.Controls.FrameworkElement;
using ATZ.MVVM.ViewModels.Utility;
using ATZ.MVVM.Views.Utility.Interfaces;

namespace ATZ.MVVM.Controls.Wpf
{
    public static class ContentControlViewHelper
    {
        private static IView<IViewModel<FrameworkElementModel>> CreateContentView(object contentViewModel)
        {
            var contentViewModelType = contentViewModel?.GetType();
            // ReSharper disable once ConvertIfStatementToReturnStatement => Converting to ?: operator in this case does not improve readability.
            if (contentViewModelType == null)
            {
                return null;
            }

            return DependencyResolver.Instance.GetInterface<IView<IViewModel<FrameworkElementModel>>>(typeof(IView<>), contentViewModelType);
        }

        public static void BindModel(
            IView<IViewModel<ContentControlModel>> view,
            ContentControlViewModel viewModel,
            // ReSharper disable once RedundantAssignment => Partial purpose of the helper method is to initialize this connector.
            ref ContentConnector connector)
        {
            var contentViewModel = viewModel.Content;
            var contentView = CreateContentView(contentViewModel);

            var property = view.GetType().GetProperty(nameof(System.Windows.Controls.ContentControl.Content));
            var setMethod = property.GetSetMethod();
            setMethod.Invoke(view, new object[]{contentView});

            connector = new ContentConnector(
                contentView,
                viewModel,
                vm => ((ContentControlViewModel)vm).Content,
                vm => vm.GetModel().Content);
        }
    }
}
