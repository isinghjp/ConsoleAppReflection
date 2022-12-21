using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ConsoleAppReflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string asmPath = "";
            Assembly assembly = Assembly.LoadFrom(asmPath);    
        }
        public static void ShowAssemblyDetails(Assembly assembly) 
        {
            Console.WriteLine($"Full Name: {assembly.FullName}\n GAC: {assembly.GlobalAssemblyCache}\n Location: {assembly.Location}");

        }
    }
}
