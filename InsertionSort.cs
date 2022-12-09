using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16and17_DSAProgram
{
    public class InsertionSort
    {
        static void insert(int[] a) /* function to sort an aay with insertion sort */
        {
            int i, j, temp;
            int n = a.Length;
            for (i = 1; i < n; i++)
            {
                temp = a[i];
                j = i - 1;

                while (j >= 0 && temp <= a[j])  /* Move the elements greater than temp to one position ahead from their current position*/
                {
                    a[j + 1] = a[j];
                    j = j - 1;
                }
                a[j + 1] = temp;
            }
        }

        static void printArr(int[] a) /* function to print the array */
        {
            int i;
            int n = a.Length;
            for (i = 0; i < n; i++)
                Console.Write(a[i] + " ");
        }


    }
}
