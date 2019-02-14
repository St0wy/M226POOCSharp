using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFPizza
{
    class Ingredient
    {
        #region Fields
        decimal price;
        string name;
        #endregion

        #region Properties
        public decimal Price { get => price; set => price = value; }
        public string Name { get => name; set => name = value; }
        #endregion

        #region Constructors
        public Ingredient() : this(ProgConstants.DEFAULT_PRICE, ProgConstants.DEFAULT_NAME)
        {

        }

        public Ingredient(decimal price, string Name)
        {
            Price = price;
            Name = name;
        }
        #endregion
    }
}
