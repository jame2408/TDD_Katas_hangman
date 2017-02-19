using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System;
using static hangman.Tests.HangmanForTest;
namespace hangman.Tests
{
    [TestClass]
    public class HangmanGameWinTest
    {
        HangmanForTest hangman = new HangmanForTest("am");
        Action mockAfterGameWin = Substitute.For<Action>();

        [TestMethod]
        public void Game_not_Win_When_Game_Start()
        {
            hangman.type(ANY_CHAR)
                .checkGameWin(mockAfterGameWin);

            mockAfterGameWin.DidNotReceive();
        }

        [TestMethod]
        public void Game_Win_When_discover_last_contained_consonant()
        {
            hangman.type(LAST_CONTAINED_CONSONANT)
                .checkGameWin(mockAfterGameWin);

            mockAfterGameWin.Received(1).Invoke();
        }
    }
}