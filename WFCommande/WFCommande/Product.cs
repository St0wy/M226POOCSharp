using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFCommande
{
    class Product
    {
        #region Fields
        string name;
        decimal price;
        int quantity;
        #endregion

        #region Properties
        public decimal Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string Name { get => name; set => name = value; } 
        #endregion

        //Contructor
        public Product() : this("Default", 0M, 0)
        {

        }

        public Product(string name, decimal price) : this(name, price, 0)
        {

        }

        public Product(string name, decimal price, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }

        //Method

        /// <summary>
        /// Add one to the quantity of this product.
        /// </summary>
        public void BuyOne()
        {
            Quantity++;
        }

        /// <summary>
        /// Add the specified amout to the quantity of this product.
        /// </summary>
        /// <param name="nbr">How much to you add to quantity.</param>
        public void Buy(int nbr)
        {
            Quantity += nbr;
        }

        public int TotalPrice()
        {
            return price * Convert.ToDecimal(Quantity);
        }
    }
}
