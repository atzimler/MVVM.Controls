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
            //Assert.AreEqual(1, stackPanelViewModel.GetModel().Children.Count);
            //Assert.AreSame(textBoxViewModel.Model, stackPanelViewModel.GetModel().Children[0]);
        }

        [Test]
        [Apartment(ApartmentState.STA)]
        public void ProperlyAssemblyMvvmStructure()
        {
            var textBoxViewModel = new TextBoxViewModel();
            var textBoxModel = textBoxViewModel.GetModel();
            var stackPanelViewModel = new StackPanelViewModel();

            stackPanelViewModel.Children.Add(textBoxViewModel);

            // TODO: Verify that the Model, View and ViewModel structures are in sync after setting the Content of the VM (in that case just the M and VM structures) and after
            // setting the VM of the View. Currently it does not seem to be in sync.
            var window = DependencyResolver.Instance.Get<IModalWindow<WindowViewModel>>();
            var windowViewModel = new WindowViewModel { Content = stackPanelViewModel };

            VerifyPanelChildrenCollection(textBoxModel, stackPanelViewModel);
            // TODO: This somehow destroys the expectation of ProperlySetPanelChildrenModel() test. 
            window.SetViewModel(windowViewModel);
            VerifyPanelChildrenCollection(textBoxModel, stackPanelViewModel);

            // Model structure.
            //Assert.AreSame(windowViewModel.GetModel().Content, stackPanelViewModel.Model);

            var stackPanelModel = stackPanelViewModel.GetModel();
            Assert.IsNotNull(stackPanelModel);

            var stackPanelChildren = stackPanelModel.Children;
            Assert.IsNotNull(stackPanelChildren);

            Assert.AreEqual(1, stackPanelViewModel.GetModel().Children.Count);
            Assert.AreSame(textBoxViewModel.Model, stackPanelViewModel.GetModel().Children[0]);

            // ViewModel structure
            //Assert.AreSame(window.GetViewModel(), windowViewModel);
            //Assert.AreSame(windowViewModel.Content, stackPanelViewModel);
            //Assert.AreEqual(1, stackPanelViewModel.Children.ViewModelCollection.Count);
            //Assert.AreSame(textBoxViewModel, stackPanelViewModel.Children.ViewModelCollection[0]);


        }
    }
}
