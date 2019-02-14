namespace WFCommande
{
    partial class frmOrder
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
            this.btnOrderPasta = new System.Windows.Forms.Button();
            this.btnOrderBBQ = new System.Windows.Forms.Button();
            this.btnOrderSauce = new System.Windows.Forms.Button();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.tbxFacture = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOrderPasta
            // 
            this.btnOrderPasta.Location = new System.Drawing.Point(12, 12);
            this.btnOrderPasta.Name = "btnOrderPasta";
            this.btnOrderPasta.Size = new System.Drawing.Size(130, 42);
            this.btnOrderPasta.TabIndex = 0;
            this.btnOrderPasta.Tag = "0";
            this.btnOrderPasta.Text = "Commander Pate";
            this.btnOrderPasta.UseVisualStyleBackColor = true;
            this.btnOrderPasta.Click += new System.EventHandler(this.BtnOrder_Click);
            // 
            // btnOrderBBQ
            // 
            this.btnOrderBBQ.Location = new System.Drawing.Point(148, 12);
            this.btnOrderBBQ.Name = "btnOrderBBQ";
            this.btnOrderBBQ.Size = new System.Drawing.Size(130, 42);
            this.btnOrderBBQ.TabIndex = 1;
            this.btnOrderBBQ.Tag = "1";
            this.btnOrderBBQ.Text = "Commander BBQ";
            this.btnOrderBBQ.UseVisualStyleBackColor = true;
            this.btnOrderBBQ.Click += new System.EventHandler(this.BtnOrder_Click);
            // 
            // btnOrderSauce
            // 
            this.btnOrderSauce.Location = new System.Drawing.Point(420, 12);
            this.btnOrderSauce.Name = "btnOrderSauce";
            this.btnOrderSauce.Size = new System.Drawing.Size(130, 42);
            this.btnOrderSauce.TabIndex = 3;
            this.btnOrderSauce.Tag = "3";
            this.btnOrderSauce.Text = "Commander Sauce";
            this.btnOrderSauce.UseVisualStyleBackColor = true;
            this.btnOrderSauce.Click += new System.EventHandler(this.BtnOrder_Click);
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.Location = new System.Drawing.Point(284, 12);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(130, 42);
            this.btnOrderPizza.TabIndex = 2;
            this.btnOrderPizza.Tag = "2";
            this.btnOrderPizza.Text = "Commander Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = true;
            this.btnOrderPizza.Click += new System.EventHandler(this.BtnOrder_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(11, 60);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(539, 42);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Tag = "4";
            this.btnOrder.Text = "Commander";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.BtnOrder_Click);
            // 
            // tbxFacture
            // 
            this.tbxFacture.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFacture.Location = new System.Drawing.Point(12, 108);
            this.tbxFacture.Multiline = true;
            this.tbxFacture.Name = "tbxFacture";
            this.tbxFacture.ReadOnly = true;
            this.tbxFacture.Size = new System.Drawing.Size(538, 411);
            this.tbxFacture.TabIndex = 5;
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 531);
            this.Controls.Add(this.tbxFacture);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnOrderSauce);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.btnOrderBBQ);
            this.Controls.Add(this.btnOrderPasta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmOrder";
            this.Text = "Commande";
            this.Load += new System.EventHandler(this.FrmOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrderPasta;
        private System.Windows.Forms.Button btnOrderBBQ;
        private System.Windows.Forms.Button btnOrderSauce;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.TextBox tbxFacture;
    }
}

