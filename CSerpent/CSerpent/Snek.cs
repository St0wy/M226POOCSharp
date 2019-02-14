using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSerpent
{
    class Snek
    {
        //Properties
        int size;

        //Fields
        public int Size { get => size; set => size = value; }

        //Contructors
        public Snek():this(0)
        {

        }

        public Snek(int size)
        {
            Size = size;
        }

        //Methods
        public string Show()
        {
            string snek = "@@";
            for (int i = 0; i < Size; i++)
            {
                snek += "-";
            }
            snek += "<";

            return snek;
        }

        public void Attack(Snek s, int damage)
        {
            s.Size -= damage;
        }
    }
}
