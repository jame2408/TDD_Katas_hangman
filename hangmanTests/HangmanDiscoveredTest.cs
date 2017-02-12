using Microsoft.VisualStudio.TestTools.UnitTesting;
using static hangman.Tests.HangmanForTest;
namespace hangman.Tests
{
    [TestClass]
    public class HangmanDiscoveredTest
    {
        private const string PLACEHOLDER = "_";
        private const string ONE_CONSONANT_WORD = "b";
        private const string ONE_VOWEL_WORD = "a";

        [TestMethod]
        public void one_consonant_word_when_game_start()
        {
            var hangman = new Hangman(ONE_CONSONANT_WORD);

            Assert.AreEqual(PLACEHOLDER, hangman.discovered());
        }

        [TestMethod]
        public void two_consonant_word_when_game_start()
        {
            var hangman = new Hangman("sk");

            Assert.AreEqual(PLACEHOLDER + PLACEHOLDER, hangman.discovered());
        }

        [TestMethod]
        public void one_vowel_word_when_game_start()
        {
            var hangman = new Hangman(ONE_VOWEL_WORD);

            Assert.AreEqual(ONE_VOWEL_WORD, hangman.discovered());
        }

        [TestMethod]
        public void discovered_when_type_a_contained_consonant()
        {
            HangmanForTest hangman = new HangmanForTest("word");

            hangman.typeWithoutCheckGameOver(CONTAINED_CONSONANT);

            Assert.AreEqual("wo__", hangman.discovered());
        }
    }
}