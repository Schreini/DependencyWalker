using System;
using System.Collections.Generic;
using System.IO;
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
            View.Controller = this;
        }

        public void LoadDependencies()
        {
            IList<DependencyItem> dependencies = new List<DependencyItem>();
            var result = DependencyResolver.GetDependencyTree2(View.RootAssemblyPath, View.RootAssemblyName, dependencies);
            View.SetDependencyTree2(dependencies);
            View.SetResult(result);
        }
    }
}
