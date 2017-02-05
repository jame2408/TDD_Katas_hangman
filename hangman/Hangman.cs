namespace hangman
{
    public class Hangman
    {
        private string _word;

        public Hangman(string word)
        {
            this._word = word;
        }

        public int length()
        {
            return _word.Length;
        }
    }
}