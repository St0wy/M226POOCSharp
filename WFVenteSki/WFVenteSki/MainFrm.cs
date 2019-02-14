using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFVenteSki
{
    public partial class MainFrm : Form
    {
        //Fields
        ArticleModel am;
        OrderModel om;

        //Properties
        internal ArticleModel Am { get => am; set => am = value; }
        internal OrderModel Om { get => om; set => om = value; }

        //Constructors
        public MainFrm()
        {
            InitializeComponent();

            Am = new ArticleModel(new List<Article>());
            Om = new OrderModel(new List<Order>());

            InitalState();
            LoadArticles();
            UpdateView();
            lblCurrency.Text = Article.CURRENCY;
        }

        //Methods
        private void InitalState()
        {
            Am.DelAll();
            lsvArticles.Items.Clear();
            Om.DelAll();
            lsvOrders.Items.Clear();
            tbxNumberArticle.Text = "";
            tbxOrderPrice.Text = "";
            this.lsvArticles.Columns.Add("", -2);
            this.lsvOrders.Columns.Add("", -2);
        }

        /// <summary>
        /// Load the articles into the listbox.
        /// </summary>
        private void LoadArticles()
        {
            List<Article> lstArticle = ArticleDao.GetListeArticles();
            foreach (Article article in lstArticle)
            {
                Am.Add(article);
            }
        }

        /// <summary>
        /// Add order to the list.
        /// </summary>
        private void AddOrder()
        {
            for (int i = 0; i < lsvArticles.Items.Count; i++)
            {
                foreach (ListViewItem articleName in lsvArticles.SelectedItems)
                {
                    if (lsvArticles.Items[i].ToString() == articleName.ToString())
                    {
                        Om.AddOrder(Am.GetItem(i));
                    }
                }
            }
        }

        /// <summary>
        /// Delete the selected order in the order list.
        /// </summary>
        private void DeleteOrder()
        {
            for (int i = lsvOrders.Items.Count - 1; i > -1; i--)
            {
                foreach (ListViewItem orderName in lsvOrders.SelectedItems)
                {
                    if (lsvOrders.Items[i].ToString() == orderName.ToString())
                    {
                        Om.Del(i);
                    }
                }
            }
        }

        /// <summary>
        /// Compute the final price.
        /// </summary>
        private void ComputeResults()
        {
            double finalPrice = Om.ComputeResult();
            int nbrItems = 0;
            for (int i = 0; i < Om.GetSize(); i++)
            {
                nbrItems += Om.GetItem(i).GetQuantity();
            }
            tbxOrderPrice.Text = finalPrice.ToString();
            tbxNumberArticle.Text = nbrItems.ToString();
        }

        /// <summary>
        /// Show the articles and the order on the view.
        /// </summary>
        private void ShowOrder()
        {
            lsvArticles.Items.Clear();
            for (int i = 0; i < Am.GetSize(); i++)
            {
                Article article = Am.GetItem(i);
                lsvArticles.Items.Add(article.ToString());
            }

            lsvOrders.Items.Clear();
            for (int i = 0; i < Om.GetSize(); i++)
            {
                Order order = Om.GetItem(i);
                lsvOrders.Items.Add(order.ToString());
            }
        }

        /// <summary>
        /// Updates the view.
        /// </summary>
        private void UpdateView()
        {
            Am.Sort();
            Om.Sort();
            ShowOrder();
            ComputeResults();
        }

        private void BtnAddArticleToOrder_Click(object sender, EventArgs e)
        {
            AddOrder();
            UpdateView();
        }

        private void BtnRemoveArticleFromOrder_Click(object sender, EventArgs e)
        {
            DeleteOrder();
            UpdateView();
        }

        private void LsvArticles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvArticles.SelectedItems.Count < 0)
            {
                btnAddArticleToOrder.Enabled = false;
            }
            else
            {
                btnAddArticleToOrder.Enabled = true;
            }
        }

        private void LsvOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvOrders.SelectedItems.Count < 0)
            {
                btnRemoveArticleFromOrder.Enabled = false;
            }
            else
            {
                btnRemoveArticleFromOrder.Enabled = true;
            }
        }
    }
}
