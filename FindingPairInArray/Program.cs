using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingPairInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many number to you have?");
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Please enter your number: ");
                arr1[i] = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("There are {0} pairs", CountPair(arr1));
        }
        static int CountPair(int[] arr)
        {
            int pair = 0;
            Array.Sort(arr);
            for (int i = 1; i < arr.Length;)
            {
                if (arr[i - 1] == arr[i])
                {
                    pair++;
                    i = i + 2;
                }
                else
                {
                    i++;
                }
            }
            return pair;
        }
    }
}
