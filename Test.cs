using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximum
{
    internal class Test
    {
        public void TestForMax()
        {
            Console.WriteLine("enter three no. to find maximum number TC1.1");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            IntMaxValue obj = new IntMaxValue();
            int max = obj.MaxValue(a, b, c);
            Console.WriteLine(max);
        }
     }
}
