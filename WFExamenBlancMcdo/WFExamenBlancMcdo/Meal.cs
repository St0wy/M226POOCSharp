/**
 * WFExamenBlancMcdo
 * Fabian Huber
 * 07.03.219
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFExamenBlancMcdo
{
    public class Meal
    {
        private const string DEFAULT_NAME = "";
        private const int DEFAULT_KCALORIES_VALUE = 0;

        //Fields
        private string name;
        private int kCaloriesValue;

        //Properties
        public string Name { get => name; set => name = value; }
        public int KCaloriesValue { get => kCaloriesValue; set => kCaloriesValue = value; }

        //Constructors
        public Meal(string name, int kCaloriesValue)
        {
            Name = name;
            KCaloriesValue = kCaloriesValue;
        }

        public Meal() : this(DEFAULT_NAME, DEFAULT_KCALORIES_VALUE)
        {
            
        }

        //Methods
        public override string ToString()
        {
            return $"{Name} ({KCaloriesValue})";
        }
    }
}
