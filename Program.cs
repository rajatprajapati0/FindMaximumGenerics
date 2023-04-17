using System;
using static System.Net.Mime.MediaTypeNames;

namespace FindMaximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Maximum Problem using Generics");

            Test test = new Test();
            test.TestForMax();

        }
    }
}
