﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximum
{
    internal class MaxValue
    {
        public int IntMaxValue(int firstValue, int secondValue, int thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0) { return firstValue; }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0) { return secondValue; }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0) { return thirdValue; }

            return thirdValue;

        }
        public float FloatMaxValue(float firstValue, float secondValue, float thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(secondValue) > 0) { return firstValue; }
            if (secondValue.CompareTo(thirdValue) > 0 && secondValue.CompareTo(thirdValue) > 0) { return secondValue; }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0) { return thirdValue; }

            return secondValue;
        }
        public string stringMaxvalue(string firstValue, string secondValue, string thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0) { return firstValue; }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0) { return secondValue; }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0) { return thirdValue; }
            return firstValue;
        }
    }
}
