namespace WFVenteSki
{
    partial class MainFrm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddArticleToOrder = new System.Windows.Forms.Button();
            this.btnRemoveArticleFromOrder = new System.Windows.Forms.Button();
            this.tbxOrderPrice = new System.Windows.Forms.TextBox();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxNumberArticle = new System.Windows.Forms.TextBox();
            this.lsvArticles = new System.Windows.Forms.ListView();
            this.lsvOrders = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Artices";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Commande";
            // 
            // btnAddArticleToOrder
            // 
            this.btnAddArticleToOrder.Enabled = false;
            this.btnAddArticleToOrder.Location = new System.Drawing.Point(15, 308);
            this.btnAddArticleToOrder.Name = "btnAddArticleToOrder";
            this.btnAddArticleToOrder.Size = new System.Drawing.Size(226, 23);
            this.btnAddArticleToOrder.TabIndex = 4;
            this.btnAddArticleToOrder.Text = "Ajouter à la Commande";
            this.btnAddArticleToOrder.UseVisualStyleBackColor = true;
            this.btnAddArticleToOrder.Click += new System.EventHandler(this.BtnAddArticleToOrder_Click);
            // 
            // btnRemoveArticleFromOrder
            // 
            this.btnRemoveArticleFromOrder.Enabled = false;
            this.btnRemoveArticleFromOrder.Location = new System.Drawing.Point(282, 308);
            this.btnRemoveArticleFromOrder.Name = "btnRemoveArticleFromOrder";
            this.btnRemoveArticleFromOrder.Size = new System.Drawing.Size(352, 23);
            this.btnRemoveArticleFromOrder.TabIndex = 5;
            this.btnRemoveArticleFromOrder.Text = "Retirer de la Commande";
            this.btnRemoveArticleFromOrder.UseVisualStyleBackColor = true;
            this.btnRemoveArticleFromOrder.Click += new System.EventHandler(this.BtnRemoveArticleFromOrder_Click);
            // 
            // tbxOrderPrice
            // 
            this.tbxOrderPrice.Location = new System.Drawing.Point(506, 337);
            this.tbxOrderPrice.Name = "tbxOrderPrice";
            this.tbxOrderPrice.ReadOnly = true;
            this.tbxOrderPrice.Size = new System.Drawing.Size(82, 20);
            this.tbxOrderPrice.TabIndex = 6;
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Location = new System.Drawing.Point(594, 340);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(57, 13);
            this.lblCurrency.TabIndex = 7;
            this.lblCurrency.Text = "MONNAIE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "TOTAL COMMANDE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(398, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "NOMBRE ARTICLE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(594, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "articles";
            // 
            // tbxNumberArticle
            // 
            this.tbxNumberArticle.Location = new System.Drawing.Point(506, 363);
            this.tbxNumberArticle.Name = "tbxNumberArticle";
            this.tbxNumberArticle.ReadOnly = true;
            this.tbxNumberArticle.Size = new System.Drawing.Size(82, 20);
            this.tbxNumberArticle.TabIndex = 9;
            // 
            // lsvArticles
            // 
            this.lsvArticles.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lsvArticles.FullRowSelect = true;
            this.lsvArticles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lsvArticles.Location = new System.Drawing.Point(15, 26);
            this.lsvArticles.Name = "lsvArticles";
            this.lsvArticles.Size = new System.Drawing.Size(226, 276);
            this.lsvArticles.TabIndex = 12;
            this.lsvArticles.UseCompatibleStateImageBehavior = false;
            this.lsvArticles.View = System.Windows.Forms.View.Details;
            this.lsvArticles.SelectedIndexChanged += new System.EventHandler(this.LsvArticles_SelectedIndexChanged);
            // 
            // lsvOrders
            // 
            this.lsvOrders.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lsvOrders.Location = new System.Drawing.Point(282, 26);
            this.lsvOrders.Name = "lsvOrders";
            this.lsvOrders.Size = new System.Drawing.Size(352, 276);
            this.lsvOrders.TabIndex = 13;
            this.lsvOrders.UseCompatibleStateImageBehavior = false;
            this.lsvOrders.View = System.Windows.Forms.View.Details;
            this.lsvOrders.SelectedIndexChanged += new System.EventHandler(this.LsvOrders_SelectedIndexChanged);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 389);
            this.Controls.Add(this.lsvOrders);
            this.Controls.Add(this.lsvArticles);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxNumberArticle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.tbxOrderPrice);
            this.Controls.Add(this.btnRemoveArticleFromOrder);
            this.Controls.Add(this.btnAddArticleToOrder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainFrm";
            this.Text = "Commande de Matériel de Ski";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddArticleToOrder;
        private System.Windows.Forms.Button btnRemoveArticleFromOrder;
        private System.Windows.Forms.TextBox tbxOrderPrice;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxNumberArticle;
        private System.Windows.Forms.ListView lsvArticles;
        private System.Windows.Forms.ListView lsvOrders;
    }
}

