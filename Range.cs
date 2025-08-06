﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV01
{
    internal class Range<T> where T : IComparable<T>
    {
        public T Min { get; }
        public T Max { get; }

        public Range(T min, T max)
        {
            if (min.CompareTo(max) > 0)
                throw new ArgumentException("Min should not be greater than Max.");

            Min = min;
            Max = max;
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
        }

        public double Length()
        {
            try
            {
                dynamic min = Min;
                dynamic max = Max;
                return (double)(max - min);
            }
            catch
            {
                throw new InvalidOperationException("Length calculation only supported for numeric types.");
            }
        }
    }
}
