namespace WFCapitales
{
    partial class CACView
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
            this.mstMain = new System.Windows.Forms.MenuStrip();
            this.tsmFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLoadListCountryAndCapitals = new System.Windows.Forms.ToolStripMenuItem();
            this.mScores = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMode = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGuessCaptial = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGuessCountry = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNbrQuestion = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblAfterQuestion = new System.Windows.Forms.Label();
            this.btnAnswer1 = new System.Windows.Forms.Button();
            this.btnAnswer2 = new System.Windows.Forms.Button();
            this.btnAnswer3 = new System.Windows.Forms.Button();
            this.btnLastQuestion = new System.Windows.Forms.Button();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.mstMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstMain
            // 
            this.mstMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFiles,
            this.mScores,
            this.tsmMode,
            this.tsmHelp});
            this.mstMain.Location = new System.Drawing.Point(0, 0);
            this.mstMain.Name = "mstMain";
            this.mstMain.Size = new System.Drawing.Size(800, 24);
            this.mstMain.TabIndex = 2;
            this.mstMain.Text = "menuStrip1";
            // 
            // tsmFiles
            // 
            this.tsmFiles.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLoadListCountryAndCapitals});
            this.tsmFiles.Name = "tsmFiles";
            this.tsmFiles.Size = new System.Drawing.Size(54, 20);
            this.tsmFiles.Text = "Fichier";
            // 
            // tsmLoadListCountryAndCapitals
            // 
            this.tsmLoadListCountryAndCapitals.Name = "tsmLoadListCountryAndCapitals";
            this.tsmLoadListCountryAndCapitals.Size = new System.Drawing.Size(273, 22);
            this.tsmLoadListCountryAndCapitals.Text = "Charger une Liste Pays et de Capitales";
            this.tsmLoadListCountryAndCapitals.Click += new System.EventHandler(this.TsmLoadListCountryAndCapitals_Click);
            // 
            // mScores
            // 
            this.mScores.Name = "mScores";
            this.mScores.Size = new System.Drawing.Size(53, 20);
            this.mScores.Text = "Scores";
            // 
            // tsmMode
            // 
            this.tsmMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmGuessCaptial,
            this.tsmGuessCountry});
            this.tsmMode.Name = "tsmMode";
            this.tsmMode.Size = new System.Drawing.Size(50, 20);
            this.tsmMode.Text = "Mode";
            // 
            // tsmGuessCaptial
            // 
            this.tsmGuessCaptial.Name = "tsmGuessCaptial";
            this.tsmGuessCaptial.Size = new System.Drawing.Size(160, 22);
            this.tsmGuessCaptial.Text = "Deviner Capitale";
            this.tsmGuessCaptial.Click += new System.EventHandler(this.TsmGuessCapital_Click);
            // 
            // tsmGuessCountry
            // 
            this.tsmGuessCountry.Checked = true;
            this.tsmGuessCountry.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmGuessCountry.Name = "tsmGuessCountry";
            this.tsmGuessCountry.Size = new System.Drawing.Size(160, 22);
            this.tsmGuessCountry.Text = "Deviner Pays";
            this.tsmGuessCountry.Click += new System.EventHandler(this.TsmGuessCountry_Click);
            // 
            // tsmHelp
            // 
            this.tsmHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAbout});
            this.tsmHelp.Name = "tsmHelp";
            this.tsmHelp.Size = new System.Drawing.Size(43, 20);
            this.tsmHelp.Text = "Aide";
            // 
            // tsmAbout
            // 
            this.tsmAbout.Name = "tsmAbout";
            this.tsmAbout.Size = new System.Drawing.Size(122, 22);
            this.tsmAbout.Text = "À Propos";
            this.tsmAbout.Click += new System.EventHandler(this.TsmAbout_Click);
            // 
            // lblNbrQuestion
            // 
            this.lblNbrQuestion.Location = new System.Drawing.Point(12, 24);
            this.lblNbrQuestion.Name = "lblNbrQuestion";
            this.lblNbrQuestion.Size = new System.Drawing.Size(115, 23);
            this.lblNbrQuestion.TabIndex = 3;
            this.lblNbrQuestion.Text = "lblNbrQuestion";
            this.lblNbrQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblScore
            // 
            this.lblScore.Location = new System.Drawing.Point(680, 24);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(108, 23);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "lblScore";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(12, 130);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(776, 34);
            this.lblQuestion.TabIndex = 5;
            this.lblQuestion.Text = "lblQuestion";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAfterQuestion
            // 
            this.lblAfterQuestion.Location = new System.Drawing.Point(12, 164);
            this.lblAfterQuestion.Name = "lblAfterQuestion";
            this.lblAfterQuestion.Size = new System.Drawing.Size(776, 23);
            this.lblAfterQuestion.TabIndex = 6;
            this.lblAfterQuestion.Text = "lblAfterQuestion";
            this.lblAfterQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAnswer1
            // 
            this.btnAnswer1.Location = new System.Drawing.Point(136, 190);
            this.btnAnswer1.Name = "btnAnswer1";
            this.btnAnswer1.Size = new System.Drawing.Size(83, 34);
            this.btnAnswer1.TabIndex = 7;
            this.btnAnswer1.Tag = "answer";
            this.btnAnswer1.Text = "btnAnswer1";
            this.btnAnswer1.UseVisualStyleBackColor = true;
            this.btnAnswer1.Click += new System.EventHandler(this.BtnAnswer_Click);
            // 
            // btnAnswer2
            // 
            this.btnAnswer2.Location = new System.Drawing.Point(355, 190);
            this.btnAnswer2.Name = "btnAnswer2";
            this.btnAnswer2.Size = new System.Drawing.Size(83, 34);
            this.btnAnswer2.TabIndex = 8;
            this.btnAnswer2.Tag = "answer";
            this.btnAnswer2.Text = "btnAnswer2";
            this.btnAnswer2.UseVisualStyleBackColor = true;
            this.btnAnswer2.Click += new System.EventHandler(this.BtnAnswer_Click);
            // 
            // btnAnswer3
            // 
            this.btnAnswer3.Location = new System.Drawing.Point(582, 190);
            this.btnAnswer3.Name = "btnAnswer3";
            this.btnAnswer3.Size = new System.Drawing.Size(83, 34);
            this.btnAnswer3.TabIndex = 9;
            this.btnAnswer3.Tag = "answer";
            this.btnAnswer3.Text = "btnAnswer3";
            this.btnAnswer3.UseVisualStyleBackColor = true;
            this.btnAnswer3.Click += new System.EventHandler(this.BtnAnswer_Click);
            // 
            // btnLastQuestion
            // 
            this.btnLastQuestion.Location = new System.Drawing.Point(13, 257);
            this.btnLastQuestion.Name = "btnLastQuestion";
            this.btnLastQuestion.Size = new System.Drawing.Size(114, 23);
            this.btnLastQuestion.TabIndex = 10;
            this.btnLastQuestion.Text = "btnLastQuestion";
            this.btnLastQuestion.UseVisualStyleBackColor = true;
            this.btnLastQuestion.Click += new System.EventHandler(this.BtnLastQuestion_Click);
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.Location = new System.Drawing.Point(674, 257);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(114, 23);
            this.btnNextQuestion.TabIndex = 11;
            this.btnNextQuestion.Text = "btnNextQuestion";
            this.btnNextQuestion.UseVisualStyleBackColor = true;
            this.btnNextQuestion.Click += new System.EventHandler(this.BtnNextQuestion_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(685, 398);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(103, 40);
            this.btnNewGame.TabIndex = 12;
            this.btnNewGame.Text = "btnNewGame";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.BtnNewGame_Click);
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(355, 230);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(83, 35);
            this.btnStartGame.TabIndex = 13;
            this.btnStartGame.Text = "btnStartGame";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.BtnStartGame_Click);
            // 
            // CACView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnNextQuestion);
            this.Controls.Add(this.btnLastQuestion);
            this.Controls.Add(this.btnAnswer3);
            this.Controls.Add(this.btnAnswer2);
            this.Controls.Add(this.btnAnswer1);
            this.Controls.Add(this.lblAfterQuestion);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblNbrQuestion);
            this.Controls.Add(this.mstMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mstMain;
            this.MaximizeBox = false;
            this.Name = "CACView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Country Capital";
            this.Load += new System.EventHandler(this.CACView_Load);
            this.mstMain.ResumeLayout(false);
            this.mstMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstMain;
        private System.Windows.Forms.ToolStripMenuItem tsmFiles;
        private System.Windows.Forms.ToolStripMenuItem tsmLoadListCountryAndCapitals;
        private System.Windows.Forms.ToolStripMenuItem mScores;
        private System.Windows.Forms.ToolStripMenuItem tsmMode;
        private System.Windows.Forms.ToolStripMenuItem tsmHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmAbout;
        private System.Windows.Forms.Label lblNbrQuestion;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblAfterQuestion;
        private System.Windows.Forms.Button btnAnswer1;
        private System.Windows.Forms.Button btnAnswer2;
        private System.Windows.Forms.Button btnAnswer3;
        private System.Windows.Forms.Button btnLastQuestion;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.ToolStripMenuItem tsmGuessCaptial;
        private System.Windows.Forms.ToolStripMenuItem tsmGuessCountry;
    }
}

