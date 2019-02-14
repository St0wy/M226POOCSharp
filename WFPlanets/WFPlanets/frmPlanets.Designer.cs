namespace WFPlanets
{
    partial class frmPlanets
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
            this.btnCreatePlanet = new System.Windows.Forms.Button();
            this.gpPlanetProperties = new System.Windows.Forms.GroupBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlanetName = new System.Windows.Forms.Label();
            this.lblPlanet = new System.Windows.Forms.Label();
            this.gpPlanetProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreatePlanet
            // 
            this.btnCreatePlanet.Location = new System.Drawing.Point(13, 13);
            this.btnCreatePlanet.Name = "btnCreatePlanet";
            this.btnCreatePlanet.Size = new System.Drawing.Size(200, 36);
            this.btnCreatePlanet.TabIndex = 0;
            this.btnCreatePlanet.Text = "Creer la planette";
            this.btnCreatePlanet.UseVisualStyleBackColor = true;
            this.btnCreatePlanet.Click += new System.EventHandler(this.BtnCreatePlanet_Click);
            // 
            // gpPlanetProperties
            // 
            this.gpPlanetProperties.Controls.Add(this.btnColor);
            this.gpPlanetProperties.Controls.Add(this.label3);
            this.gpPlanetProperties.Controls.Add(this.tbxName);
            this.gpPlanetProperties.Controls.Add(this.label2);
            this.gpPlanetProperties.Controls.Add(this.nudSize);
            this.gpPlanetProperties.Controls.Add(this.label1);
            this.gpPlanetProperties.Location = new System.Drawing.Point(13, 55);
            this.gpPlanetProperties.Name = "gpPlanetProperties";
            this.gpPlanetProperties.Size = new System.Drawing.Size(200, 100);
            this.gpPlanetProperties.TabIndex = 1;
            this.gpPlanetProperties.TabStop = false;
            this.gpPlanetProperties.Text = "Proprietes de la planete";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(56, 66);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(138, 24);
            this.btnColor.TabIndex = 6;
            this.btnColor.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Couleur";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(56, 42);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(138, 20);
            this.tbxName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom";
            // 
            // nudSize
            // 
            this.nudSize.Location = new System.Drawing.Point(56, 18);
            this.nudSize.Name = "nudSize";
            this.nudSize.Size = new System.Drawing.Size(138, 20);
            this.nudSize.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Taille";
            // 
            // lblPlanetName
            // 
            this.lblPlanetName.BackColor = System.Drawing.Color.Black;
            this.lblPlanetName.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanetName.ForeColor = System.Drawing.Color.White;
            this.lblPlanetName.Location = new System.Drawing.Point(219, 13);
            this.lblPlanetName.Name = "lblPlanetName";
            this.lblPlanetName.Size = new System.Drawing.Size(165, 36);
            this.lblPlanetName.TabIndex = 2;
            this.lblPlanetName.Text = "Soleil";
            this.lblPlanetName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlanet
            // 
            this.lblPlanet.BackColor = System.Drawing.Color.Black;
            this.lblPlanet.Font = new System.Drawing.Font("Webdings", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblPlanet.ForeColor = System.Drawing.Color.White;
            this.lblPlanet.Location = new System.Drawing.Point(219, 49);
            this.lblPlanet.Name = "lblPlanet";
            this.lblPlanet.Size = new System.Drawing.Size(165, 106);
            this.lblPlanet.TabIndex = 3;
            this.lblPlanet.Text = "ü";
            this.lblPlanet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPlanets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 167);
            this.Controls.Add(this.lblPlanet);
            this.Controls.Add(this.lblPlanetName);
            this.Controls.Add(this.gpPlanetProperties);
            this.Controls.Add(this.btnCreatePlanet);
            this.Name = "frmPlanets";
            this.Text = "Planets";
            this.Load += new System.EventHandler(this.FrmPlanets_Load);
            this.gpPlanetProperties.ResumeLayout(false);
            this.gpPlanetProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreatePlanet;
        private System.Windows.Forms.GroupBox gpPlanetProperties;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlanetName;
        private System.Windows.Forms.Label lblPlanet;
    }
}

