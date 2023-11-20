namespace TextScrambler
{
    public class ScramblerInput
    {
        public required string Text { get; set; }
        public required string[] WordsToScramble { get; set; }
        public required char ScrambleCharacter { get; set; }
    }
}