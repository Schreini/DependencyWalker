using System.Collections.Generic;
using System.Reflection;

namespace DependencyWalker.Gui.Services
{
    public class DependencyResolver : IDependencyResolver
    {
        public IList<string> GetDependencyTree(string assemblyName)
        {
            var dependencies = new List<string>();
            // TODO: das sollte wohl besser in einer eigenen AppDomain passieren
            var assembly = Assembly.LoadFrom(assemblyName);
            foreach (AssemblyName referencedAssembly in assembly.GetReferencedAssemblies())
            {
                dependencies.Add(referencedAssembly.FullName);
            }
            return dependencies;
        }
    }
}
