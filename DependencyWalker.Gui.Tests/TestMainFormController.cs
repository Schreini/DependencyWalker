﻿using System;
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
        private Mock<IDependencyResolver> _serviceMock;
        private List<string> _dependencies;
        private Mock<IMainFormView> _viewMock;

        [TestInitialize]
        public void Initialize()
        {
            _serviceMock = new Mock<IDependencyResolver>();
            _dependencies = new List<string>() { "Dummy.Assembly" };
            // TODO: wie return unabhängig vom aufrufwert???
            _serviceMock.Setup(resolver => resolver.GetDependencyTree(It.IsAny<string>())).Returns (_dependencies);
            _viewMock = new Mock<IMainFormView>();
        }


        [TestMethod]
        public void TestMainFormController_LoadDependencyTree_ShouldAskViewForAssemblyName()
        {
            //Arrange
            var sut = new MainFormController(_viewMock.Object, _serviceMock.Object);

            //Act
            sut.LoadDependencies();

            //Assert
            _viewMock.VerifyGet(view => view.RootAssemblyNameAndPath);
        }

        [TestMethod]
        public void TestMainFormController_LoadDependencyTree_ShouldDelegateToDependencyResolver()
        {
            //Arrange
            var sut = new MainFormController(_viewMock.Object, _serviceMock.Object);

            //Act
            sut.LoadDependencies();

            //Assert
            _serviceMock.Verify(service=>service.GetDependencyTree(It.IsAny<string>()));
        }


        [TestMethod]
        public void TestMainFormController_LoadDependencyTree_ShouldSetDependencyTreeOnView()
        {
            //Arrange
            var sut = new MainFormController(_viewMock.Object, _serviceMock.Object);

            //Act
            sut.LoadDependencies();

            //Assert
            _viewMock.Verify(view => view.SetDependencyTree(_dependencies));
        }

    }
}
