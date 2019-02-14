using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFTicTacToe
{
    public partial class frmTicTacToe : Form
    {
        TicTacToe morpion;
        public frmTicTacToe()
        {
            InitializeComponent();

            morpion = new TicTacToe
            {
                CurrentPlayer = TicTacToe.PLAYER_ONE
            };
        }

        private void LblCell_Click(object sender, EventArgs e)
        {
            if(morpion.CheckGameState() == TicTacToe.GAME_IN_PROGRESS)
            {
                string tag = (sender as Label).Tag.ToString();
                int row = Convert.ToInt32(tag[0].ToString());
                int col = Convert.ToInt32(tag[1].ToString());

                if (!morpion.Play(row, col))
                {
                    lblInfo.Text = "Vous ne pouvez pas poser un pion ici";
                }
                else
                {
                    UpdateView();
                }
            }
        }

        private void BtnNewGame_Click(object sender, EventArgs e)
        {
            morpion.ResetGame();
            UpdateView();
        }

        private void FrmTicTacToe_Load(object sender, EventArgs e)
        {
            morpion.CurrentPlayer = TicTacToe.PLAYER_ONE;
            UpdateView();
        }

        private void UpdateView()
        {
            //Grid
            int[,] grid = morpion.GetGridState();
            for (int i = 0; i < TicTacToe.TAB_SIZE; i++)
            {
                for (int j = 0; j < TicTacToe.TAB_SIZE; j++)
                {
                    foreach (Control c in Controls)
                    {
                        if (c is Label)
                        {
                            Label lbl = c as Label;
                            if (lbl.Tag.ToString() == $"{i}{j}")
                            {
                                if (grid[i, j] != TicTacToe.CELL_EMPTY)
                                {

                                    if (grid[i, j] == TicTacToe.CELL_X)
                                    {
                                        lbl.Text = "X";
                                    }
                                    else if (grid[i, j] == TicTacToe.CELL_O)
                                    {
                                        lbl.Text = "O";
                                    }

                                }
                                else
                                {
                                    lbl.Text = "";
                                }
                            }

                        }
                    }

                }
            }

            switch (morpion.CheckGameState())
            {
                case TicTacToe.GAME_IN_PROGRESS:
                    //Player
                    if (morpion.CurrentPlayer == TicTacToe.PLAYER_ONE)
                    {
                        lblInfo.Text = "C'est au tour du joueur 1";
                    }
                    else if (morpion.CurrentPlayer == TicTacToe.PLAYER_TWO)
                    {
                        lblInfo.Text = "C'est au tour du joueur 2";
                    }
                    break;

                case TicTacToe.GAME_DRAW:
                    MessageBox.Show("Egalité");
                    lblInfo.Text = "Egalité";
                    break;
                case TicTacToe.GAME_P1_WIN:
                    MessageBox.Show("Le joueur 1 gagne");
                    lblInfo.Text = "Le joueur 1 gagne";
                    break;
                case TicTacToe.GAME_P2_WIN:
                    MessageBox.Show("Le joueur 2 gagne");
                    lblInfo.Text = "Le joueur 2 gagne";
                    break;
            }


        }

    }
}
