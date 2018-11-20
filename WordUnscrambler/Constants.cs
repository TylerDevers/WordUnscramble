namespace WordUnscrambler
{
    public class Constants
    {
        // use this file to store all stirng literals
        public const string optionsOnHowToEnterScrambledWords = "Enter scrambled word(s) manually or as a file.";
        public const string optionsOnContinuingTheProgram = "Would you like to continue? Y/N";

        public const string enterScrambledWordsViaFile = "Enter full path including the file name: ";
        public const string enterScrambledWordsManually = "Enter words manually, seperated by commas: ";
        public const string enterScrambledWordsOptionNotRecognized = "THe option was not recognized.";

        public const string errorSCrambledWordsCannotBeLoaded = "Scrambled words were not loaded because of an error";
        public const string errorProgramWillBeTerminated = "Error, the program will be terminated";

        public const string matchFound = "MATCH FOUND FOR {0}: {1}";
        public const string matchNotFound = "NO MATCHES FOUND";

        public const string yes = "Y";
        public const string no = "N";
        public const string file = "F";
        public const string manual = "M";

        public const string wordListFileName = "wordList.txt";
    }
}
 