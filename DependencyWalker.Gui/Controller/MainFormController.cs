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
            IList<string> dependencies =
                DependencyResolver.GetDependencyTree(View.RootAssemblyPath, View.RootAssemblyName, 0);
            View.SetDependencyTree(dependencies);
        }
    }
}
