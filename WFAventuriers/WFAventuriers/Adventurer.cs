using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAventuriers
{
    class Adventurer
    {
        //Fields
        string name;
        int life;

        //Properties
        public string Name { get => name; set => name = value; }
        public int Life { get => life; set => life = value; }

        //Constructors
        public Adventurer(string name, int life)
        {
            this.Name = name;
            this.Life = life;
        }

        //Methods
        public void Die()
        {
            Life = 0;
        }
    }
}
