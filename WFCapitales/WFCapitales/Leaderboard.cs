using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFCapitales
{
    class Leaderboard
    {
        //Fields
        List<int> lstScore;

        //Properties
        public List<int> LstScore { get => lstScore; set => lstScore = value; }

        //Constructors
        public Leaderboard()
        {
            LstScore = new List<int>();
        }

        
    }
}
