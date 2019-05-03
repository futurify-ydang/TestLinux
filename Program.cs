using System;
using System.IO;

namespace PathTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Path.Combine(Environment.CurrentDirectory, "Data");
            Console.WriteLine($"Using Path.Combine {path}");

            path = $"{Environment.CurrentDirectory}{Path.AltDirectorySeparatorChar}Data";
            Console.WriteLine($"Using Path.AltDirectorySeparatorChar {path}");
        }
    }
}
