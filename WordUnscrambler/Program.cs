using System;
using System.IO;

namespace WordUnscrambler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] testing = { "the first line", "the second line", "the third line" };
            // File.WriteAllLines("testingFile.txt", testing);
            foreach (string line in File.ReadLines("testingFile.txt"))
            {
                Console.WriteLine(line);
            }
        }
    }
}
