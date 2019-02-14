using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAnimal
{
    class Animal
    {
        //Properties
        string name;
        int weight;

        //Fields
        public string Name { get => name; set => name = value; }
        public int Weight { get => weight; set => weight = value; }

        //Contructor
        public Animal() : this("default", 0)
        {

        }

        public Animal(string name, int weight)
        {
            Name = name;
            Weight = weight;
        }

        //Methods
    }
}
