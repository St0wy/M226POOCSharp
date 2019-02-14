namespace WFTriangle
{
    partial class frmTriangle
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
            this.tbxSideA = new System.Windows.Forms.TextBox();
            this.tbxSideB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxSideC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInfoTriangle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Side A";
            // 
            // tbxSideA
            // 
            this.tbxSideA.Location = new System.Drawing.Point(57, 12);
            this.tbxSideA.Name = "tbxSideA";
            this.tbxSideA.Size = new System.Drawing.Size(100, 20);
            this.tbxSideA.TabIndex = 1;
            // 
            // tbxSideB
            // 
            this.tbxSideB.Location = new System.Drawing.Point(57, 38);
            this.tbxSideB.Name = "tbxSideB";
            this.tbxSideB.Size = new System.Drawing.Size(100, 20);
            this.tbxSideB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Side B";
            // 
            // tbxSideC
            // 
            this.tbxSideC.Location = new System.Drawing.Point(57, 64);
            this.tbxSideC.Name = "tbxSideC";
            this.tbxSideC.Size = new System.Drawing.Size(100, 20);
            this.tbxSideC.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Side C";
            // 
            // btnInfoTriangle
            // 
            this.btnInfoTriangle.Location = new System.Drawing.Point(211, 15);
            this.btnInfoTriangle.Name = "btnInfoTriangle";
            this.btnInfoTriangle.Size = new System.Drawing.Size(75, 23);
            this.btnInfoTriangle.TabIndex = 6;
            this.btnInfoTriangle.Text = "Info Triangle";
            this.btnInfoTriangle.UseVisualStyleBackColor = true;
            this.btnInfoTriangle.Click += new System.EventHandler(this.BtnInfoTriangle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Result";
            // 
            // tbxResult
            // 
            this.tbxResult.Location = new System.Drawing.Point(56, 119);
            this.tbxResult.Multiline = true;
            this.tbxResult.Name = "tbxResult";
            this.tbxResult.Size = new System.Drawing.Size(255, 91);
            this.tbxResult.TabIndex = 8;
            // 
            // frmTriangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 222);
            this.Controls.Add(this.tbxResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnInfoTriangle);
            this.Controls.Add(this.tbxSideC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxSideB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxSideA);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmTriangle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Triangle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSideA;
        private System.Windows.Forms.TextBox tbxSideB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxSideC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInfoTriangle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxResult;
    }
}

