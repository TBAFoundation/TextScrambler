namespace TextScrambler
{
        public static class Menu
    {
        private static Scrambler scrambler;

        public static void StartScrambling()
        {
            scrambler = new Scrambler();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Text Scrambler ===");
                Console.WriteLine("1. Scramble Text");
                Console.WriteLine("2. View Scrambler History");
                Console.WriteLine("3. Exit");
                Console.WriteLine("======================");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine()!;

                switch (choice)
                {
                    case "1":
                        ScrambleTextOption();
                        break;
                    case "2":
                        ViewScramblerHistoryOption();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }

        private static void ScrambleTextOption()
        {
            Console.Clear();
            Console.WriteLine("=== Scramble Text ===");

            Console.Write("Enter the text: ");
            string text = Console.ReadLine()!;

            Console.Write("Enter the word(s) to be scrambled (separated by spaces): ");
            string wordsToScrambleInput = Console.ReadLine()!;
            string[] wordsToScramble = wordsToScrambleInput.Split(' ');

            Console.Write("Enter the character(s) to use for scrambling: ");
            char scrambleCharacter = Console.ReadKey().KeyChar;
            Console.WriteLine();

            ScramblerInput input = new ScramblerInput
            {
                Text = text,
                WordsToScramble = wordsToScramble,
                ScrambleCharacter = scrambleCharacter
            };

            string scrambledText = scrambler.ScrambleText(input);

            Console.WriteLine("Scrambled text:");
            Console.WriteLine(scrambledText);
        }

        private static void ViewScramblerHistoryOption()
        {
            Console.Clear();
            Console.WriteLine("=== Scrambler History ===");

            string history = scrambler.GetScramblerHistory();

            if (string.IsNullOrEmpty(history))
            {
                Console.WriteLine("No history available.");
            }
            else
            {
                Console.WriteLine(history);
            }
        }
    }
}