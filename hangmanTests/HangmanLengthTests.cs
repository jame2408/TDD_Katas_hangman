using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace hangman.Tests
{
    [TestClass()]
    public class HangmanLengthTests
    {
        [TestMethod()]
        public void Length_of_word()
        {
            var hangman = new Hangman("word");

            Assert.AreEqual(4, hangman.length());
        }
    }
}