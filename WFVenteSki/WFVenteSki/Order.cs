using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFVenteSki
{
    public class Order
    {
        //Fields
        int quantity;
        Article article;

        //Properties
        public int Quantity { get => quantity; set => quantity = value; }
        internal Article Article { get => article; set => article = value; }

        //Constuctors
        public Order(Article article, int quantity)
        {
            Article = article;
            Quantity = quantity;
        }

        //Methods
        /// <summary>
        /// Get the article in the order.
        /// </summary>
        /// <returns>Returns the article in the order.</returns>
        public Article GetArticle()
        {
            return Article;
        }

        /// <summary>
        /// Get the quantity of items in that order.
        /// </summary>
        /// <returns>Returns the quantity of items in that order.</returns>
        public int GetQuantity()
        {
            return Quantity;
        }

        /// <summary>
        /// Set the quantity of items in that order.
        /// </summary>
        /// <param name="quantity">Quantity you want to set in that order.</param>
        public void SetQuantity(int quantity)
        {
            Quantity = quantity;
        }

        /// <summary>
        /// Increment the quantity of item in that order.
        /// </summary>
        /// <param name="ammount">Ammount you want to increment.</param>
        public void IncrementQuantity(int ammount)
        {
            Quantity += ammount;
        }

        //public int CompareTo(object obj)
        //{
        //
        //}

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Order order = obj as Order;
            return this.GetArticle() == order.GetArticle();
        }

        public override string ToString()
        {
            return $"{Quantity} x {Article} = {Quantity * Article.GetPrice()}";
        }
    }
}
