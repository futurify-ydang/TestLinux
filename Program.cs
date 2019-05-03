using System;
using System.IO;

namespace PathTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Path.Combine(Environment.CurrentDirectory,"Data"));
        }
    }
}
