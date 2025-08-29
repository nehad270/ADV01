using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV01
{
    internal class Swap
    {
        public static void swap<T>(ref T a,ref T b) 
        {
            T temp = a;
            a = b;

            b = temp;
        }
        public static void buble(int[] array) 
        {
            if (array is not null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for(int j = 0;j<array.Length-1-i;j++)
                    {
                        if (array[j] > array[j + 1])
                        {
                            swap(ref array[j], ref array[j + 1]);
                        }
                    }

                }
            }
        }
    }
}
