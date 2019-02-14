using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFPizza
{
    class Pizza
    {
        List<Ingredient> lstIngredient;

        internal List<Ingredient> LstIngredient { get => lstIngredient; set => lstIngredient = value; }

        public Pizza()
        {

        }

        public Pizza(List<Ingredient> lst)
        {
            LstIngredient = lst;
        }
    }
}
