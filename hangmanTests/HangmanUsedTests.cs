using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace hangman.Tests
{
    [TestClass]
    public class HangmanUsedTests
    {
        Hangman hangman = new Hangman("word");
        private const string ALL_VOWELS = "aeiou";
        private const char VOWEL = 'a';
        private const char CONSONANT = 'b';

        [TestMethod]
        public void used_when_game_start()
        {
            Assert.AreEqual(ALL_VOWELS, hangman.used());
        }

        [TestMethod]
        public void used_when_type_a_vowel()
        {
            hangman.type(VOWEL);

            Assert.AreEqual(ALL_VOWELS, hangman.used());
        }

        [TestMethod]
        public void used_when_type_a_consonant()
        {
            hangman.type(CONSONANT);

            Assert.AreEqual(ALL_VOWELS + CONSONANT, hangman.used());
        }

        [TestMethod]
        public void used_when_type_the_same_consonant_again()
        {
            hangman.type(CONSONANT);
            hangman.type(CONSONANT);

            Assert.AreEqual(ALL_VOWELS + CONSONANT, hangman.used());
        }
    }
}