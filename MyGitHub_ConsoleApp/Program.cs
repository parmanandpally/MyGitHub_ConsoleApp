using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGitHub_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Console App Project");
            Console.WriteLine("Implemented using GitHub Repository");
            Console.WriteLine("Area = {0}",AreaOfRectangle(12,22));
        }
        static double AreaOfRectangle(double l, double b)
        {
            return l * b;
        }
    }
}
