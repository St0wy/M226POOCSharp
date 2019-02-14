using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFDactylo
{
    public partial class frmDactylo : Form
    {
        string[] tabWords;
        string currentWord;
        int score;
        int elapsedTime;
        public frmDactylo()
        {
            InitializeComponent();
            tabWords = new string[] { "fish", "cat", "dog", "monkey", "tiger", "panda", "lion", "zebra" };
            currentWord = String.Empty;
            score = 0;
            elapsedTime = 0;
        }

        private void FrmDactylo_Load(object sender, EventArgs e)
        {
            lblWordToWrite.Text = String.Empty;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if(tbxWord.Text == currentWord)
            {
                GoodWord();
            }
        }

        private void Start()
        {
            UpdateCurrentWord();
            tmrMain.Enabled = true;
            lblTitle.Text = "Tapez le mot qui apparait ci-dessous";
            tbxWord.Enabled = true;
            tbxWord.Focus();
            UpdateView();
        }

        private void GoodWord()
        {
            score++;
            if (score >= tabWords.Length)
            {
                Win();
            }
            else
            {
                tbxWord.Text = String.Empty;
                UpdateCurrentWord();
                UpdateView();
            }
        }

        private void Win()
        {

            lblTitle.Text = "Win";
            lblWordToWrite.Text = String.Empty;
            tbxWord.Text = String.Empty;
            tbxWord.Enabled = false;
            score = 0;
            tmrMain.Enabled = false;
            elapsedTime = 0;
        }

        private void UpdateView()
        {
            lblWordToWrite.Text = currentWord;
        }

        private void UpdateCurrentWord()
        {
            currentWord = tabWords[score];
            
        }

        private void tmrMain_Tick(object sender, EventArgs e)
        {
            elapsedTime++;
            lblTimeSpent.Text = $"Temps passe: {elapsedTime}";
        }
    }
}
