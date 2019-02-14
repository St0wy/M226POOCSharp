using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFCapitales
{
    class Answer
    {
        //Fields
        private Country country;
        private int state;
        private bool isGoodAnswer;

        //Properties
        internal Country Country { get => country; set => country = value; }
        public int State { get => state; set => state = value; }
        public bool IsGoodAnswer { get => isGoodAnswer; set => isGoodAnswer = value; }

        //Constructors
        public Answer() : this(new Country(), false)
        {

        }

        public Answer(Country country, bool isGoodAnswer)
        {
            Country = country;
            State = GameConstants.ANSWER_STATE_NOT_SELECTED;
            IsGoodAnswer = isGoodAnswer;
        }
    }
}
