namespace Day16and17_DSAProgram
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Binarysearch b = new Binarysearch();

            List<int> Geek = new List<int>() {
                              5, 6, 1, 9};

            Console.WriteLine("Original List");

            foreach (int g in Geek)
            {
                Console.WriteLine(g);
                // prints original List
            }

            Console.WriteLine("\nList in Sorted form");
            Geek.Sort();

            foreach (int g in Geek)
            {
                Console.WriteLine(g);
                // prints the sorted List
            }

         
        }
    }
    }
