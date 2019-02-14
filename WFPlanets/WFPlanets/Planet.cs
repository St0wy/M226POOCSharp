using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFPlanets
{
    class Planet
    {
        //Properties
        int size;
        string name;
        Color myColor;

        //Fields
        public int Size { get => size; set => size = value; }
        public string Name { get => name; set => name = value; }
        public Color MyColor { get => myColor; set => myColor = value; }

        //Constructors
        public Planet():this(50, "Soleil", Color.Yellow)
        {

        }

        public Planet(int size, string name, Color color)
        {
            Size = size;
            Name = name;
            MyColor = color;
        }

        //Methods
    }
}
