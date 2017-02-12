using Microsoft.VisualStudio.TestTools.UnitTesting;
using static hangman.Tests.HangmanForTest;

namespace hangman.Tests
{
    [TestClass]
    public class HangmanUsedTests
    {
        HangmanForTest hangman = new HangmanForTest("word");
        private const string ALL_VOWELS = "aeiou";

        [TestMethod]
        public void used_when_game_start()
        {
            Assert.AreEqual(ALL_VOWELS, hangman.used());
        }

        [TestMethod]
        public void used_when_type_a_vowel()
        {
            hangman.typeWithoutCheckGameOver(VOWEL);

            Assert.AreEqual(ALL_VOWELS, hangman.used());
        }

        [TestMethod]
        public void used_when_type_a_consonant()
        {
            hangman.typeWithoutCheckGameOver(HangmanForTest.CONSONANT);

            Assert.AreEqual(ALL_VOWELS + HangmanForTest.CONSONANT, hangman.used());
        }

        [TestMethod]
        public void used_when_type_the_same_consonant_again()
        {
            hangman.typeWithoutCheckGameOver(HangmanForTest.CONSONANT);
            hangman.typeWithoutCheckGameOver(HangmanForTest.CONSONANT);

            Assert.AreEqual(ALL_VOWELS + HangmanForTest.CONSONANT, hangman.used());
        }
    }
}