using System.Collections.Generic;
using DependencyWalker.Gui.Controller;

namespace DependencyWalker.Gui.Views
{
    public interface IMainFormView
    {
        void SetDependencyTree(IList<string> dependencies);
        string RootAssemblyNameAndPath { get; }
        MainFormController Controller { get; set; }
    }
}
