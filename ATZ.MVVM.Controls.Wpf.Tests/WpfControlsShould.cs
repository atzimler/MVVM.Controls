using System;
using System.Threading;
using ATZ.DependencyInjection;
using ATZ.MVVM.Controls.FrameworkElement;
using ATZ.MVVM.Controls.Panel;
using ATZ.MVVM.Controls.StackPanel;
using ATZ.MVVM.Controls.TextBox;
using ATZ.MVVM.Controls.Window;
using ATZ.MVVM.Views.Utility;
using ATZ.MVVM.Views.Utility.Interfaces;
using Ninject;
using NUnit.Framework;
using System.Windows.Controls;

namespace ATZ.MVVM.Controls.Wpf.Tests
{
    [TestFixture]
    public class WpfControlsShould
    {
        private void VerifyPanelChildrenCollection(FrameworkElementModel expectedChild, PanelViewModel panel)
        {
            Assert.AreSame(panel.Model, panel.GetModel());
            Assert.IsNotNull(panel.GetModel());
            Assert.AreEqual(1, panel.GetModel().Children.Count);
            Assert.AreSame(expectedChild, panel.GetModel().Children[0]);
        }

        [SetUp]
        public void SetUp()
        {
            Bindings.Initialize();
        }

        [Test]
        [Apartment(ApartmentState.STA)]
        public void ProperlySetPanelChildrenModel()
        {
            var textBoxViewModel = new TextBoxViewModel();
            var stackPanelViewModel = new StackPanelViewModel();

            stackPanelViewModel.Children.Add(textBoxViewModel);

            VerifyPanelChildrenCollection(textBoxViewModel.GetModel(), stackPanelViewModel);
        }

        [Test]
        [Apartment(ApartmentState.STA)]
        public void ProperlyAssemblyMvvmStructure()
        {
            var expectedTextBoxViewModel = new TextBoxViewModel();
            var expectedTextBoxModel = expectedTextBoxViewModel.GetModel();

            var expectedStackPanelViewModel = new StackPanelViewModel();
            var expectedStackPanelModel = expectedStackPanelViewModel.GetModel();
            expectedStackPanelViewModel.Children.Add(expectedTextBoxViewModel);

            var expectedWindowViewModel = new WindowViewModel { Content = expectedStackPanelViewModel };
            var window = DependencyResolver.Instance.Get<IModalWindow<WindowViewModel>>();

            Assert.AreSame(expectedStackPanelModel, expectedWindowViewModel.GetModel().Content);
            VerifyPanelChildrenCollection(expectedTextBoxModel, expectedStackPanelViewModel);

            window.SetViewModel(expectedWindowViewModel);
            VerifyPanelChildrenCollection(expectedTextBoxModel, expectedStackPanelViewModel);

            var actualWindowViewModel = window.GetViewModel();

            // Model structure.
            var actualStackPanelModel = (StackPanelModel)actualWindowViewModel.GetModel().Content;
            Assert.AreSame(expectedStackPanelModel, actualStackPanelModel);

            var actualStackPanelChildren = actualStackPanelModel.Children;
            Assert.IsNotNull(actualStackPanelChildren);
            Assert.AreEqual(1, actualStackPanelChildren.Count);

            var actualTextBoxModel = actualStackPanelChildren[0];
            Assert.AreSame(expectedTextBoxModel, actualTextBoxModel);


            // ViewModel structure
            Assert.AreSame(expectedWindowViewModel, actualWindowViewModel);

            var actualStackPanelViewModel = (StackPanelViewModel)actualWindowViewModel.Content;
            Assert.AreSame(expectedStackPanelViewModel, actualStackPanelViewModel);

            var actualChildren = actualStackPanelViewModel.Children.ViewModelCollection;
            Assert.AreEqual(1, actualChildren.Count);

            var actualTextBoxViewModel = actualChildren[0];
            Assert.AreSame(expectedTextBoxViewModel, actualTextBoxViewModel);



            // View structure.

            var actualStackPanelView = ((WindowView)window).Content;
            Assert.IsNotNull(actualStackPanelView);
            Assert.AreSame(expectedStackPanelViewModel, actualStackPanelView.GetViewModel<StackPanelViewModel>());


            //var actualChildren = actualStackPanelViewModel.Children;

            //var actualTextBoxViewModel = actualChildren.ViewModelCollection[0];
            //Assert.AreSame(expectedTextBoxViewModel, actualTextBoxViewModel);



            //var actualStackPanelView = (StackPanelView)((WindowView)window).Content;
            //Assert.AreSame(expectedStackPanelViewModel, actualStackPanelView.GetViewModel<StackPanelViewModel>());

            //var actualStackPanelChildrenCollection = actualStackPanelView.Children;
            //Assert.AreEqual(1, actualStackPanelChildrenCollection.Count);

            //var actualTextBoxView = (TextBoxView)actualStackPanelChildrenCollection[0];
            //Assert.AreSame(expectedTextBoxViewModel, actualTextBoxView.GetViewModel<TextBoxViewModel>());

            //Assert.AreEqual(1, expectedStackPanelViewModel.GetModel().Children.Count);
            //Assert.AreSame(expectedTextBoxViewModel.Model, expectedStackPanelViewModel.GetModel().Children[0]);

            //// ViewModel structure
            //Assert.AreSame(window.GetViewModel(), expectedWindowViewModel);
            //Assert.AreSame(expectedWindowViewModel.Content, expectedStackPanelViewModel);
            //Assert.AreEqual(1, expectedStackPanelViewModel.Children.ViewModelCollection.Count);
            //Assert.AreSame(expectedTextBoxViewModel, expectedStackPanelViewModel.Children.ViewModelCollection[0]);

            //// View structure, verifying through the ViewModels.
            //Assert.AreSame(expectedStackPanelViewModel, window.GetViewModel().Content);


        }
    }
}
