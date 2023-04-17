using System;

namespace FindMaximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Maximum Problem using Generics");
            Console.WriteLine("enter 1- for integer value\nenter 2- for float value \nenter 3-string name");
            Test test = new Test();
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    test.IntTestForMax();
                    break;

                case 2:
                    test.floatTestForMax();
                    break;

                case 3:
                    test.stringTestFormax();
                    break;

                default:
                    Console.WriteLine("enter correct option");
                    break;

            }
        }
    }
}
