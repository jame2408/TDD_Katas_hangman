using System;

namespace hangman
{
    public class Judge
    {
        private Hangman _hangman;
        private string _word;

        public Judge(Hangman hangman, string word)
        {
            _hangman = hangman;
            _word = word;
        }

        public void checkGameOver(Action afterGameOver)
        {
            if (allTriesUsed())
            {
                afterGameOver.Invoke();
            }
        }

        private bool allTriesUsed()
        {
            return _hangman.tries() == 0;
        }

        public void checkGameWin(Action afterGameWin)
        {
            if (allCharDiscovered())
            {
                afterGameWin();
            }
        }
        private bool allCharDiscovered()
        {
            return _word.Equals(_hangman.discovered());
        }
    }
}