using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFCapitales
{
    public partial class CACView : Form
    {
        //Fields
        #region Constants
        private const string TEXT_START_QUESTION = "Voulez-vous commencer?";
        private const string TEXT_BUTTON_START = "Commencer";
        private const string TEXT_QUESTION_CAPITAL = "est dans le pays:";
        private const string TEXT_QUESTION_COUNTRY = "a pour capitale:";
        private const string TEXT_BUTTON_NEXT_QUESTION = "Question suivante";
        private const string TEXT_BUTTON_LAST_QUESTION = "Question précédente";
        private const string TEXT_BUTTON_NEW_GAME = "Nouvelle partie";
        private const string TEXT_NUMBER_QUESTION_BEGINNING = "Question: ";
        private const string TEXT_NUMBER_QUESTION_MID = "/";
        private const string TEXT_SCORE = "Score: ";
        private const string TAG_ANSWER = "answer";
        #endregion

        private CACController controller;

        //Properties
        internal CACController Controller { get => controller; set => controller = value; }

        //Constructors
        public CACView()
        {
            InitializeComponent();

            Controller = new CACController(this);
        }

        //Methods
        private void CACView_Load(object sender, EventArgs e)
        {
            UpdateView();
        }

        /// <summary>
        /// Update the View accordingly on what should be shown
        /// </summary>
        private void UpdateView()
        {
            int gamemode = Controller.GetGamemode();
            GameQuestion[] questions = Controller.GetQuestions();
            int currentQuestionId = Controller.GetCurrentQuestionId();

            if (gamemode == GameConstants.GAMEMODE_NOT_STARTED)
            {
                #region visible
                lblNbrQuestion.Visible = false;
                lblScore.Visible = false;
                btnAnswer1.Visible = false;
                btnAnswer2.Visible = false;
                btnAnswer3.Visible = false;
                lblAfterQuestion.Visible = false;
                btnLastQuestion.Visible = false;
                btnNewGame.Visible = false;
                btnNextQuestion.Visible = false;
                mstMain.Visible = false;
                #endregion

                lblQuestion.Text = TEXT_START_QUESTION;
                btnStartGame.Text = TEXT_BUTTON_START;
            }
            else
            {
                GameQuestion gameQuestion = questions[currentQuestionId];
                Button[] answerButtons = GetAnswerButtons();
                if (gamemode == GameConstants.GAMEMODE_COUNTRY)
                {
                    lblAfterQuestion.Text = TEXT_QUESTION_COUNTRY;
                    tsmGuessCaptial.Checked = false;
                    tsmGuessCountry.Checked = true;
                    lblQuestion.Text = gameQuestion.Question.CountryName;

                    //Manage the answer buttons
                    for (int i = 0; i < gameQuestion.Answers.Length; i++)
                    {
                        Answer answer = gameQuestion.Answers[i];
                        Button button = answerButtons[i];
                        button.Text = answer.Country.Capital;
                        if (answer.State == GameConstants.ANSWER_STATE_SELECTED)
                        {
                            button.Enabled = false;
                            if(answer.IsGoodAnswer)
                            {
                                button.BackColor = Color.Green;
                            }
                            else
                            {
                                button.BackColor = Color.Red;
                            }
                        }
                        else if(answer.State == GameConstants.ANSWER_STATE_NOT_SELECTED)
                        {
                            button.Enabled = true;
                            button.BackColor = SystemColors.Control;
                        }
                    }
                }
                else if (gamemode == GameConstants.GAMEMODE_CAPITAL)
                {
                    lblAfterQuestion.Text = TEXT_QUESTION_CAPITAL;
                    tsmGuessCaptial.Checked = true;
                    tsmGuessCountry.Checked = false;
                    lblQuestion.Text = gameQuestion.Question.Capital;

                    for (int i = 0; i < gameQuestion.Answers.Length; i++)
                    {
                        Answer answer = gameQuestion.Answers[i];
                        Button button = answerButtons[i];
                        button.Text = answer.Country.CountryName;
                        if (answer.State == GameConstants.ANSWER_STATE_SELECTED)
                        {
                            button.Enabled = false;
                            if (answer.IsGoodAnswer)
                            {
                                button.BackColor = Color.Green;
                            }
                            else
                            {
                                button.BackColor = Color.Red;
                            }
                        }
                        else if (answer.State == GameConstants.ANSWER_STATE_NOT_SELECTED)
                        {
                            button.Enabled = true;
                            button.BackColor = SystemColors.Control;
                        }
                    }
                }

                #region visibleAndText
                btnStartGame.Visible = false;
                lblNbrQuestion.Visible = true;
                lblScore.Visible = true;
                btnAnswer1.Visible = true;
                btnAnswer2.Visible = true;
                btnAnswer3.Visible = true;
                lblAfterQuestion.Visible = true;
                btnLastQuestion.Visible = true;
                btnNewGame.Visible = true;
                btnNextQuestion.Visible = true;
                mstMain.Visible = true;

                btnNewGame.Text = TEXT_BUTTON_NEW_GAME;
                btnNextQuestion.Text = TEXT_BUTTON_NEXT_QUESTION;
                btnLastQuestion.Text = TEXT_BUTTON_LAST_QUESTION;

                lblNbrQuestion.Text = TEXT_NUMBER_QUESTION_BEGINNING + (Controller.GetCurrentQuestionId() + 1) + TEXT_NUMBER_QUESTION_MID + Controller.GetQuestions().Length;
                lblScore.Text = TEXT_SCORE + Controller.GetScore().ToString();
                #endregion
            }
        }

        private void BtnStartGame_Click(object sender, EventArgs e)
        {
            Controller.StartGame();
            UpdateView();
        }

        private Button[] GetAnswerButtons()
        {
            return GetButtonsByTag(TAG_ANSWER);
        }

        private Button[] GetButtonsByTag(object tag)
        {
            List<Button> buttons = new List<Button>();
            foreach (Control control in Controls)
            {
                if(control is Button)
                {
                    Button button = control as Button;
                    if (button.Tag == tag)
                    {
                        buttons.Add(button);
                    }
                }
            }

            return buttons.ToArray();
        }

        private void BtnNextQuestion_Click(object sender, EventArgs e)
        {
            Controller.NextQuestion();
            UpdateView();
        }

        private void BtnLastQuestion_Click(object sender, EventArgs e)
        {
            Controller.LastQuestion();
            UpdateView();
        }

        private void TsmGuessCapital_Click(object sender, EventArgs e)
        {
            Controller.SetGamemode(GameConstants.GAMEMODE_CAPITAL);
            Controller.NewGame();
            UpdateView();
        }

        private void TsmGuessCountry_Click(object sender, EventArgs e)
        {
            Controller.SetGamemode(GameConstants.GAMEMODE_COUNTRY);
            Controller.NewGame();
            UpdateView();
        }

        private void TsmLoadListCountryAndCapitals_Click(object sender, EventArgs e)
        {
            OpenFileDialog sp = new OpenFileDialog
            {
                Filter = "CSV Files(*.csv) | *.csv"
            };

            if (sp.ShowDialog() == DialogResult.OK)
            {
                Controller.ChangeFile(sp.FileName);
            }

            UpdateView();
        }

        private void BtnAnswer_Click(object sender, EventArgs e)
        {
            Button btnSelectedAnswer = (sender as Button);
            string answer = btnSelectedAnswer.Text;

            Controller.IsAnswerGood(answer);
            UpdateView();
        }

        private void BtnNewGame_Click(object sender, EventArgs e)
        {
            Controller.NewGame();
            UpdateView();
        }

        private void TsmAbout_Click(object sender, EventArgs e)
        {
            using (AboutView aboutView = new AboutView())
            {
                aboutView.ShowDialog();
            }
        }
    }
}
