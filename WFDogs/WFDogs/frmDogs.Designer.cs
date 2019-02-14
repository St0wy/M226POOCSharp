namespace WFDogs
{
    partial class frmDogs
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
            this.gpNewDog = new System.Windows.Forms.GroupBox();
            this.btnCreateNewDog = new System.Windows.Forms.Button();
            this.tbxNameDog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpDogInProgram = new System.Windows.Forms.GroupBox();
            this.btnBark = new System.Windows.Forms.Button();
            this.lblDogSize = new System.Windows.Forms.Label();
            this.lblDogName = new System.Windows.Forms.Label();
            this.lblBark = new System.Windows.Forms.Label();
            this.gpNewDog.SuspendLayout();
            this.gpDogInProgram.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpNewDog
            // 
            this.gpNewDog.Controls.Add(this.btnCreateNewDog);
            this.gpNewDog.Controls.Add(this.tbxNameDog);
            this.gpNewDog.Controls.Add(this.label1);
            this.gpNewDog.Location = new System.Drawing.Point(12, 12);
            this.gpNewDog.Name = "gpNewDog";
            this.gpNewDog.Size = new System.Drawing.Size(200, 100);
            this.gpNewDog.TabIndex = 0;
            this.gpNewDog.TabStop = false;
            this.gpNewDog.Text = "Creer un nouveau chien";
            // 
            // btnCreateNewDog
            // 
            this.btnCreateNewDog.Enabled = false;
            this.btnCreateNewDog.Location = new System.Drawing.Point(6, 71);
            this.btnCreateNewDog.Name = "btnCreateNewDog";
            this.btnCreateNewDog.Size = new System.Drawing.Size(188, 23);
            this.btnCreateNewDog.TabIndex = 2;
            this.btnCreateNewDog.Text = "Creer";
            this.btnCreateNewDog.UseVisualStyleBackColor = true;
            this.btnCreateNewDog.Click += new System.EventHandler(this.BtnCreateNewDog_Click);
            // 
            // tbxNameDog
            // 
            this.tbxNameDog.Location = new System.Drawing.Point(47, 23);
            this.tbxNameDog.Name = "tbxNameDog";
            this.tbxNameDog.Size = new System.Drawing.Size(147, 20);
            this.tbxNameDog.TabIndex = 1;
            this.tbxNameDog.TextChanged += new System.EventHandler(this.tbxNameDog_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom: ";
            // 
            // gpDogInProgram
            // 
            this.gpDogInProgram.Controls.Add(this.btnBark);
            this.gpDogInProgram.Controls.Add(this.lblDogSize);
            this.gpDogInProgram.Controls.Add(this.lblDogName);
            this.gpDogInProgram.Location = new System.Drawing.Point(218, 12);
            this.gpDogInProgram.Name = "gpDogInProgram";
            this.gpDogInProgram.Size = new System.Drawing.Size(200, 100);
            this.gpDogInProgram.TabIndex = 3;
            this.gpDogInProgram.TabStop = false;
            this.gpDogInProgram.Text = "Chien dans le programme";
            // 
            // btnBark
            // 
            this.btnBark.Location = new System.Drawing.Point(7, 71);
            this.btnBark.Name = "btnBark";
            this.btnBark.Size = new System.Drawing.Size(187, 23);
            this.btnBark.TabIndex = 2;
            this.btnBark.Text = "Bark";
            this.btnBark.UseVisualStyleBackColor = true;
            this.btnBark.Click += new System.EventHandler(this.BtnBark_Click);
            // 
            // lblDogSize
            // 
            this.lblDogSize.AutoSize = true;
            this.lblDogSize.Location = new System.Drawing.Point(6, 30);
            this.lblDogSize.Name = "lblDogSize";
            this.lblDogSize.Size = new System.Drawing.Size(38, 13);
            this.lblDogSize.TabIndex = 1;
            this.lblDogSize.Text = "Taille: ";
            // 
            // lblDogName
            // 
            this.lblDogName.AutoSize = true;
            this.lblDogName.Location = new System.Drawing.Point(6, 16);
            this.lblDogName.Name = "lblDogName";
            this.lblDogName.Size = new System.Drawing.Size(35, 13);
            this.lblDogName.TabIndex = 0;
            this.lblDogName.Text = "Nom: ";
            // 
            // lblBark
            // 
            this.lblBark.AutoSize = true;
            this.lblBark.Location = new System.Drawing.Point(9, 115);
            this.lblBark.Name = "lblBark";
            this.lblBark.Size = new System.Drawing.Size(0, 13);
            this.lblBark.TabIndex = 4;
            // 
            // frmDogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 220);
            this.Controls.Add(this.lblBark);
            this.Controls.Add(this.gpDogInProgram);
            this.Controls.Add(this.gpNewDog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDogs";
            this.Text = "Dogs";
            this.gpNewDog.ResumeLayout(false);
            this.gpNewDog.PerformLayout();
            this.gpDogInProgram.ResumeLayout(false);
            this.gpDogInProgram.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpNewDog;
        private System.Windows.Forms.Button btnCreateNewDog;
        private System.Windows.Forms.TextBox tbxNameDog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpDogInProgram;
        private System.Windows.Forms.Button btnBark;
        private System.Windows.Forms.Label lblDogSize;
        private System.Windows.Forms.Label lblDogName;
        private System.Windows.Forms.Label lblBark;
    }
}

