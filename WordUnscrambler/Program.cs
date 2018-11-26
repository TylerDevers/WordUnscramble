using System;
using System.Collections.Generic;
using System.IO;
using WordUnscrambler.Data;
using WordUnscrambler.Workers;

/*
 * Left unfinished. Unable to solve bugs
 */
namespace WordUnscrambler
{
    class Program
    {
        // external word list file
        private const string wordListFileName = "wordList.txt";
        private static readonly FileReader fileReader = new FileReader();
        private static readonly WordMatcher wordMatcher= new WordMatcher(); 

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

                var continueDecision = string.Empty;
                do
                {
                    Console.WriteLine("Do you want to continue? Y/N");
                    continueDecision = Console.ReadLine() ?? string.Empty;
                } while 
                    (
                    !continueDecision.Equals("Y", StringComparison.OrdinalIgnoreCase) && 
                    !continueDecision.Equals("N", StringComparison.OrdinalIgnoreCase)
                    );

                //start or stop loop based on user inputs in nested loop
                continueWordUnscramble = continueDecision.Equals("Y", StringComparison.OrdinalIgnoreCase);

            } while (continueWordUnscramble);
        }

        private static void ExecuteScrambledWordsManualScenario()
        {
            var manualInput = Console.ReadLine() ?? String.Empty;
            string[] scrambledWords = manualInput.Split(", ");
            DisplayUnmatchedScrambledWords();
        }


        private static void ExecuteScrambledWordsInFileScenario()
        {
            try 
            {
                var fileName = Console.ReadLine() ?? String.Empty;
                string[] scrambledWords = fileReader.Read(fileName);
                DisplayUnmatchedScrambledWords();
            }
            catch (Exception ex)
            {
                // throw new Exception(ex.Message);
                Console.WriteLine(Constants.errorSCrambledWordsCannotBeLoaded + ex.Message);
            }
        }

        private static void DisplayUnmatchedScrambledWords()
        {
            string[] wordList = fileReader.Read(Constants.wordListFileName);

            List<MatchedWord> matchedWords = wordMatcher.Match(scrambledWords, wordList);

            if (matchedWords.Any())
            {
                foreach (var matchedWord in matchedWords)
                {
                    Console.WriteLine("Match found for {0}: {1}", matchedWord.ScrambleWord, matchedWord.Word);
                }
            }
            else
            {
                Console.WriteLine("No matches have been found.");
            }
        }

    }
}
