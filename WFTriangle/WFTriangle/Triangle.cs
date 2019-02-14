using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFTriangle
{
    class Triangle
    {
        //Properties
        int _side1;
        int _side2;
        int _side3;
        List<int> _sides;

        //Fields
        public int Side1 { get => _side1; set => _side1 = value; }
        public int Side2 { get => _side2; set => _side2 = value; }
        public int Side3 { get => _side3; set => _side3 = value; }
        public List<int> Sides { get => _sides; set => _sides = value; }

        //Constructor
        public Triangle(int s1, int s2, int s3)
        {
            Side1 = s1;
            Side2 = s2;
            Side3 = s3;

            Sides = new List<int>();
            Sides.Add(Side1);
            Sides.Add(Side2);
            Sides.Add(Side3);
            Sides.Sort();
        }

        //Methods
        public string Classify()
        {
            string triangleType = "";
            if (IsEquilateral())
            {
                triangleType = "Equilateral";
            }
            else if(IsIsosceles())
            {
                triangleType = "Isosceles";
            }
            else if (IsRightAngled())
            {
                triangleType = "Right Angled";
            }
            else if (IsScalene())
            {
                triangleType = "Scalene"; 
            }
            else if (IsImpossible())
            {
                triangleType = "Impossible";
            }

            return triangleType;
        }

        public double GetArea()
        {
            double area = 0;
            if (IsImpossible())
            {
                area = -1.0;
            }
            else
            {
                double p = (double)GetPerimeter() / 2;
                area = Math.Sqrt(p * (p - Sides[0]) * (p - Sides[1]) * (p - Sides[2]));
            }

            return area;
        }

        public int GetPerimeter()
        {
            if (IsImpossible())
            {
                return 1;
            }
            else
            {
                return Sides[0] + Sides[1] + Sides[2];
            }
        }

        public string GetSideLengths()
        {
            return $"{Sides[0]}, {Sides[1]}, {Sides[2]}";
        }

        public bool IsEquilateral()
        {
            bool isEquilateral = false;
            if (Sides[0] == Sides[1] && Sides[1] == Sides[2])
            {
                isEquilateral = true;
            }

            return isEquilateral;
        }

        public bool IsImpossible()
        {
            bool isImpossible = false;
            if ((Sides[0] + Sides[1]) <= Sides[2])
            {
                isImpossible = true;
            }

            return isImpossible;
        }

        public bool IsIsosceles()
        {
            bool isIsosceles = false;
            if (Sides[0] == Sides[1] || Sides[1] == Sides[2] || Sides[2] == Sides[0])
            {
                isIsosceles = true;
            }

            return isIsosceles;
        }

        public bool IsRightAngled()
        {
            bool isRightAngled = false;
            if((Math.Sqrt(Sides[0]) + Math.Sqrt(Sides[1]) == Math.Sqrt(Sides[2])))
            {
                isRightAngled = true;
            }

            return isRightAngled;
        }

        public bool IsScalene()
        {
            bool isScalene = false;
            if(!IsIsosceles() && !IsRightAngled())
            {
                isScalene = true;
            }

            return isScalene;
        }

        public Triangle SetSideLengths(int s1, int s2, int s3)
        {
            Side1 = s1;
            Side2 = s2;
            Side3 = s3;

            return this;
        }
    }
}
