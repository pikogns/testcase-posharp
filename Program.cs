using System;
using System.Reflection;

namespace CSharpProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var machineName = Environment.MachineName;
            var userName = Environment.UserName;
            var dateTime = DateTime.Now;
            var assemblyPath = Assembly.GetExecutingAssembly().Location;
            Console.WriteLine($"0Test application started at {dateTime} on {machineName} from {userName} and path {assemblyPath}");
        }
    }
}
