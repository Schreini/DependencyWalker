using System.Collections.Generic;
using DependencyWalker.Gui.Controller;
using DependencyWalker.Gui.Services;

namespace DependencyWalker.Gui.Views
{
    public interface IMainFormView
    {
        string RootAssemblyName { get; }
        string RootAssemblyPath { get; }
        MainFormController Controller { get; set; }
        void SetDependencyTree2(IList<DependencyItem> dependendies);
        void SetResult(string result);
    }
}
