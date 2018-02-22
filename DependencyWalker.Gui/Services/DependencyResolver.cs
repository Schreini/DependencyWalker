using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace DependencyWalker.Gui.Services
{
    public class DependencyResolver : IDependencyResolver
    {
        IList<string> _blackList = new List<string>();

        public DependencyResolver()
        {
            _blackList.Add("mscorlib");
            _blackList.Add("Castle");
            _blackList.Add("NHibernate");
            _blackList.Add("Elmah");
            _blackList.Add("DevExpress");
            _blackList.Add("Microsoft");
            _blackList.Add("AjaxControlToolkit");
            _blackList.Add("C1");
            _blackList.Add("mscorlib");
            //_blackList.Add("System\\..*");
            _blackList.Add("System");
            //_blackList.Add("EnvDTE");
                
        }

        public IList<string> GetDependencyTree(string assemblyName)
        {
            //var dependencies = new List<string>();
            //// TODO: das sollte wohl besser in einer eigenen AppDomain passieren
            //var assembly = Assembly.LoadFrom(assemblyName);
            //foreach (AssemblyName referencedAssembly in assembly.GetReferencedAssemblies())
            //{
            //    dependencies.Add(referencedAssembly.FullName);
            //}
            //return dependencies;
            throw new NotImplementedException();
        }

        public IList<string> GetDependencyTree(string path, string assemblyName, int indentNumber)
        {
            var dependencies = new List<string>();

            assemblyName = AppendDllExtensionIfNotPresent(assemblyName);

            // TODO: das sollte wohl besser in einer eigenen AppDomain passieren
            try
            {
                var assembly = Assembly.LoadFrom(Path.Combine(path, assemblyName));
                foreach (AssemblyName referencedAssembly in assembly.GetReferencedAssemblies())
                {
                    if (IsOnBlacklist(referencedAssembly.Name))
                        continue;

                    dependencies.Add(Indent(indentNumber, referencedAssembly.FullName));
                    dependencies.AddRange(GetDependencyTree(path, referencedAssembly.Name, indentNumber + 1));
                }
                return dependencies;
            }
            catch (FileNotFoundException)
            {
                return dependencies;
            }
        }

        private string AppendDllExtensionIfNotPresent(string assemblyName)
        {
            if (!assemblyName.ToLower().EndsWith(".dll")
                && !assemblyName.ToLower().EndsWith(".exe"))
                return assemblyName + ".dll";

            return assemblyName;
        }

        private bool IsOnBlacklist(string assemblyName)
        {
            foreach (var item in _blackList)
            {
                if (Regex.IsMatch(assemblyName, item))
                    return true;
            }
            return false;
        }

        public string Indent(int indentNumber, string text)
        {
            string indent = new string(' ', 4);
            var sb = new StringBuilder();
            for (int i = 0; i < indentNumber; i++)
                sb.Append(indent);

            sb.Append(text);
            return sb.ToString();
        }
    }
}
