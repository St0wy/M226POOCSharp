using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFCommande
{
    class Shop
    {
        //Properties
        List<Product> lstProducts;

        //Constructor
        public Shop()
        {
            lstProducts = new List<Product>();
        }

        //Method

        /// <summary>
        /// Add a product to the list of Product.
        /// </summary>
        /// <param name="p">The Product you wanna add.</param>
        public void AddProduct(Product p)
        {
            lstProducts.Add(p);
        }

        /// <summary>
        /// Get the total price of all products.
        /// </summary>
        /// <returns>The total price of all products.</returns>
        public int TotalPrice()
        {
            int totalPrice = 0;
            foreach (Product p in lstProducts)
            {
                totalPrice += p.TotalPrice();
            }
            return totalPrice;
        }

        /// <summary>
        /// Get the facture of the order.
        /// </summary>
        /// <returns></returns>
        public string GetBill()
        {
            string bill = "";
            bill += $"{new String('#', 31)}\r\n";
            foreach (Product p in lstProducts)
            {
                if(p.Quantity > 0)
                {
                    bill += String.Format("{0, 3}, {1, -20} a CHF {2, 4} ->   CHF {3, 4}\r\n", p.Quantity, p.Name, p.Price, p.TotalPrice());
                }
            }
            bill += string.Format("Le montant total a payer est de           CHF {0, 4}", this.TotalPrice());

            return bill;
        }

        public void ClearProducts()
        {
            lstProducts.Clear();
        }
    }
}
