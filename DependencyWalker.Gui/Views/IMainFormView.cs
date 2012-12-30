using System.Collections.Generic;

namespace DependencyWalker.Gui.Views
{
    public interface IMainFormView
    {
        void SetDependencyTree(IList<string> dependencies);
        string RootAssemblyNameAndPath { get; set; }
    }
}
