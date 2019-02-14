namespace WFNiche
{
    partial class FrmKennel
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
            this.gpKennel = new System.Windows.Forms.GroupBox();
            this.btnEmptyKennel = new System.Windows.Forms.Button();
            this.lblDogName = new System.Windows.Forms.Label();
            this.lblKennelOcccupied = new System.Windows.Forms.Label();
            this.btnEnterDog1 = new System.Windows.Forms.Button();
            this.btnEnterDog2 = new System.Windows.Forms.Button();
            this.btnEnterDog3 = new System.Windows.Forms.Button();
            this.gpKennel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpKennel
            // 
            this.gpKennel.Controls.Add(this.btnEmptyKennel);
            this.gpKennel.Controls.Add(this.lblDogName);
            this.gpKennel.Controls.Add(this.lblKennelOcccupied);
            this.gpKennel.Location = new System.Drawing.Point(12, 12);
            this.gpKennel.Name = "gpKennel";
            this.gpKennel.Size = new System.Drawing.Size(200, 100);
            this.gpKennel.TabIndex = 0;
            this.gpKennel.TabStop = false;
            this.gpKennel.Text = "Niche";
            // 
            // btnEmptyKennel
            // 
            this.btnEmptyKennel.Location = new System.Drawing.Point(6, 64);
            this.btnEmptyKennel.Name = "btnEmptyKennel";
            this.btnEmptyKennel.Size = new System.Drawing.Size(188, 30);
            this.btnEmptyKennel.TabIndex = 0;
            this.btnEmptyKennel.Text = "Vider";
            this.btnEmptyKennel.UseVisualStyleBackColor = true;
            this.btnEmptyKennel.Click += new System.EventHandler(this.BtnEmptyKennel_Click);
            // 
            // lblDogName
            // 
            this.lblDogName.AutoSize = true;
            this.lblDogName.Location = new System.Drawing.Point(6, 35);
            this.lblDogName.Name = "lblDogName";
            this.lblDogName.Size = new System.Drawing.Size(79, 13);
            this.lblDogName.TabIndex = 1;
            this.lblDogName.Text = "Nom du chien: ";
            // 
            // lblKennelOcccupied
            // 
            this.lblKennelOcccupied.AutoSize = true;
            this.lblKennelOcccupied.Location = new System.Drawing.Point(6, 16);
            this.lblKennelOcccupied.Name = "lblKennelOcccupied";
            this.lblKennelOcccupied.Size = new System.Drawing.Size(57, 13);
            this.lblKennelOcccupied.TabIndex = 0;
            this.lblKennelOcccupied.Text = "Occupee: ";
            // 
            // btnEnterDog1
            // 
            this.btnEnterDog1.Location = new System.Drawing.Point(12, 118);
            this.btnEnterDog1.Name = "btnEnterDog1";
            this.btnEnterDog1.Size = new System.Drawing.Size(200, 35);
            this.btnEnterDog1.TabIndex = 1;
            this.btnEnterDog1.Tag = "0";
            this.btnEnterDog1.Text = "Faire entrer chien 1";
            this.btnEnterDog1.UseVisualStyleBackColor = true;
            this.btnEnterDog1.Click += new System.EventHandler(this.BtnEnterDog_Click);
            // 
            // btnEnterDog2
            // 
            this.btnEnterDog2.Location = new System.Drawing.Point(12, 159);
            this.btnEnterDog2.Name = "btnEnterDog2";
            this.btnEnterDog2.Size = new System.Drawing.Size(200, 35);
            this.btnEnterDog2.TabIndex = 2;
            this.btnEnterDog2.Tag = "1";
            this.btnEnterDog2.Text = "Faire entrer chien 2";
            this.btnEnterDog2.UseVisualStyleBackColor = true;
            this.btnEnterDog2.Click += new System.EventHandler(this.BtnEnterDog_Click);
            // 
            // btnEnterDog3
            // 
            this.btnEnterDog3.Location = new System.Drawing.Point(12, 200);
            this.btnEnterDog3.Name = "btnEnterDog3";
            this.btnEnterDog3.Size = new System.Drawing.Size(200, 35);
            this.btnEnterDog3.TabIndex = 3;
            this.btnEnterDog3.Tag = "2";
            this.btnEnterDog3.Text = "Faire entrer chien 3";
            this.btnEnterDog3.UseVisualStyleBackColor = true;
            this.btnEnterDog3.Click += new System.EventHandler(this.BtnEnterDog_Click);
            // 
            // FrmKennel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 245);
            this.Controls.Add(this.btnEnterDog3);
            this.Controls.Add(this.btnEnterDog2);
            this.Controls.Add(this.btnEnterDog1);
            this.Controls.Add(this.gpKennel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmKennel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmKennel_FormClosed);
            this.Load += new System.EventHandler(this.FrmKennel_Load);
            this.gpKennel.ResumeLayout(false);
            this.gpKennel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpKennel;
        private System.Windows.Forms.Button btnEmptyKennel;
        private System.Windows.Forms.Label lblDogName;
        private System.Windows.Forms.Label lblKennelOcccupied;
        private System.Windows.Forms.Button btnEnterDog1;
        private System.Windows.Forms.Button btnEnterDog2;
        private System.Windows.Forms.Button btnEnterDog3;
    }
}

