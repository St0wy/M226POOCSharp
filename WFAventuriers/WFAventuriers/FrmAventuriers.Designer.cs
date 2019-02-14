namespace WFAventuriers
{
    partial class FrmAventuriers
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
            this.btnNewGame = new System.Windows.Forms.Button();
            this.gpWarrior = new System.Windows.Forms.GroupBox();
            this.pgbWarrior = new System.Windows.Forms.ProgressBar();
            this.tbxWarrior = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pgbMagician = new System.Windows.Forms.ProgressBar();
            this.tbxMagician = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pgbArcher = new System.Windows.Forms.ProgressBar();
            this.tbxArcher = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pgbPriest = new System.Windows.Forms.ProgressBar();
            this.tbxPriest = new System.Windows.Forms.TextBox();
            this.btnGameOver = new System.Windows.Forms.Button();
            this.gpWarrior.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(13, 13);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(451, 56);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.BtnNewGame_Click);
            // 
            // gpWarrior
            // 
            this.gpWarrior.Controls.Add(this.pgbWarrior);
            this.gpWarrior.Controls.Add(this.tbxWarrior);
            this.gpWarrior.Location = new System.Drawing.Point(13, 75);
            this.gpWarrior.Name = "gpWarrior";
            this.gpWarrior.Size = new System.Drawing.Size(200, 100);
            this.gpWarrior.TabIndex = 1;
            this.gpWarrior.TabStop = false;
            this.gpWarrior.Text = "Warrior";
            // 
            // pgbWarrior
            // 
            this.pgbWarrior.Location = new System.Drawing.Point(7, 56);
            this.pgbWarrior.Name = "pgbWarrior";
            this.pgbWarrior.Size = new System.Drawing.Size(187, 23);
            this.pgbWarrior.TabIndex = 1;
            // 
            // tbxWarrior
            // 
            this.tbxWarrior.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxWarrior.Location = new System.Drawing.Point(7, 20);
            this.tbxWarrior.Name = "tbxWarrior";
            this.tbxWarrior.ReadOnly = true;
            this.tbxWarrior.Size = new System.Drawing.Size(187, 27);
            this.tbxWarrior.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pgbMagician);
            this.groupBox1.Controls.Add(this.tbxMagician);
            this.groupBox1.Location = new System.Drawing.Point(264, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Magician";
            // 
            // pgbMagician
            // 
            this.pgbMagician.Location = new System.Drawing.Point(7, 56);
            this.pgbMagician.Name = "pgbMagician";
            this.pgbMagician.Size = new System.Drawing.Size(187, 23);
            this.pgbMagician.TabIndex = 1;
            // 
            // tbxMagician
            // 
            this.tbxMagician.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMagician.Location = new System.Drawing.Point(7, 20);
            this.tbxMagician.Name = "tbxMagician";
            this.tbxMagician.ReadOnly = true;
            this.tbxMagician.Size = new System.Drawing.Size(187, 27);
            this.tbxMagician.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pgbArcher);
            this.groupBox2.Controls.Add(this.tbxArcher);
            this.groupBox2.Location = new System.Drawing.Point(264, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Archer";
            // 
            // pgbArcher
            // 
            this.pgbArcher.Location = new System.Drawing.Point(7, 56);
            this.pgbArcher.Name = "pgbArcher";
            this.pgbArcher.Size = new System.Drawing.Size(187, 23);
            this.pgbArcher.TabIndex = 1;
            // 
            // tbxArcher
            // 
            this.tbxArcher.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxArcher.Location = new System.Drawing.Point(7, 20);
            this.tbxArcher.Name = "tbxArcher";
            this.tbxArcher.ReadOnly = true;
            this.tbxArcher.Size = new System.Drawing.Size(187, 27);
            this.tbxArcher.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pgbPriest);
            this.groupBox3.Controls.Add(this.tbxPriest);
            this.groupBox3.Location = new System.Drawing.Point(13, 181);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Priest";
            // 
            // pgbPriest
            // 
            this.pgbPriest.Location = new System.Drawing.Point(7, 56);
            this.pgbPriest.Name = "pgbPriest";
            this.pgbPriest.Size = new System.Drawing.Size(187, 23);
            this.pgbPriest.TabIndex = 1;
            // 
            // tbxPriest
            // 
            this.tbxPriest.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPriest.Location = new System.Drawing.Point(7, 20);
            this.tbxPriest.Name = "tbxPriest";
            this.tbxPriest.ReadOnly = true;
            this.tbxPriest.Size = new System.Drawing.Size(187, 27);
            this.tbxPriest.TabIndex = 0;
            // 
            // btnGameOver
            // 
            this.btnGameOver.Location = new System.Drawing.Point(13, 287);
            this.btnGameOver.Name = "btnGameOver";
            this.btnGameOver.Size = new System.Drawing.Size(451, 56);
            this.btnGameOver.TabIndex = 5;
            this.btnGameOver.Text = "Game Over";
            this.btnGameOver.UseVisualStyleBackColor = true;
            this.btnGameOver.Click += new System.EventHandler(this.BtnGameOver_Click);
            // 
            // FrmAventuriers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 355);
            this.Controls.Add(this.btnGameOver);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gpWarrior);
            this.Controls.Add(this.btnNewGame);
            this.Name = "FrmAventuriers";
            this.Text = "Exercice";
            this.gpWarrior.ResumeLayout(false);
            this.gpWarrior.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.GroupBox gpWarrior;
        private System.Windows.Forms.ProgressBar pgbWarrior;
        private System.Windows.Forms.TextBox tbxWarrior;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar pgbMagician;
        private System.Windows.Forms.TextBox tbxMagician;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar pgbArcher;
        private System.Windows.Forms.TextBox tbxArcher;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ProgressBar pgbPriest;
        private System.Windows.Forms.TextBox tbxPriest;
        private System.Windows.Forms.Button btnGameOver;
    }
}

