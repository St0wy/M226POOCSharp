using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker
{
    public partial class frmMain : Form
    {
        private int score;
        private bool cheat;
        private string hashKey;
        private static Random rnd = new Random();

        public frmMain()
        {
            InitializeComponent();
            score = 0;
            cheat = false;
            hashKey = "";
        }

        private void BtnAddPoint_Click(object sender, EventArgs e)
        {
            AddScore();
            if (cheat)
            {
                lblScore.Text = "Tricher c'est mal";
            }
            else
            {
                UpdateView();
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lblScore.Text = score.ToString();
            hashKey = RandomString(10);
        }

        private void UpdateView()
        {
            lblScore.Text = score.ToString();
        }

        private void AddScore()
        {
            score++;
            lstScore.Add(score);
            CheckScoreIntegrity();
        }

        private void CheckScoreIntegrity()
        {
            
            int oldScore = 0;
            bool scoreIsOkay = true;

            foreach (int score in lstScore)
            {
                if(oldScore + 1 != score)
                {
                    scoreIsOkay = false;
                }
                oldScore = score;
            }

            if (!scoreIsOkay)
            {
                ResetAllScore();
                cheat = true;
            }
        }

        private void ResetAllScore()
        {
            score = 0;
        }
        
        public static string RandomString(int length)
        {
            const string CHARS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(CHARS, length)
              .Select(s => s[rnd.Next(s.Length)]).ToArray());
        }
    
    }
}
