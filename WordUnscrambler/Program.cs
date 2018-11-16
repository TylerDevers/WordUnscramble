using System;
using System.IO;

namespace WordUnscrambler
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueWordUnscramble = true;

            do
            {
                Console.WriteLine("Please enter an option: F for File or M for Manual");
                //use null coalescing to check if option is null, if it is, set it to an empty string.
                var option = Console.ReadLine() ?? String.Empty; 

                switch (option.ToUpper())
                {
                    case "F":
                        // get location of File
                        Console.Write("Enter scrambled words file name: ");
                        ExecuteScrambledWordsInFileScenario();
                        break;
                    case "M":
                        // Get entered words
                        Console.Write("Enter scrambled words manually: ");
                        ExecuteScrambledWordsManualScenario();
                        break;
                    default:
                        Console.Write("Option not recognized.");
                        break;
                }
            } while ();
        }

        private static void ExecuteScrambledWordsManualScenario()
        {
            throw new NotImplementedException();
        }

        private static void ExecuteScrambledWordsInFileScenario()
        {
            throw new NotImplementedException();
        }
    }
}
