using System;
using System.Collections.Generic;

namespace DependencyWalker.Gui.Services
{
    public interface IDependencyResolver
    {
        IList<string> GetDependencyTree(string assemblyName);
        string GetDependencyTree2(string path, string assemblyName, IList<DependencyItem> dependencies);
    }
}
