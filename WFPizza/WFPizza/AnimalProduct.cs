using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFPizza
{
    class AnimalProduct : Ingredient
    {
        int origin;

        public int Origin { get => origin; set => origin = value; }

        public AnimalProduct() : this(ProgConstants.ORIGIN_FRANCE, ProgConstants.DEFAULT_PRICE, ProgConstants.DEFAULT_NAME)
        {

        }

        public AnimalProduct(int origin, decimal price, string name)
        {
            Origin = origin;
            Price = price;
            Name = name;
        }
    }
}
