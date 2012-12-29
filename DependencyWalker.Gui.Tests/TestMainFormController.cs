using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using DependencyWalker.Gui.Controller;
using DependencyWalker.Gui.Services;
using DependencyWalker.Gui.Views;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DependencyWalker.Gui.Tests
{
    [TestClass]
    public class TestMainFormController
    {
//        [TestInitialize] 
//        public void Init

        [TestMethod]
        public void TestMainFormController_LoadDependencyTree_ShouldCallDependencyResolver()
        {
            //Arrange
            var serviceMock = new Mock<IDependencyResolver>();
            var dependencies = new List<string>(){"Dummy.Assembly"};
            serviceMock.Setup(resolver => resolver.GetDependencyTree("")).Returns(dependencies);
            var viewMock = new Mock<IMainFormView>();

            var sut = new MainFormController(viewMock.Object, serviceMock.Object);
            //Act

            sut.LoadDependencies("");
            //Assert

            viewMock.Verify(view => view.SetDependencyTree(dependencies));
        }

    }
}
