using System;
using System.Diagnostics;
using System.Reflection;

namespace Shared
{
    public class AsssemblyVersionHelper
    {
        public static Version GetApplicationProcessVersion()
        {
            var assembly = GetApplicationProcessAssembly();
            return assembly.GetName().Version;
        }

        public static Assembly GetApplicationProcessAssembly()
        {
            var assembly = Assembly.GetEntryAssembly();
            if (assembly is null) //MAUI
            {
                assembly = Assembly.GetCallingAssembly();
            }
            return assembly;
        }
    }
}
