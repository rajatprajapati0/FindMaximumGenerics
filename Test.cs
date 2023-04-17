using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximum
{
    internal class Test
    {
        public void IntTestForMax()
        {
            Console.WriteLine("enter three no. to find maximum number UC2");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            MaxValue obj = new MaxValue();
            int max = obj.IntMaxValue(a, b, c);
            Console.WriteLine(max);
        }
        public void floatTestForMax()
        {
            Console.WriteLine("enter three no. to find maximum number ");
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            MaxValue obj = new MaxValue();
            float max = obj.FloatMaxValue(a, b, c);
            Console.WriteLine(max);
        }
    }
}
