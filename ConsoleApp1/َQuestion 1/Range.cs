﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._َQuestion_1
{
    public class Range<T> where T : IComparable<T>
    {
        public T Min { get; set; }
        public T Max { get; set; }

        public Range(T min, T max)
        {
            if (min.CompareTo(max) > 0)
                Console.WriteLine("Min Must be greater then Max");

            Min = min;
            Max = max;
        }
        public bool IsInRange(T value)
        {
            return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
        }
        public dynamic lengthBetween() 
        {
            return (dynamic)Max -  (dynamic)Min;
        }

    }

    }

