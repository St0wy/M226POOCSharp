using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFCapitales
{
    class GameQuestion
    {
        //Fields
        private Country questionText;
        private Answer[] answers;
        private int nbBadAnswers;
        private bool isOver;

        //Properties
        public Country Question { get => questionText; set => questionText = value; }
        public int NbBadAnswers { get => nbBadAnswers; set => nbBadAnswers = value; }
        internal Answer[] Answers { get => answers; set => answers = value; }
        public bool IsOver { get => isOver; set => isOver = value; }

        //Constructors
        public GameQuestion() : this(new Country(), new Answer[GameConstants.NB_ANSWERS])
        {

        }

        public GameQuestion(Country question, Answer[] answers)
        {
            Question = question;
            Answers = answers;
            NbBadAnswers = 0;
            IsOver = false;
        }
    }
}
