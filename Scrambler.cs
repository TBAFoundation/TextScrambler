namespace TextScrambler
{
    public class Scrambler
    {
        private ScramblerHistory history;

        public Scrambler()
        {
            history = new ScramblerHistory();
        }

        public string ScrambleText(ScramblerInput input)
        {
            string[] words = input.Text.Split("");

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                if (Array.Exists(input.WordsToScramble, w => w.Equals(word, StringComparison.OrdinalIgnoreCase)))
                {
                    words[i] = ScrambleWord(word, input.ScrambleCharacter);
                }
            }

            string scrambledText = string.Join(" ", words);
            history.AddScrambledText(input.Text, scrambledText);

            return scrambledText;
        }

        private string ScrambleWord(string word, char scrambleCharacter)
        {
            char[] characters = word.ToCharArray();
            for (int i = 0; i < characters.Length; i++)
            {
                if (characters[i] != ' ' && char.IsLetter(characters[i]))
                {
                    characters[i] = scrambleCharacter;
                }
            }
            return new string(characters);
        }

        public string GetScramblerHistory()
        {
            return history.GetHistory();
        }
    }

}