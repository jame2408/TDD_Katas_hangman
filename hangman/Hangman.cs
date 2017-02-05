namespace hangman
{
    public class Hangman
    {
        private const string ALL_VOWELS = "aeiou";
        private const int MAX_TRIES = 12;
        private string _word;
        private string _used = ALL_VOWELS;
        private int _tries = MAX_TRIES;

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
            decreaseTries(c);
            appentToUsed(c);
        }

        private void decreaseTries(char c)
        {
            if (IsCharUsed(c) || !IsWordContained(c))
            {
                _tries--;
            }
        }

        private void appentToUsed(char c)
        {
            if (!IsCharUsed(c))
            {
                _used += c;
            }
        }
        private bool IsCharUsed(char c)
        {
            return _used.IndexOf(c) != -1;
        }

        private bool IsWordContained(char c)
        {
            return _word.IndexOf(c) != -1;
        }

        public int tries()
        {
            return _tries;
        }
    }
}