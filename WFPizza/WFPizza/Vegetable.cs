using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFPizza
{
    class Vegetable : Ingredient
    {
        int freshness;

        public int Freshness { get => freshness; set => freshness = value; }

        public Vegetable() : this(ProgConstants.FRESHNESS_FRESH, ProgConstants.DEFAULT_PRICE, ProgConstants.DEFAULT_NAME)
        {

        }

        public Vegetable(int freshness, decimal price, string name)
        {
            Freshness = freshness;
            Price = price;
            Name = name;
        }
    }
}
