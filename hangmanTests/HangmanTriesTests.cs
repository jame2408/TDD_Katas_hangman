using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace hangman.Tests
{
    [TestClass]
    public class HangmanTriesTests
    {
        Hangman hangman = new Hangman("word");
        private const int MAX_TRIES = 12;
        private const char VOWEL = 'a';
        private const char CONTAINED_CONSONANT = 'w';
        private const char NOT_CONTAINED_CONSONANT = 'x';

        [TestMethod]
        public void tries_when_game_start()
        {

            Assert.AreEqual(MAX_TRIES, hangman.tries());
        }

        [TestMethod]
        public void tries_when_type_a_vowel()
        {
            hangman.type(VOWEL);

            Assert.AreEqual(MAX_TRIES - 1, hangman.tries());
        }

        [TestMethod]
        public void tries_when_type_a_contained_consonant()
        {
            hangman.type(CONTAINED_CONSONANT);

            Assert.AreEqual(MAX_TRIES, hangman.tries());
        }

        [TestMethod]
        public void tries_when_type_the_same_contained_consonant_again()
        {
            hangman.type(CONTAINED_CONSONANT);
            hangman.type(CONTAINED_CONSONANT);

            Assert.AreEqual(MAX_TRIES - 1, hangman.tries());
        }

        [TestMethod]
        public void tries_when_type_not_contained_consonant()
        {
            hangman.type(NOT_CONTAINED_CONSONANT);

            Assert.AreEqual(MAX_TRIES - 1, hangman.tries());
        }
    }
}
