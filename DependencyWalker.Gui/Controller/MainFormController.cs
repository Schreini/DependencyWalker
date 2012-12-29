﻿using System.Collections.Generic;
using DependencyWalker.Gui.Services;
using DependencyWalker.Gui.Views;

namespace DependencyWalker.Gui.Controller
{
    public class MainFormController
    {
        IMainFormView View { get; set; }
        IDependencyResolver DependencyResolver { get; set; }

        public MainFormController(IMainFormView mainFormView, IDependencyResolver dependencyResolver)
        {
            View = mainFormView;
            DependencyResolver = dependencyResolver;
        }

        public void LoadDependencies(string assemblyName)
        {
            IList<string> dependencies = DependencyResolver.GetDependencyTree(assemblyName);
            View.SetDependencyTree(dependencies);
        }
    }
}