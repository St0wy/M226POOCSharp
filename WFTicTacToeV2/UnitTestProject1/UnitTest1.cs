using System;
using WFTicTacToe;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        TicTacToe ttt;

        [TestMethod]
        public void FirstPlayerIsNumberOne()
        {
            ttt = new TicTacToe();

            Assert.AreEqual(TicTacToe.PLAYER_ONE, ttt.CurrentPlayer);
        }

        [TestMethod]
        public void AfterANumberOfOddValidPlayItIsPlayer2()
        {
            Random rnd = new Random();
            ttt = new TicTacToe();
            const int NB_GAMES = 3;
            for (int i = 0; i < NB_GAMES; i++)
            {
                
                ttt.Play(rnd.Next(TicTacToe.TAB_SIZE), rnd.Next(TicTacToe.TAB_SIZE));
            }

            Assert.AreEqual(TicTacToe.PLAYER_TWO, ttt.CurrentPlayer);
        }

        [TestMethod]
        public void AfterANumberOfEvenValidPlayItIsPlayer1()
        {
            Random rnd = new Random();
            ttt = new TicTacToe();
            const int NB_GAMES = 2;
            for (int i = 0; i < NB_GAMES; i++)
            {
                ttt.Play(rnd.Next(3), rnd.Next(3));
            }

            Assert.AreEqual(TicTacToe.PLAYER_ONE, ttt.CurrentPlayer);
        }

        [TestMethod]
        public void ChangingPlayerOnlyIfValidPlay()
        {
            int posx = 1;
            int posy = 1;
            ttt = new TicTacToe();

            ttt.Play(posx, posy);

            Assert.AreEqual(TicTacToe.PLAYER_TWO, ttt.CurrentPlayer);

            ttt.Play(posx, posy);

            Assert.AreEqual(TicTacToe.PLAYER_TWO, ttt.CurrentPlayer);
        }

        [TestMethod]
        public void ResetRestorePlayer1()
        {
            ttt = new TicTacToe();
            ttt.ResetGame();

            Assert.AreEqual(TicTacToe.PLAYER_ONE, ttt.CurrentPlayer);
        }

        [TestMethod]
        public void ResetRestoreEmptyGrid()
        {
            ttt = new TicTacToe();
            ttt.ResetGame();

            for (int i = 0; i < TicTacToe.TAB_SIZE; i++)
            {
                for (int j = 0; j < TicTacToe.TAB_SIZE; j++)
                {
                    Assert.AreEqual(TicTacToe.CELL_EMPTY, ttt.GetGridState()[i, j]);
                }
            }
        }

        [TestMethod]
        public void AllCaseFree()
        {
            ttt = new TicTacToe();

            for (int i = 0; i < TicTacToe.TAB_SIZE; i++)
            {
                for (int j = 0; j < TicTacToe.TAB_SIZE; j++)
                {
                    Assert.AreEqual(TicTacToe.CELL_EMPTY, ttt.GetGridState()[i, j]);
                }
            }
        }

        [TestMethod]
        public void AllCaseUsedAfter()
        {
            ttt = new TicTacToe();

            for (int i = 0; i < TicTacToe.TAB_SIZE; i++)
            {
                for (int j = 0; j < TicTacToe.TAB_SIZE; j++)
                {
                    ttt.Play(i, j);
                }
            }

            for (int i = 0; i < TicTacToe.TAB_SIZE; i++)
            {
                for (int j = 0; j < TicTacToe.TAB_SIZE; j++)
                {
                    Assert.AreNotEqual(TicTacToe.CELL_EMPTY, ttt.GetGridState()[i, j]);
                }
            }
        }

        [TestMethod]
        public void OutsideOfGridIsFalse()
        {
            ttt = new TicTacToe();
            bool statePlay = ttt.Play(4, 4);
            Assert.IsFalse(statePlay);
        }

        [TestMethod]
        public void PlayAtRowColFillsWithPlayerNumber()
        {
            ttt = new TicTacToe();
            Random random = new Random();
            int posx = random.Next(3);
            int posy = random.Next(3);

            ttt.Play(posx, posy);

            Assert.AreEqual(TicTacToe.PLAYER_ONE, ttt.GetGridState()[posx, posy]);
        }

        [TestMethod]
        public void Play3NonWinningConfigurationCheckIfInProgress()
        {
            const int NB_GAMES = 2;
            for (int i = 0; i < NB_GAMES; i++)
            {
                ttt = new TicTacToe();
                ttt.Play(1, 1);
                Assert.AreEqual(TicTacToe.GAME_IN_PROGRESS, ttt.CheckGameState());
            }
        }   

        [TestMethod]
        public void Play3DrawConfigurationCheckIfDraw()
        {
            ttt = new TicTacToe();
            const int NB_GAMES = 3;
            for (int k = 0; k < NB_GAMES; k++)
            {
                ttt.Play(0, 0);
                ttt.Play(0, 2);
                ttt.Play(0, 1);
                ttt.Play(1, 0);
                ttt.Play(1, 1);
                ttt.Play(2, 1);
                ttt.Play(1, 2);
                ttt.Play(2, 2);
                ttt.Play(2, 0);
                Assert.AreEqual(TicTacToe.GAME_DRAW, ttt.CheckGameState());
            }
        }

        [TestMethod]
        public void Player1Wins()
        {
            ttt = new TicTacToe();
            ttt.Play(0, 0);
            ttt.Play(1, 0);
            ttt.Play(0,1);
            ttt.Play(1,1);
            ttt.Play(0,2);

            Assert.AreEqual(TicTacToe.GAME_P1_WIN, ttt.CheckGameState());
        }

        [TestMethod]
        public void Player2Wins()
        {
            ttt = new TicTacToe();
            ttt.Play(0, 0);
            ttt.Play(1, 0);
            ttt.Play(0, 1);
            ttt.Play(1, 1);
            ttt.Play(2, 1);
            ttt.Play(1, 2);

            Assert.AreEqual(TicTacToe.GAME_P2_WIN, ttt.CheckGameState());
        }
    }
}
