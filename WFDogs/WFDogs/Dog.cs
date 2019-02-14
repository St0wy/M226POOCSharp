using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFDogs
{
    class Dog
    {
        //Properties
        string name;
        int size;

        //Fields
        public string Name { get => name; set => name = value; }
        public int Size { get => size; set => size = value; }

        //Constructors
        public Dog() : this("default", 0)
        {

        }

        public Dog(string name, int size)
        {
            Name = name;
            Size = size;
        }

        //Methods
        public string Bark()
        {
            int numberOfO = Size / 10;
            string bark = "W";
            for (int i = 0; i < numberOfO; i++)
            {
                bark += "o";
            }
            bark += "uf!";

            return bark;
        }
    }
}
