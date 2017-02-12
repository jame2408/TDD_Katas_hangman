namespace hangman.Tests
{
    public class HangmanForTest : Hangman
    {
        public const char VOWEL = 'a';
        public const char CONTAINED_CONSONANT = 'w';
        public const char NOT_CONTAINED_CONSONANT = 'z';
        public const char CONSONANT = 'b';
        public const int MAX_TRIES = 12;
        public const char ANY_CHAR = 'x';

        public HangmanForTest(string word) : base(word)
        {
        }

        public void typeWithoutCheckGameOver(char c)
        {
            type(c, () => { });
        }
    }
}
