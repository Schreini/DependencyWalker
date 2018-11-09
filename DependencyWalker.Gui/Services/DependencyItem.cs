using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DependencyWalker.Gui.Services
{
    public class DependencyItem
    {
        private DependencyItem(Guid id, Guid parentId, MyAssemblyInfo assemblyInfo)
        {
            Id = id;
            ParentId = parentId;
            AssemblyInfo = assemblyInfo;
        }

        public Guid Id { get; }
        public Guid ParentId { get; }
        private String FullName { get; }

        public string Name => AssemblyInfo.Name;

        public string ProcessorArchitecture => AssemblyInfo.ProcessorArchitecture;

        public string VersionCompatibility => AssemblyInfo.VersionCompatibility;

        public string Version => AssemblyInfo.Version;

        public string CultureInfo => AssemblyInfo.CultureInfo;

        public string PublicKeyToken => AssemblyInfo.PublicKeyToken;

        public string LoadingError => AssemblyInfo.LoadingError;

        public MyAssemblyInfo AssemblyInfo { get; }

        public static DependencyItem CreateFrom(Guid id, Guid parentId, AssemblyName assemblyName)
        {
            MyAssemblyInfo info = CreateAssemblyInfo(assemblyName);
            var item = new DependencyItem(id, parentId, info);
            return item;
        }

        private static Dictionary<string, MyAssemblyInfo> AssemblyInfoRegistry =
            new Dictionary<string, MyAssemblyInfo>();

        private static MyAssemblyInfo CreateAssemblyInfo(AssemblyName assemblyName)
        {
            if (!AssemblyInfoRegistry.TryGetValue(assemblyName.FullName, out var result))
            {
                result = new MyAssemblyInfo(
                    assemblyName.Name,
                    assemblyName.ProcessorArchitecture.ToString(),
                    assemblyName.VersionCompatibility.ToString(),
                    assemblyName.Version.ToString(),
                    assemblyName.CultureInfo.ToString(),
                    ItemPublicKeyToken(assemblyName));
                AssemblyInfoRegistry.Add(assemblyName.FullName, result);
            }

            return result;
        }

        private static string ItemPublicKeyToken(AssemblyName assemblyName)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var b in assemblyName.GetPublicKeyToken())
            {
                sb.Append($"{b:x2}");
            }

            return sb.ToString();
        }

        protected bool Equals(DependencyItem other)
        {
            return string.Equals(AssemblyInfo.Name, other.AssemblyInfo.Name)
                   && string.Equals(AssemblyInfo.Version, other.AssemblyInfo.Version)
                   && string.Equals(AssemblyInfo.PublicKeyToken, other.AssemblyInfo.PublicKeyToken);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((DependencyItem)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = AssemblyInfo.Name.GetHashCode();
                hashCode = (hashCode * 397) ^ AssemblyInfo.Version.GetHashCode();
                hashCode = (hashCode * 397) ^ AssemblyInfo.PublicKeyToken.GetHashCode();
                return hashCode;
            }
        }
    }

    public class MyAssemblyInfo
    {
        public MyAssemblyInfo(
            string name,
            string processorArchitecture,
            string versionCompatibility,
            string version,
            string cultureInfo,
            string publicKeyToken)
        {
            Name = name;
            ProcessorArchitecture = processorArchitecture;
            VersionCompatibility = versionCompatibility;
            Version = version;
            CultureInfo = cultureInfo;
            PublicKeyToken = publicKeyToken;
        }

        public string Name { get; }
        public string ProcessorArchitecture { get; }
        public string VersionCompatibility { get; }
        public string Version { get; }
        public string CultureInfo { get; }
        public string PublicKeyToken { get; }
        public string LoadingError { get; set; }

        protected bool Equals(MyAssemblyInfo other)
        {
            return string.Equals(Name, other.Name)
                   && string.Equals(ProcessorArchitecture, other.ProcessorArchitecture)
                   && string.Equals(VersionCompatibility, other.VersionCompatibility)
                   && string.Equals(Version, other.Version)
                   && string.Equals(CultureInfo, other.CultureInfo)
                   && string.Equals(PublicKeyToken, other.PublicKeyToken);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != GetType())
                return false;
            return Equals((MyAssemblyInfo) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = Name != null ? Name.GetHashCode() : 0;
                hashCode = (hashCode * 397) ^ (ProcessorArchitecture != null ? ProcessorArchitecture.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (VersionCompatibility != null ? VersionCompatibility.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Version != null ? Version.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (CultureInfo != null ? CultureInfo.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (PublicKeyToken != null ? PublicKeyToken.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
}