namespace WFGestionFactures
{
    partial class FrmMain
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
            this.gpListClient = new System.Windows.Forms.GroupBox();
            this.gpNewArticle = new System.Windows.Forms.GroupBox();
            this.gpCurrentClient = new System.Windows.Forms.GroupBox();
            this.gpClientBils = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // gpListClient
            // 
            this.gpListClient.Location = new System.Drawing.Point(13, 13);
            this.gpListClient.Name = "gpListClient";
            this.gpListClient.Size = new System.Drawing.Size(200, 100);
            this.gpListClient.TabIndex = 0;
            this.gpListClient.TabStop = false;
            this.gpListClient.Text = "Liste des Clients";
            // 
            // gpNewArticle
            // 
            this.gpNewArticle.Location = new System.Drawing.Point(219, 13);
            this.gpNewArticle.Name = "gpNewArticle";
            this.gpNewArticle.Size = new System.Drawing.Size(200, 100);
            this.gpNewArticle.TabIndex = 1;
            this.gpNewArticle.TabStop = false;
            this.gpNewArticle.Text = "Nouvel Article";
            // 
            // gpCurrentClient
            // 
            this.gpCurrentClient.Location = new System.Drawing.Point(13, 119);
            this.gpCurrentClient.Name = "gpCurrentClient";
            this.gpCurrentClient.Size = new System.Drawing.Size(200, 100);
            this.gpCurrentClient.TabIndex = 1;
            this.gpCurrentClient.TabStop = false;
            this.gpCurrentClient.Text = "Client Courrant";
            // 
            // gpClientBils
            // 
            this.gpClientBils.Location = new System.Drawing.Point(219, 119);
            this.gpClientBils.Name = "gpClientBils";
            this.gpClientBils.Size = new System.Drawing.Size(200, 100);
            this.gpClientBils.TabIndex = 2;
            this.gpClientBils.TabStop = false;
            this.gpClientBils.Text = "Facture du Client";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpClientBils);
            this.Controls.Add(this.gpCurrentClient);
            this.Controls.Add(this.gpNewArticle);
            this.Controls.Add(this.gpListClient);
            this.Name = "FrmMain";
            this.Text = "Gestion des Factures";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpListClient;
        private System.Windows.Forms.GroupBox gpNewArticle;
        private System.Windows.Forms.GroupBox gpCurrentClient;
        private System.Windows.Forms.GroupBox gpClientBils;
    }
}

