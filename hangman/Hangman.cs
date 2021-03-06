﻿namespace hangman
{
    public class Hangman
    {
        private const string ALL_VOWELS = "aeiou";
        private const int MAX_TRIES = 12;
        private const string PLACEHOLDER = "_";
        private string _word;
        private string _used = ALL_VOWELS;
        private int _tries = MAX_TRIES;
        private readonly Judge _judge;

        public Hangman(string word)
        {
            this._word = word;
            _judge = new Judge(this, _word);
        }

        public int length()
        {
            return _word.Length;
        }

        public string used()
        {
            return _used;
        }


        public Judge type(char c)
        {
            decreaseTries(c);
            appentToUsed(c);
            return _judge;
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
            return _used.Contains(c.ToString());
        }

        private bool IsWordContained(char c)
        {
            return _word.Contains(c.ToString());
        }

        public int tries()
        {
            return _tries;
        }

        public string discovered()
        {
            return replaceConsonantToPlaceHolder();
        }

        private string replaceConsonantToPlaceHolder()
        {
            var discoveredChar = "";
            for (int i = 0; i < _word.ToCharArray().Length; i++)
            {
                discoveredChar += replaceConsonant(_word.ToCharArray()[i]);
            }
            return discoveredChar;
        }

        private string replaceConsonant(char c)
        {
            if (IsCharUsed(c))
            {
                return c.ToString();
            }
            return PLACEHOLDER;
        }
    }
}