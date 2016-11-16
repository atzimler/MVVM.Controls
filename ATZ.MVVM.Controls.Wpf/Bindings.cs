using System;
using System.Collections;
using ATZ.DependencyInjection;
using ATZ.MVVM.Controls.StackPanel;
using ATZ.MVVM.Controls.TextBox;
using ATZ.MVVM.Controls.Window;
using ATZ.MVVM.ViewModels.Utility;
using ATZ.MVVM.Views.Utility.Interfaces;
using System.Collections.Generic;
using ATZ.MVVM.Controls.Button;
using ATZ.MVVM.Controls.TextBlock;
using ATZ.Reflection;

namespace ATZ.MVVM.Controls.Wpf
{
    public static class Bindings
    {
        private struct Mvvm
        {
            public Type Model;
            public Type View;
            public Type ViewModel;
        }

        private static readonly Mvvm[] MvvmTriplets = {
            new Mvvm { Model = typeof(ButtonModel), View = typeof(ButtonView), ViewModel = typeof(ButtonViewModel) },
            new Mvvm { Model = typeof(StackPanelModel), View = typeof(StackPanelView), ViewModel = typeof(StackPanelViewModel) },
            new Mvvm { Model = typeof(TextBlockModel), View = typeof(TextBlockView), ViewModel = typeof(TextBlockViewModel) },
            new Mvvm { Model = typeof(TextBoxModel), View = typeof(TextBoxView), ViewModel = typeof(TextBoxViewModel) }
        };

        public static void Initialize()
        {
            Views.Utility.Bindings.Initialize();

            DependencyResolver.Instance.Bind<IModalWindow<WindowViewModel>>().To<WindowView>();

            foreach (var mvvmTriplet in MvvmTriplets)
            {
                var iViewViewModel = typeof(IView<>).CloseTemplate(new[] {mvvmTriplet.ViewModel});
                var iViewModelModel = typeof(IViewModel<>).CloseTemplate(new[] {mvvmTriplet.Model});
                var iViewViewModelModel = typeof(IView<>).CloseTemplate(new[] {iViewModelModel});

                DependencyResolver.Instance.Bind(iViewViewModel).To(mvvmTriplet.View);
                DependencyResolver.Instance.Bind(iViewViewModelModel).To(mvvmTriplet.View);
            }
        }
    }
}
