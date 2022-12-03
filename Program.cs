using System.Collections;

namespace Day16and17_DSAProgram
{
    internal class Program
    {
        public static bool areAnagram(ArrayList str1,
                                ArrayList str2)
        {
            // Get lengths of both strings
            int n1 = str1.Count;
            int n2 = str2.Count;

            // If length of both strings is not
            // same, then they cannot be anagram
            if (n1 != n2)
            {
                return false;
            }

            // Sort both strings
            str1.Sort();
            str2.Sort();

            // Compare sorted strings
            for (int i = 0; i < n1; i++)
            {
                if (str1[i] != str2[i])
                {
                    return false;
                }
            }

            return true;
        }
        static void Main(string[] args)
        {
            // create and initialize new ArrayList
            ArrayList str1 = new ArrayList();
            str1.Add('h');
            str1.Add('e');
            str1.Add('a');
            str1.Add('r');
            str1.Add('t');

            // create and initialize new ArrayList
            ArrayList str2 = new ArrayList();
            str2.Add('e');
            str2.Add('a');
            str2.Add('r');
            str2.Add('t');
            str2.Add('h');

            // Function call
            if (areAnagram(str1, str2))
            {
                Console.WriteLine("The two strings are"
                                  + " anagram of each other");
            }
            else
            {
                Console.WriteLine("The two strings are not"
                                  + " anagram of each other");
            }
        }

    }
}

