using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal  class Helper <T> where T : IComparable<T>
    {

        T salary;
        public static void SWAP(ref int x, ref int y)
        {
            int Temp = x;
            x = y;
            y = Temp;
        }
        public static void SWAP(ref double x, ref double y)
        {
            double Temp = x;
            x = y;
            y = Temp;
        }
        public static void SWAP(ref Point x, ref Point y)
        {
            Point Temp = x;
            x = y;
            y = Temp;
        }

        public static void SWAP(object x, object y)
        {

            object Temp = x;
            x = y;
            y = Temp;
        }





        public static void SWAP <T>(ref T x,ref T y)
        {
            T Temp = x;
            x = y;
            y = Temp;
        }


        public static int SearchArray(T[] Arr, T value)
        {
            if (Arr is not null)
            {
            for (int i = 0; i < Arr.Length; i++)
                {
                    if (value.Equals(Arr[i]))
                        return i;
                }

            }
            return -1;

        }

        public static void BubbleSort(T[] array)
        {
            if(array is not null)
            {
                for (int i = 0; i < array.Length /*5*/; i++)
                {
                    for (int j = 0; j < array.Length-i-1 /*2*/; j++)
                    {
                        if (array[j].CompareTo(array[j+1]) ==1)
                            Helper<T>.SWAP(ref array[j],ref array[j + 1]);

                    }
                }
            }
        }
    }
}
