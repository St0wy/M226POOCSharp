using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFCapitales
{
    class CACModel
    {
        #region Constants
        private const string EUROPEAN_COUNTRY_FILENAME = "EuropeanCountriesAndCapitals_utf8.csv";
        private const char CSV_SPLITTER = ';';
        private const int SCORE_ONE_BAD_ANSWER = 1;
        private const int SCORE_ZERO_BAD_ANSWER = 2;
        #endregion

        #region Fileds
        private string countriesAndCapitalsFilename;
        private List<Country> lstCountries;
        private GameQuestion[] questions;
        private int gamemode;
        private int score;
        private int currentQuestion;
        private static Random rnd; 
        #endregion

        #region Properties
        internal List<Country> LstCountries { get => lstCountries; set => lstCountries = value; }
        internal GameQuestion[] Questions { get => questions; set => questions = value; }
        public int Gamemode { get => gamemode; set => gamemode = value; }
        public int Score { get => score; set => score = value; }
        public int CurrentQuestionId { get => currentQuestion; set => currentQuestion = value; }
        public static Random Rnd { get => rnd; set => rnd = value; }
        public string CountriesAndCapitalsFilename { get => countriesAndCapitalsFilename; set => countriesAndCapitalsFilename = value; }
        #endregion

        #region Constructors
        public CACModel() : this(new List<Country>())
        {

        }

        public CACModel(List<Country> countries)
        {
            LstCountries = countries;
            Questions = new GameQuestion[GameConstants.NB_QUESTIONS];
            Gamemode = GameConstants.GAMEMODE_NOT_STARTED;
            Score = 0;
            CurrentQuestionId = 0;
            Rnd = new Random();
            CountriesAndCapitalsFilename = EUROPEAN_COUNTRY_FILENAME;
        } 
        #endregion

        //Methods   
        /// <summary>
        /// Change the gamemode, load the coutries and generate the questions
        /// </summary>
        public void StartGame()
        {
            LoadListCountry();
            GenerateQuestions();
        }

        public void NewGame()
        {
            Questions = new GameQuestion[GameConstants.NB_QUESTIONS];
            Score = 0;
            CurrentQuestionId = 0;
            StartGame();
        }

        /// <summary>
        /// Load the list of country with their capitals in the model
        /// </summary>
        public void LoadListCountry()
        {
            using (var reader = new StreamReader(CountriesAndCapitalsFilename))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(CSV_SPLITTER);

                    LstCountries.Add(new Country(values[0], values[1]));
                }
            }
        }

        /// <summary>
        /// Generate all the questions for the game and store them in the variable Questions
        /// </summary>
        public void GenerateQuestions()
        {
            List<int> lstOldQuestions = new List<int>();
            for (int i = 0; i < GameConstants.NB_QUESTIONS; i++)
            {
                GameQuestion gameQuestion = new GameQuestion();
                int questionId = 0;
                do
                {
                    questionId = Rnd.Next(LstCountries.Count);
                } while (!IsQuestionUnique(questionId, lstOldQuestions));
                Answer goodAnswer = new Answer(LstCountries[questionId], true);
                gameQuestion.Question = goodAnswer.Country;

                //Adding answers
                gameQuestion.Answers[0] = goodAnswer;
                List<int> lstOldAnswer = new List<int>();
                for (int j = 1; j < GameConstants.NB_ANSWERS; j++)
                {
                    int answerId = 0;
                    do
                    {
                        answerId = Rnd.Next(LstCountries.Count);
                    } while (!IsAnswerUnique(answerId, lstOldAnswer));
                    gameQuestion.Answers[j] = new Answer(LstCountries[answerId], false);
                    lstOldAnswer.Add(answerId);
                }
                gameQuestion.Answers = gameQuestion.Answers.OrderBy(empty => Guid.NewGuid()).ToArray();

                Questions[i] = gameQuestion;
                lstOldQuestions.Add(questionId);
            }
        }

        /// <summary>
        /// Go the next question
        /// </summary>
        public void NextQuestion()
        {
            if(CurrentQuestionId < GameConstants.NB_QUESTIONS - 1)
            {
                CurrentQuestionId++;
            }
        }

        /// <summary>
        /// Go to the last questions
        /// </summary>
        public void LastQuestion()
        {
            if (CurrentQuestionId > 0)
            {
                CurrentQuestionId--;
            }
        }

        public bool IsAnswerGood(string answer)
        {
            bool isAnswerGood = false;
            GameQuestion gameQuestion = Questions[CurrentQuestionId];
            if (gameQuestion.NbBadAnswers < 2)
            {
                foreach (Answer gameQuestionAnswer in gameQuestion.Answers)
                {
                    if (Gamemode == GameConstants.GAMEMODE_CAPITAL)
                    {
                        if (gameQuestionAnswer.Country.CountryName == answer)
                        {
                            gameQuestionAnswer.State = GameConstants.ANSWER_STATE_SELECTED;
                            if (gameQuestionAnswer.IsGoodAnswer)
                            {
                                isAnswerGood = true;
                            }
                        }
                    }
                    else if (Gamemode == GameConstants.GAMEMODE_COUNTRY)
                    {
                        if (gameQuestionAnswer.Country.Capital == answer)
                        {
                            gameQuestionAnswer.State = GameConstants.ANSWER_STATE_SELECTED;
                            if (gameQuestionAnswer.IsGoodAnswer)
                            {
                                isAnswerGood = true;
                            }
                        }
                    }
                }

                if (isAnswerGood)
                {
                    SelectAllAnswers(ref gameQuestion);
                    if (gameQuestion.NbBadAnswers == 1)
                    {
                        score += SCORE_ONE_BAD_ANSWER;
                    }
                    else if (gameQuestion.NbBadAnswers == 0)
                    {
                        score += SCORE_ZERO_BAD_ANSWER;
                    }

                    if (AreAllQuestionsAnswered(Questions))
                    {
                        GameEnd();
                    }
                }
                else
                {
                    gameQuestion.NbBadAnswers++;
                    if (gameQuestion.NbBadAnswers == 2)
                    {
                        SelectAllAnswers(ref gameQuestion);
                    }
                }
            }

            return isAnswerGood;
        }

        private void GameEnd()
        {

        }

        private bool AreAllQuestionsAnswered(GameQuestion[] questions)
        {
            bool areAllQuestionsAnswered = true;
            foreach (GameQuestion question in questions)
            {
                if (!question.IsOver)
                {
                    areAllQuestionsAnswered = false;
                }
            }

            return areAllQuestionsAnswered;
        }

        private void SelectAllAnswers(ref GameQuestion gameQuestion)
        {
            foreach (Answer answer in gameQuestion.Answers)
            {
                answer.State = GameConstants.ANSWER_STATE_SELECTED;
            }
        }

        private Answer GetGoodAnswer(GameQuestion gameQuestion)
        {
            Answer goodAnswer = new Answer();
            foreach (Answer answer in gameQuestion.Answers)
            {
                if (answer.IsGoodAnswer)
                {
                    goodAnswer = answer;
                }
            }

            return goodAnswer;
        }

        /// <summary>
        /// Tells you if the specified answer has allready been put in the question.
        /// </summary>
        /// <param name="answerId">The id of your current answer.</param>
        /// <param name="LstOldAnswers">List of the id of all the other answer.</param>
        /// <returns>Returns true if the answer has never been used.</returns>
        private bool IsAnswerUnique(int answerId, List<int> LstOldAnswers)
        {
            return IsNumberNotInList(answerId, LstOldAnswers);
        }

        /// <summary>
        /// Tells you if the specified question has allready been created.
        /// </summary>
        /// <param name="questionId">The id of your current question.</param>
        /// <param name="LstOldQuestions">List of the id of all the other questions.</param>
        /// <returns></returns>
        private bool IsQuestionUnique(int questionId, List<int> LstOldQuestions)
        {
            return IsNumberNotInList(questionId, LstOldQuestions);
        }

        /// <summary>
        /// Tells you if the specified number is in the specified list.
        /// </summary>
        /// <param name="number">The number that you want to check.</param>
        /// <param name="list">List in witch the function will check.</param>
        /// <returns></returns>
        private bool IsNumberNotInList(int number, List<int> list)
        {
            bool isNumberUnique = true;
            foreach (int oldNumber in list)
            {
                if (oldNumber == number)
                {
                    isNumberUnique = false;
                }
            }

            return isNumberUnique;
        }

        
    }
}
