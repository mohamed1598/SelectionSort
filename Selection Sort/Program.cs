using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 64, 25, 12, 22, 11 };
            Console.WriteLine("UnSorted array");
            printArray(arr);
            SelectionSort(arr);
            Console.WriteLine("Sorted array");
            printArray(arr);
            Console.Read();
        }
        static void SelectionSort(int[] array)
        {
            int arrayLength = array.Length;
            for(int i = 0; i < arrayLength; i++)
            {
                int minIndex = i;
                for(int j = i + 1; j < arrayLength ; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }
        }
        static void printArray(int[] array)
        {
            for (int i = 0; i < array.Length; ++i)
                Console.Write(array[i] + " ");
            Console.WriteLine();
        }
    }
}
