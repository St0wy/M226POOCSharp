using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFVenteSki
{
    public class Article
    {
        //Constants
        public const string CURRENCY = "CHF";

        //Fields
        private int id;
        private string designation;
        private double price;

        //Properties
        public int Id { get => id; set => id = value; }
        public string Designation { get => designation; set => designation = value; }
        public double Price { get => price; set => price = value; }

        //Constructor
        public Article(int id, string designation, double price)
        {
            Id = id;
            Designation = designation;
            Price = price;
        }

        //Methods
        /// <summary>
        /// Get the id of the article.
        /// </summary>
        /// <returns>Returns the id of the article.</returns>
        public int GetId()
        {
            return Id;
        }

        /// <summary>
        /// Get the Designation (name) of the article.
        /// </summary>
        /// <returns>Returns the Designation (name) of the article.</returns>
        public string GetDesignation()
        {
            return Designation;
        }

        /// <summary>
        /// Get the price of the article.
        /// </summary>
        /// <returns>Return the price of the article.</returns>
        public double GetPrice()
        {
            return Price;
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
            return this == obj;
        }

        public override string ToString()
        {
            return $"{Designation} : ({Price})";
        }
    }
}
