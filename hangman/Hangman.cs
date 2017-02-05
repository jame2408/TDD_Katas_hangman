namespace hangman
{
    public class Hangman
    {
        private const string ALL_VOWELS = "aeiou";
        private string _word;
        private static string _used = ALL_VOWELS;

        public Hangman(string word)
        {
            this._word = word;
        }

        public int length()
        {
            return _word.Length;
        }

        public string used()
        {
            return _used;
        }


        public void type(char c)
        {
            if (!IsCharUsed(c))
            {
                _used += c;
            }
        }

        private static bool IsCharUsed(char c)
        {
            return _used.IndexOf(c) != -1;
        }
    }
}