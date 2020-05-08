using System;
using System.Diagnostics;
using System.Reflection;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("He           l  lo World!");
            Console.WriteLine("Fixes         AB#4   9 ");
            Console.WriteLine("Fixes AB #  49    ");
            Console.WriteLine("Fixes AB#49   ");
            Console.WriteLine("hello jasmine");

            var version = Assembly.GetEntryAssembly()
                .GetCustomAttribute<AssemblyInformationalVersionAttribute>()
                .InformationalVersion;


            Console.WriteLine("Version : "+version);

        }
    }
}