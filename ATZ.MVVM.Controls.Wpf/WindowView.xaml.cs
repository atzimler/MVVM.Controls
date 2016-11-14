﻿using System.Windows;
using ATZ.DependencyInjection;
using ATZ.MVVM.Controls.ContentControl;
using ATZ.MVVM.Controls.FrameworkElement;
using ATZ.MVVM.Controls.Window;
using ATZ.MVVM.ViewModels.Utility;
using ATZ.MVVM.Views.Utility;
using ATZ.MVVM.Views.Utility.Connectors;
using ATZ.MVVM.Views.Utility.Interfaces;

namespace ATZ.MVVM.Controls.Wpf
{
    using TContentConnector = CompositeViewToViewModelConnector<WindowModel, WindowView,FrameworkElementModel, IView<IViewModel<FrameworkElementModel>>>;

    /// <summary>
    /// Interaction logic for WindowView.xaml
    /// </summary>
    public partial class WindowView : IModalWindow<IViewModel<WindowModel>>, IView<IViewModel<ContentControlModel>>
    {
        private TContentConnector _contentConnector;

        public UIElement UIElement => this;

        public WindowView()
        {
            InitializeComponent();

            this.SetViewModel(new WindowViewModel());
        }

        private IView<IViewModel<FrameworkElementModel>> CreateContentView(FrameworkElementViewModel contentViewModel)
        {
            var contentViewModelType = contentViewModel?.GetType();
            if (contentViewModelType == null)
            {
                return null;
            }

            return DependencyResolver.Instance.GetInterface<IView<IViewModel<FrameworkElementModel>>>(typeof(IView<>), contentViewModelType);
        }

        private static FrameworkElementViewModel GetContentViewModel(IViewModel<WindowModel> vm)
        {
            return ((WindowViewModel) vm).Content;
        }

        private void BindModelImplementation(IViewModel<WindowModel> viewModel)
        {
            var contentViewModel = GetContentViewModel(viewModel);
            var contentView = CreateContentView(contentViewModel);

            _contentConnector = new TContentConnector(
                contentView,
                viewModel,
                GetContentViewModel,
                vm => vm.GetModel().Content);
        }

        public void BindModel(IViewModel<WindowModel> viewModel) => BindModelImplementation(viewModel);
        public void BindModel(IViewModel<ContentControlModel> viewModel)
            => BindModelImplementation((IViewModel<WindowModel>) viewModel);

        public void UnbindModel()
        {
        }
    }
}
