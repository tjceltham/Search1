using System;

namespace Search1
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string[] students = { "jkashdfkhdfhfdas", "ukgh", "hgkjk", "Seb", "Tom" };

            findPerson(students);
        }

        static void findPerson(string[] v)
        {
            string s;
            Console.WriteLine("Who do you want to find?");
            s = Console.ReadLine();
            bool found = false; 

            for (int i = 0; i<v.Length; i++)
            {
                if (v[i] == s)
                {
                    Console.WriteLine("Found them at pos {0}", i);
                    found = true;
                }
            }

        }
    }
}
