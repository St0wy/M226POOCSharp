namespace WFPizza
{
    partial class FrmPizza
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
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalPizzaPrice = new System.Windows.Forms.Label();
            this.btnNewPizza = new System.Windows.Forms.Button();
            this.imlngredients = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(13, 13);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(311, 282);
            this.listView1.SmallImageList = this.imlngredients;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(330, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(311, 282);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total TTC:";
            // 
            // lblTotalPizzaPrice
            // 
            this.lblTotalPizzaPrice.AutoSize = true;
            this.lblTotalPizzaPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPizzaPrice.Location = new System.Drawing.Point(100, 302);
            this.lblTotalPizzaPrice.Name = "lblTotalPizzaPrice";
            this.lblTotalPizzaPrice.Size = new System.Drawing.Size(132, 20);
            this.lblTotalPizzaPrice.TabIndex = 3;
            this.lblTotalPizzaPrice.Text = "lblTotalPizzaPrice";
            // 
            // btnNewPizza
            // 
            this.btnNewPizza.Location = new System.Drawing.Point(17, 336);
            this.btnNewPizza.Name = "btnNewPizza";
            this.btnNewPizza.Size = new System.Drawing.Size(113, 43);
            this.btnNewPizza.TabIndex = 4;
            this.btnNewPizza.Text = "Nouvelle Pizza";
            this.btnNewPizza.UseVisualStyleBackColor = true;
            // 
            // imlngredients
            // 
            this.imlngredients.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imlngredients.ImageSize = new System.Drawing.Size(16, 16);
            this.imlngredients.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FrmPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 396);
            this.Controls.Add(this.btnNewPizza);
            this.Controls.Add(this.lblTotalPizzaPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.Name = "FrmPizza";
            this.Text = "Pizza";
            this.Load += new System.EventHandler(this.FrmPizza_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imlngredients;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalPizzaPrice;
        private System.Windows.Forms.Button btnNewPizza;
    }
}

