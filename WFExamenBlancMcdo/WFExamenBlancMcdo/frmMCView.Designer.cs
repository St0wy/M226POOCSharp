namespace WFExamenBlancMcdo
{
    partial class frmMCView
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
            this.cbxMainCourse = new System.Windows.Forms.ComboBox();
            this.cbxSideOrder = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxDrink = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalculateFat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMealKCal = new System.Windows.Forms.Label();
            this.lblTotalKCal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(542, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculateur de calories d\'un menu McDonald de taille moyenne";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(14, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Main Course";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxMainCourse
            // 
            this.cbxMainCourse.FormattingEnabled = true;
            this.cbxMainCourse.Location = new System.Drawing.Point(89, 90);
            this.cbxMainCourse.Name = "cbxMainCourse";
            this.cbxMainCourse.Size = new System.Drawing.Size(162, 21);
            this.cbxMainCourse.TabIndex = 2;
            // 
            // cbxSideOrder
            // 
            this.cbxSideOrder.FormattingEnabled = true;
            this.cbxSideOrder.Location = new System.Drawing.Point(89, 117);
            this.cbxSideOrder.Name = "cbxSideOrder";
            this.cbxSideOrder.Size = new System.Drawing.Size(162, 21);
            this.cbxSideOrder.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(14, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Side Order";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxDrink
            // 
            this.cbxDrink.FormattingEnabled = true;
            this.cbxDrink.Location = new System.Drawing.Point(89, 144);
            this.cbxDrink.Name = "cbxDrink";
            this.cbxDrink.Size = new System.Drawing.Size(162, 21);
            this.cbxDrink.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(14, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Drink";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCalculateFat
            // 
            this.btnCalculateFat.Location = new System.Drawing.Point(89, 171);
            this.btnCalculateFat.Name = "btnCalculateFat";
            this.btnCalculateFat.Size = new System.Drawing.Size(162, 23);
            this.btnCalculateFat.TabIndex = 7;
            this.btnCalculateFat.Text = "What the Fat ???";
            this.btnCalculateFat.UseVisualStyleBackColor = true;
            this.btnCalculateFat.Click += new System.EventHandler(this.BtnCalculateFat_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(351, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Your meal is :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMealKCal
            // 
            this.lblMealKCal.Location = new System.Drawing.Point(351, 90);
            this.lblMealKCal.Name = "lblMealKCal";
            this.lblMealKCal.Size = new System.Drawing.Size(203, 75);
            this.lblMealKCal.TabIndex = 9;
            this.lblMealKCal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalKCal
            // 
            this.lblTotalKCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalKCal.Location = new System.Drawing.Point(351, 172);
            this.lblTotalKCal.Name = "lblTotalKCal";
            this.lblTotalKCal.Size = new System.Drawing.Size(203, 21);
            this.lblTotalKCal.TabIndex = 12;
            this.lblTotalKCal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMCView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 219);
            this.Controls.Add(this.lblTotalKCal);
            this.Controls.Add(this.lblMealKCal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCalculateFat);
            this.Controls.Add(this.cbxDrink);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxSideOrder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxMainCourse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMCView";
            this.Text = "Super Size Me";
            this.Load += new System.EventHandler(this.FrmMCView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxMainCourse;
        private System.Windows.Forms.ComboBox cbxSideOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxDrink;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalculateFat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMealKCal;
        private System.Windows.Forms.Label lblTotalKCal;
    }
}

