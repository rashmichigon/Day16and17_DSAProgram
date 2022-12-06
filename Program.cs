using System.Collections;

namespace Day16and17_DSAProgram
{
    internal class Program
    {
        
    static void Main(String[] args)
        
        {
            int[] a = { 10, 29, 23, 6, 30, 15, 38, 40 };
            int n = a.Length;
            Console.Write("Before sorting array elements are - ");
            printArray(a, n);
            mergesort(a, 0, n - 1);
            Console.Write("\nAfter sorting array elements are - ");
            printArray(a, n);
        }

        private static void mergesort(int[] a, int v1, int v2)
        {
            throw new NotImplementedException();
        }

        private static void printArray(int[] a, int n)
        {
            throw new NotImplementedException();
        }

       
    }
    }


