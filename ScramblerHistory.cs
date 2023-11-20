namespace TextScrambler
{
    public class ScramblerHistory
    {
        private List<string> history;

        public ScramblerHistory()
        {
            history = new List<string>();
        }

        public void AddScrambledText(string originalText, string scrambledText)
        {
            history.Add($"{originalText} => {scrambledText}");
        }

        public string GetHistory()
        {
            return string.Join("\n", history);
        }
    }
}