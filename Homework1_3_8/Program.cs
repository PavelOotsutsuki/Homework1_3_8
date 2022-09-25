using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_3_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            Console.Write("Введите сдвиг влево: ");
            int shiftLeft = Convert.ToInt32(Console.ReadLine());
            shiftLeft %=array.Length;
            int firstIndex = 0;

            for (int shift=0; shift<shiftLeft;shift++)
            {
                int firstElement = array[firstIndex];

                for (int arrayIndex=0; arrayIndex<array.Length-1; arrayIndex++)
                {
                    array[arrayIndex] = array[arrayIndex + 1];
                }

                array[array.Length - 1] = firstElement;
            }

            for (int arrayIndex = 0; arrayIndex < array.Length; arrayIndex++)
            {
                Console.Write(array[arrayIndex] + " ");
            }
        }
    }
}