using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFCommande
{
    public partial class frmOrder : Form
    {
        //Properties
        Product pasta;
        Product bbq;
        Product pizza;
        Product sauce;

        Shop myShop;

        enum ButtonTag { Pasta=0, BBQ=1, Pizza=2, Sauce=3, Order=4};

        //Constructor
        public frmOrder()
        {
            InitializeComponent();

            pasta = new Product("Pasta", 12.5M);
            bbq = new Product("BBQ", 15M);
            pizza = new Product("Pizza", 17M);
            sauce = new Product("Sauce", 5M);

            myShop = new Shop();
            myShop.AddProduct(pasta);
            myShop.AddProduct(bbq);
            myShop.AddProduct(pizza);
            myShop.AddProduct(sauce);
        }

        //Method
        private void FrmOrder_Load(object sender, EventArgs e)
        {

        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            tbxFacture.Text = "";
            switch (Convert.ToInt32((sender as Button).Tag)) //To differenciate the buttons
            {
                case (int)ButtonTag.Pasta:
                    if (pasta.Quantity < 50)
                    {
                        pasta.BuyOne();
                        btnOrderPasta.Text = $"Commander Pate : {pasta.Quantity}";
                    }
                    break;
                case (int)ButtonTag.BBQ:
                    if (bbq.Quantity < 50)
                    {
                        bbq.BuyOne();
                        btnOrderBBQ.Text = $"Commander BBQ : {bbq.Quantity}";
                    }
                    break;
                case (int)ButtonTag.Pizza:
                    if(pizza.Quantity < 50)
                    {
                        pizza.BuyOne();
                        btnOrderPizza.Text = $"Commander Pizza : {pizza.Quantity}";
                    }
                    break;
                case (int)ButtonTag.Sauce:
                    if(sauce.Quantity < 50)
                    {
                        sauce.BuyOne();
                        btnOrderSauce.Text = $"Commander Sauce : {sauce.Quantity}";
                    }
                    break;
                case (int)ButtonTag.Order:
                    tbxFacture.Text = myShop.GetBill();
                    myShop.ClearProducts();
                    break;
                default:
                    break;
            }
        }
    }
}
