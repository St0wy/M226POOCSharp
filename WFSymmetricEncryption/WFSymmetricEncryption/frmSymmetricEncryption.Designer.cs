namespace WFSymmetricEncryption
{
    partial class frmSymmetricEncryption
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
            this.tbxCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.btnHashCode = new System.Windows.Forms.Button();
            this.tbxHashedCode = new System.Windows.Forms.TextBox();
            this.tbxDecryptedText = new System.Windows.Forms.TextBox();
            this.tbxEncryptedText = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxCode
            // 
            this.tbxCode.Location = new System.Drawing.Point(12, 29);
            this.tbxCode.Name = "tbxCode";
            this.tbxCode.Size = new System.Drawing.Size(118, 20);
            this.tbxCode.TabIndex = 0;
            this.tbxCode.TextChanged += new System.EventHandler(this.TbxCode_TextChanged);
            // 
            // lblCode
            // 
            this.lblCode.Location = new System.Drawing.Point(12, 9);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(49, 17);
            this.lblCode.TabIndex = 1;
            this.lblCode.Text = "Code";
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHashCode
            // 
            this.btnHashCode.Location = new System.Drawing.Point(136, 28);
            this.btnHashCode.Name = "btnHashCode";
            this.btnHashCode.Size = new System.Drawing.Size(54, 20);
            this.btnHashCode.TabIndex = 2;
            this.btnHashCode.Text = "Hash";
            this.btnHashCode.UseVisualStyleBackColor = true;
            this.btnHashCode.Click += new System.EventHandler(this.BtnHashCode_Click);
            // 
            // tbxHashedCode
            // 
            this.tbxHashedCode.Location = new System.Drawing.Point(12, 55);
            this.tbxHashedCode.Name = "tbxHashedCode";
            this.tbxHashedCode.ReadOnly = true;
            this.tbxHashedCode.Size = new System.Drawing.Size(178, 20);
            this.tbxHashedCode.TabIndex = 3;
            // 
            // tbxDecryptedText
            // 
            this.tbxDecryptedText.Location = new System.Drawing.Point(12, 140);
            this.tbxDecryptedText.Multiline = true;
            this.tbxDecryptedText.Name = "tbxDecryptedText";
            this.tbxDecryptedText.Size = new System.Drawing.Size(118, 131);
            this.tbxDecryptedText.TabIndex = 4;
            // 
            // tbxEncryptedText
            // 
            this.tbxEncryptedText.Location = new System.Drawing.Point(243, 140);
            this.tbxEncryptedText.Multiline = true;
            this.tbxEncryptedText.Name = "tbxEncryptedText";
            this.tbxEncryptedText.Size = new System.Drawing.Size(118, 131);
            this.tbxEncryptedText.TabIndex = 5;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Enabled = false;
            this.btnEncrypt.Location = new System.Drawing.Point(137, 140);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(100, 23);
            this.btnEncrypt.TabIndex = 6;
            this.btnEncrypt.Text = "Encripte";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.BtnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Enabled = false;
            this.btnDecrypt.Location = new System.Drawing.Point(136, 248);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(100, 23);
            this.btnDecrypt.TabIndex = 7;
            this.btnDecrypt.Text = "Decripte";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.BtnDecrypt_Click);
            // 
            // frmSymmetricEncryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 283);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.tbxEncryptedText);
            this.Controls.Add(this.tbxDecryptedText);
            this.Controls.Add(this.tbxHashedCode);
            this.Controls.Add(this.btnHashCode);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.tbxCode);
            this.Name = "frmSymmetricEncryption";
            this.Text = "Encryption Symetrique";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Button btnHashCode;
        private System.Windows.Forms.TextBox tbxHashedCode;
        private System.Windows.Forms.TextBox tbxDecryptedText;
        private System.Windows.Forms.TextBox tbxEncryptedText;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
    }
}

