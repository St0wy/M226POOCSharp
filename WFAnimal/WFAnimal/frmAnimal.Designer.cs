namespace WFAnimal
{
    partial class frmAnimal
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
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblAnimalName = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.btnRename = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom de l\'animal";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(16, 29);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(150, 20);
            this.tbxName.TabIndex = 1;
            // 
            // lblAnimalName
            // 
            this.lblAnimalName.AutoSize = true;
            this.lblAnimalName.Location = new System.Drawing.Point(16, 89);
            this.lblAnimalName.Name = "lblAnimalName";
            this.lblAnimalName.Size = new System.Drawing.Size(165, 13);
            this.lblAnimalName.TabIndex = 2;
            this.lblAnimalName.Text = "L\'animal dans ce projet s\'appelle: ";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(16, 110);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(87, 13);
            this.lblWeight.TabIndex = 3;
            this.lblWeight.Text = "Son poid est de: ";
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(16, 55);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(150, 23);
            this.btnRename.TabIndex = 4;
            this.btnRename.Text = "Renommer";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.BtnRename_Click);
            // 
            // frmAnimal
            // 
            this.AcceptButton = this.btnRename;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 356);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblAnimalName);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAnimal";
            this.Text = "Animal";
            this.Load += new System.EventHandler(this.FrmAnimal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblAnimalName;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Button btnRename;
    }
}

