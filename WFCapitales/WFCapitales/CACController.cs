using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFCapitales
{
    class CACController
    {
        //Constants
        

        //Fields
        private CACModel model;
        private CACView view;

        //Properties
        public CACView View { get => view; set => view = value; }
        internal CACModel Model { get => model; set => model = value; }

        //Constructors
        public CACController(CACView paramView)
        {
            View = paramView;
            Model = new CACModel();
        }

        //Methods
        public int GetGamemode()
        {
            int gamemode = Model.Gamemode;

            return gamemode;
        }

        public void SetGamemode(int gamemode)
        {
            Model.Gamemode = gamemode;
        }

        public GameQuestion[] GetQuestions()
        {
            return Model.Questions;
        }

        public int GetCurrentQuestionId()
        {
            return Model.CurrentQuestionId;
        }

        public int GetScore()
        {
            return Model.Score;
        }

        public void StartGame()
        {
            SetGamemode(GameConstants.GAMEMODE_COUNTRY);
            Model.StartGame();
        }

        public void NewGame()
        {
            Model.NewGame();
        }

        public void NextQuestion()
        {
            Model.NextQuestion();
        }

        public void LastQuestion()
        {
            Model.LastQuestion();
        }

        public void ChangeFile(string fileName)
        {
            Model.CountriesAndCapitalsFilename = fileName;
            NewGame();
        }

        public bool IsAnswerGood(string answer)
        {
            return Model.IsAnswerGood(answer);
        }
    }
}
