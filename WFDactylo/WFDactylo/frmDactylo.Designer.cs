namespace WFDactylo
{
    partial class frmDactylo
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbxWord = new System.Windows.Forms.TextBox();
            this.lblWordToWrite = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblTimeSpent = new System.Windows.Forms.Label();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(163, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Cliquez sur start pour commencer";
            // 
            // tbxWord
            // 
            this.tbxWord.Location = new System.Drawing.Point(12, 52);
            this.tbxWord.Name = "tbxWord";
            this.tbxWord.Size = new System.Drawing.Size(163, 20);
            this.tbxWord.TabIndex = 1;
            this.tbxWord.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // lblWordToWrite
            // 
            this.lblWordToWrite.AutoSize = true;
            this.lblWordToWrite.Location = new System.Drawing.Point(12, 36);
            this.lblWordToWrite.Name = "lblWordToWrite";
            this.lblWordToWrite.Size = new System.Drawing.Size(80, 13);
            this.lblWordToWrite.TabIndex = 2;
            this.lblWordToWrite.Text = "lblWordToType";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 79);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // lblTimeSpent
            // 
            this.lblTimeSpent.AutoSize = true;
            this.lblTimeSpent.Location = new System.Drawing.Point(12, 109);
            this.lblTimeSpent.Name = "lblTimeSpent";
            this.lblTimeSpent.Size = new System.Drawing.Size(76, 13);
            this.lblTimeSpent.TabIndex = 4;
            this.lblTimeSpent.Text = "Temps passe: ";
            // 
            // tmrMain
            // 
            this.tmrMain.Interval = 1000;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // frmDactylo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 151);
            this.Controls.Add(this.lblTimeSpent);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblWordToWrite);
            this.Controls.Add(this.tbxWord);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDactylo";
            this.Text = "Dactylo";
            this.Load += new System.EventHandler(this.FrmDactylo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbxWord;
        private System.Windows.Forms.Label lblWordToWrite;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblTimeSpent;
        private System.Windows.Forms.Timer tmrMain;
    }
}

