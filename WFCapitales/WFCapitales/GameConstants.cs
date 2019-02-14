using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFCapitales
{
    static class GameConstants
    {
        //Fields
        /// <summary>
        /// The game hasn't started.
        /// </summary>
        public const int GAMEMODE_NOT_STARTED = 0;
        /// <summary>
        /// You have to guess the country via the capital.
        /// </summary>
        public const int GAMEMODE_COUNTRY = 1;
        /// <summary>
        /// You have to guess the capital via the country.
        /// </summary>
        public const int GAMEMODE_CAPITAL = 2;
        /// <summary>
        /// The ammount of answers the game will propose.
        /// </summary>
        public const int NB_ANSWERS = 3;
        /// <summary>
        /// The ammount of questions the game will ask.
        /// </summary>
        public const int NB_QUESTIONS = 10;
        public const int ANSWER_STATE_NOT_SELECTED = 0;
        public const int ANSWER_STATE_SELECTED = 1;
    }
}
