using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFTicTacToe
{
    class TicTacToe
    {
        //Fields
        #region const
        public const int TAB_SIZE = 3;
        
        public const int NO_PLAYER = 0;
        public const int PLAYER_ONE = 1;
        public const int PLAYER_TWO = 2;
        
        public const int CELL_EMPTY = 0;
        public const int CELL_X = 1;
        public const int CELL_O = 2;
        
        public const int GAME_IN_PROGRESS = 1;
        public const int GAME_DRAW = 2;
        public const int GAME_P1_WIN = 3;
        public const int GAME_P2_WIN = 4;
        #endregion

        private int[,] grid;
        private int currentPlayer;

        //Properties
        private int[,] Grid { get => grid; set => grid = value; }
        public int CurrentPlayer { get => currentPlayer; set => currentPlayer = value; }

        //Constructors
        public TicTacToe()
        {
            Grid = new int[TAB_SIZE, TAB_SIZE];
            CurrentPlayer = NO_PLAYER;
        }

        //Methods
        /// <summary>
        /// Place a X or a O
        /// </summary>
        /// <param name="row">Row where you play.</param>
        /// <param name="col">Col where you play.</param>
        /// <returns></returns>
        public bool Play(int row, int col)
        {
            if (Grid[row, col] == CELL_EMPTY)
            {
                switch (CurrentPlayer)
                {
                    case PLAYER_ONE:
                        Grid[row, col] = CELL_X;
                        CurrentPlayer = PLAYER_TWO;
                        break;
                    case PLAYER_TWO:
                        Grid[row, col] = CELL_O;
                        CurrentPlayer = PLAYER_ONE;
                        break;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Get the grid
        /// </summary>
        /// <returns>Return the grid</returns>
        public int[,] GetGridState()
        {
            return Grid;
        }

        /// <summary>
        /// Empty the grid and reset CurrentPlayer
        /// </summary>
        public void ResetGame()
        {
            Grid = new int[TAB_SIZE, TAB_SIZE];
            CurrentPlayer = PLAYER_ONE;
        }

        /// <summary>
        /// Check the state of the game
        /// </summary>
        /// <returns>Tell you if the game is in progress, if P1 won, if P2 won and if there is a draw</returns>
        public int CheckGameState()
        {
            int gameState = 0;
            for (int i = 0; i < TAB_SIZE; i++)
            {
                //Test Row
                if (Grid[i, 0] == Grid[i, 1] && Grid[i, 1] == Grid[i, 2])
                {
                    if (Grid[i, 0] == CELL_X)
                    {
                        gameState = GAME_P1_WIN;
                    }
                    else if (Grid[i, 0] == CELL_O)
                    {
                        gameState = GAME_P2_WIN;
                    }
                }
                //Test Col
                if (Grid[0, i] == Grid[1, i] && Grid[1, i] == Grid[2, i])
                {
                    if (Grid[0, i] == CELL_X)
                    {
                        gameState = GAME_P1_WIN;
                    }
                    else if (Grid[0, i] == CELL_O)
                    {
                        gameState = GAME_P2_WIN;
                    }
                }
            }

            //Test Diag
            if (Grid[0, 0] == Grid[1, 1] && Grid[1, 1] == Grid[2, 2])
            {
                if (Grid[0, 0] == CELL_X)
                {
                    gameState = GAME_P1_WIN;
                }
                else if (Grid[0, 0] == CELL_O)
                {
                    gameState = GAME_P2_WIN;
                }
            }
            if (Grid[0, 2] == Grid[1, 1] && Grid[1, 1] == Grid[2, 0])
            {
                if (Grid[0, 2] == CELL_X)
                {
                    gameState = GAME_P1_WIN;
                }
                else if (Grid[0, 2] == CELL_O)
                {
                    gameState = GAME_P2_WIN;
                }
            }

            if (gameState == 0)
            {
                bool isTabFull = true;
                for (int i = 0; i < TAB_SIZE; i++)
                {
                    for (int j = 0; j < TAB_SIZE; j++)
                    {
                        if (Grid[i, j] == CELL_EMPTY)
                        {
                            isTabFull = false;
                        }
                    }
                }
                if (!isTabFull)
                {
                    gameState = GAME_IN_PROGRESS;
                }
                else
                {
                    gameState = GAME_DRAW;
                }
            }

            return gameState;
        }
    }
}
