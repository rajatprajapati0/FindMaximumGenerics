﻿using System;

namespace FindMaximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Maximum Problem using Generics");
            Console.WriteLine("enter 1- for integer value\nenter 2- for float value \nenter 3-string ");
            Test test = new Test();

            test.TestForMax();

        }
    }
    }

