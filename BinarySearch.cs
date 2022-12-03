using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16and17_DSAProgram
{
    internal class BinarySearch
    {
        public void binarySearch(List<int> Geek)
        {

            // insert "3" in the List
            Console.WriteLine("\nInsert 3 :");

            // "3" insert into its original
            // position when the List is
            // sorted
            int index = Geek.BinarySearch(3);


            if (index < 0)
            {
                Geek.Insert(~index, 3);
            }

            foreach (int g in Geek)
            {

                // prints the sorted list
                // after inserting "3"
                Console.WriteLine(g);

            }
        }
    }
}
