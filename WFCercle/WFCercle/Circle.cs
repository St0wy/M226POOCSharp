using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFCercle
{
    class Circle
    {
        //Properties
        private double rayon;
        private readonly double pi;

        //Fields
        public double Rayon { get => rayon; set => rayon = value; }
        public double Pi => pi;

        //Contructor
        public Circle() : this(0.0)
        {

        }

        public Circle(double r)
        {
            SetRayon(r);
            pi = 3.14159;
        }
        
        //Methods
        public void SetRayon(double r)
        {
            if(r < 0)
            {
                Rayon = 0;
            }
            else
            {
                Rayon = r;
            }
        }

        public double GetRayon()
        {
            return Rayon;
        }

        public double GetArea()
        {
            return Pi * Rayon * Rayon;
        }

        public double GetDiametre()
        {
            return 2 * Rayon;
        }

        public double GetCirconference()
        {
            return 2 * Pi * Rayon;
        }

        public override string ToString()
        {
            return $"Rayon: {Rayon}, Area: {GetArea()}, Diametre: {GetDiametre()}, Circonference: {GetCirconference()}.";
        }
    }
}
