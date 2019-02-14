using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFElevator
{
    class Elevator
    {
        //Properties
        private int maxFloor;
        private int minFloor;
        private int nbPerson;
        private int actualFloor;

        //Fields
        public int MaxFloor { get => maxFloor; set => maxFloor = value; }
        public int MinFloor { get => minFloor; set => minFloor = value; }
        public int NbPerson { get => nbPerson; set => nbPerson = value; }
        public int ActualFloor { get => actualFloor; set => actualFloor = value; }

        //Contructors
        public Elevator() : this(0, 0, 0)
        {
            
        }

        public Elevator(int maxFloor,int minFloor,int nbPerson)
        {
            MaxFloor = maxFloor;
            MinFloor = minFloor;
            NbPerson = nbPerson;
            ActualFloor = 0;
        }

        //Methods
        public void GoUp()
        {
            ActualFloor++;
        }

        public void GoDown()
        {
            ActualFloor--;
        }

        public int GetNbFloor()
        {
            return MaxFloor + MinFloor + 1;
        }
    }
}
