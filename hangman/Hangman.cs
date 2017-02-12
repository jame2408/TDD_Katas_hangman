﻿using System;

namespace hangman
{
    public class Hangman
    {
        private const string ALL_VOWELS = "aeiou";
        private const int MAX_TRIES = 12;
        private const string PLACEHOLDER = "_";
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


        public void type(char c, Action afterGameOver, Action afterGameWin)
        {
            decreaseTries(c);
            appentToUsed(c);
            checkGameOver(afterGameOver);
            checkGameWin(afterGameWin);
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

        private void checkGameOver(Action afterGameOver)
        {
            if (allTriesUsed())
            {
                afterGameOver.Invoke();
            }
        }

        private void checkGameWin(Action afterGameWin)
        {
            if (allCharDiscovered())
            {
                afterGameWin();
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

        private bool allTriesUsed()
        {
            return _tries == 0;
        }

        private bool allCharDiscovered()
        {
            return _word.Equals(discovered());
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