using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System;
using static hangman.Tests.HangmanForTest;

namespace hangman.Tests
{
    [TestClass]
    public class HangmanGameOverTests
    {
        HangmanForTest hangman = new HangmanForTest("word");
        Action mockAfterGameOver = Substitute.For<Action>();

        [TestMethod]
        public void Game_not_Over_When_Game_Start()
        {
            hangman.type(ANY_CHAR)
                .checkGameOver(mockAfterGameOver);

            mockAfterGameOver.DidNotReceive();
        }

        [TestMethod]
        public void game_over_when_last_try_failed()
        {
            allTriesUsedExceptLast();

            hangman.type(ANY_CHAR)
                .checkGameOver(mockAfterGameOver);

            mockAfterGameOver.Received(1).Invoke();
        }

        private void allTriesUsedExceptLast()
        {
            for (int i = 1; i <= MAX_TRIES - 1; i++)
            {
                hangman.type(ANY_CHAR);
            }
        }
    }
}