using Shared;

using System;

namespace VersionTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assembly: " + AsssemblyVersionHelper.GetApplicationProcessAssembly());
            Console.WriteLine("Version: " + AsssemblyVersionHelper.GetApplicationProcessVersion());
        }
    }
}
