namespace WFTicTacToe
{
    partial class frmTicTacToe
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
            this.lblCell00 = new System.Windows.Forms.Label();
            this.lblCell01 = new System.Windows.Forms.Label();
            this.lblCell02 = new System.Windows.Forms.Label();
            this.lblCell22 = new System.Windows.Forms.Label();
            this.lblCell21 = new System.Windows.Forms.Label();
            this.lblCell20 = new System.Windows.Forms.Label();
            this.lblCell12 = new System.Windows.Forms.Label();
            this.lblCell11 = new System.Windows.Forms.Label();
            this.lblCell10 = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCell00
            // 
            this.lblCell00.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCell00.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCell00.Location = new System.Drawing.Point(13, 13);
            this.lblCell00.Margin = new System.Windows.Forms.Padding(3);
            this.lblCell00.Name = "lblCell00";
            this.lblCell00.Size = new System.Drawing.Size(50, 50);
            this.lblCell00.TabIndex = 0;
            this.lblCell00.Tag = "00";
            this.lblCell00.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCell00.Click += new System.EventHandler(this.LblCell_Click);
            // 
            // lblCell01
            // 
            this.lblCell01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCell01.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCell01.Location = new System.Drawing.Point(69, 13);
            this.lblCell01.Margin = new System.Windows.Forms.Padding(3);
            this.lblCell01.Name = "lblCell01";
            this.lblCell01.Size = new System.Drawing.Size(50, 50);
            this.lblCell01.TabIndex = 1;
            this.lblCell01.Tag = "01";
            this.lblCell01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCell01.Click += new System.EventHandler(this.LblCell_Click);
            // 
            // lblCell02
            // 
            this.lblCell02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCell02.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCell02.Location = new System.Drawing.Point(125, 13);
            this.lblCell02.Margin = new System.Windows.Forms.Padding(3);
            this.lblCell02.Name = "lblCell02";
            this.lblCell02.Size = new System.Drawing.Size(50, 50);
            this.lblCell02.TabIndex = 2;
            this.lblCell02.Tag = "02";
            this.lblCell02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCell02.Click += new System.EventHandler(this.LblCell_Click);
            // 
            // lblCell22
            // 
            this.lblCell22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCell22.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCell22.Location = new System.Drawing.Point(125, 125);
            this.lblCell22.Margin = new System.Windows.Forms.Padding(3);
            this.lblCell22.Name = "lblCell22";
            this.lblCell22.Size = new System.Drawing.Size(50, 50);
            this.lblCell22.TabIndex = 5;
            this.lblCell22.Tag = "22";
            this.lblCell22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCell22.Click += new System.EventHandler(this.LblCell_Click);
            // 
            // lblCell21
            // 
            this.lblCell21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCell21.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCell21.Location = new System.Drawing.Point(69, 125);
            this.lblCell21.Margin = new System.Windows.Forms.Padding(3);
            this.lblCell21.Name = "lblCell21";
            this.lblCell21.Size = new System.Drawing.Size(50, 50);
            this.lblCell21.TabIndex = 4;
            this.lblCell21.Tag = "21";
            this.lblCell21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCell21.Click += new System.EventHandler(this.LblCell_Click);
            // 
            // lblCell20
            // 
            this.lblCell20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCell20.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCell20.Location = new System.Drawing.Point(13, 125);
            this.lblCell20.Margin = new System.Windows.Forms.Padding(3);
            this.lblCell20.Name = "lblCell20";
            this.lblCell20.Size = new System.Drawing.Size(50, 50);
            this.lblCell20.TabIndex = 3;
            this.lblCell20.Tag = "20";
            this.lblCell20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCell20.Click += new System.EventHandler(this.LblCell_Click);
            // 
            // lblCell12
            // 
            this.lblCell12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCell12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCell12.Location = new System.Drawing.Point(125, 69);
            this.lblCell12.Margin = new System.Windows.Forms.Padding(3);
            this.lblCell12.Name = "lblCell12";
            this.lblCell12.Size = new System.Drawing.Size(50, 50);
            this.lblCell12.TabIndex = 8;
            this.lblCell12.Tag = "12";
            this.lblCell12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCell12.Click += new System.EventHandler(this.LblCell_Click);
            // 
            // lblCell11
            // 
            this.lblCell11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCell11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCell11.Location = new System.Drawing.Point(69, 69);
            this.lblCell11.Margin = new System.Windows.Forms.Padding(3);
            this.lblCell11.Name = "lblCell11";
            this.lblCell11.Size = new System.Drawing.Size(50, 50);
            this.lblCell11.TabIndex = 7;
            this.lblCell11.Tag = "11";
            this.lblCell11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCell11.Click += new System.EventHandler(this.LblCell_Click);
            // 
            // lblCell10
            // 
            this.lblCell10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCell10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCell10.Location = new System.Drawing.Point(13, 69);
            this.lblCell10.Margin = new System.Windows.Forms.Padding(3);
            this.lblCell10.Name = "lblCell10";
            this.lblCell10.Size = new System.Drawing.Size(50, 50);
            this.lblCell10.TabIndex = 6;
            this.lblCell10.Tag = "10";
            this.lblCell10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCell10.Click += new System.EventHandler(this.LblCell_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(13, 181);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(162, 46);
            this.btnNewGame.TabIndex = 9;
            this.btnNewGame.Text = "Nouvelle partie";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.BtnNewGame_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.ForeColor = System.Drawing.Color.Blue;
            this.lblInfo.Location = new System.Drawing.Point(10, 230);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(165, 29);
            this.lblInfo.TabIndex = 10;
            this.lblInfo.Tag = "info";
            this.lblInfo.Text = "lblInfo";
            // 
            // frmTicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 268);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblCell12);
            this.Controls.Add(this.lblCell11);
            this.Controls.Add(this.lblCell10);
            this.Controls.Add(this.lblCell22);
            this.Controls.Add(this.lblCell21);
            this.Controls.Add(this.lblCell20);
            this.Controls.Add(this.lblCell02);
            this.Controls.Add(this.lblCell01);
            this.Controls.Add(this.lblCell00);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmTicTacToe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.FrmTicTacToe_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCell00;
        private System.Windows.Forms.Label lblCell01;
        private System.Windows.Forms.Label lblCell02;
        private System.Windows.Forms.Label lblCell22;
        private System.Windows.Forms.Label lblCell21;
        private System.Windows.Forms.Label lblCell20;
        private System.Windows.Forms.Label lblCell12;
        private System.Windows.Forms.Label lblCell11;
        private System.Windows.Forms.Label lblCell10;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label lblInfo;
    }
}

