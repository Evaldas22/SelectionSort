using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] unsortedArray = new int[] { 3, 5, 2, 4, 1 };
            Console.WriteLine("Unsorted Array:");
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                Console.Write($"{unsortedArray[i]} ");
            }
            Console.WriteLine();

            int[] sortedArray = Sort(unsortedArray);
            Console.WriteLine("Sorted Array:");
            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.Write($"{sortedArray[i]} ");
            }
            Console.WriteLine();
        }

        public static int[] Sort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)    
            {
                int minimum = i;

                for (int j = i+1; j < numbers.Length; j++)    
                {
                    if (numbers[j] < numbers[minimum])
                    {
                        minimum = j;
                    }
                }
                //here make a swap
                int temp = numbers[i];
                numbers[i] = numbers[minimum];
                numbers[minimum] = temp;

            }

            return numbers;
        }
    }
}
