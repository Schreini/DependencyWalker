﻿using System.Collections.Generic;

namespace DependencyWalker.Gui.Services
{
    public interface IDependencyResolver
    {
        IList<string> GetDependencyTree(string assemblyName);
    }
}
