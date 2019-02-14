using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFVenteSki
{
    class OrderModel : Model<Order>
    {
        //Constructor
        public OrderModel(List<Order> lst) : base(lst)
        {

        }

        //Methods
        /// <summary>
        /// Add a new Order in the list.
        /// </summary>
        /// <param name="article">New article you want to add.</param>
        public void AddOrder(Article article)
        {
            Order order = new Order(article, 1);
            if (Contains(order))
            {
                GetItem(IndexOf(order)).IncrementQuantity(1);
            }
            else
            {
                Add(order);
            }
        }

        /// <summary>
        /// Compute the final price of the order.
        /// </summary>
        /// <returns>Returns the final price of the order.</returns>
        public double ComputeResult()
        {
            double finalPrice = 0;
            for (int i = 0; i < GetSize(); i++)
            {
                Order order = GetItem(i);
                finalPrice += order.GetQuantity() * order.GetArticle().GetPrice();
            }

            return finalPrice;
        }

        /// <summary>
        /// Sort the Articles in alphabetical order
        /// </summary>
        public void Sort()
        {
            List<Order> sortingList = new List<Order>();
            for (int i = 0; i < GetSize(); i++)
            {
                sortingList.Add(GetItem(i));
            }

            sortingList.Sort((Order x, Order y) =>
            {
                return x.GetArticle().GetDesignation().CompareTo(y.GetArticle().GetDesignation());
            });

            DelAll();

            foreach (Order a in sortingList)
            {
                Add(a);
            }
        }
    }
}
