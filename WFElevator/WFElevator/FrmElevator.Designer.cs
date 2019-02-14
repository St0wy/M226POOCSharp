namespace WFElevator
{
    partial class FrmElevator
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
            this.tbxMaxFloor = new System.Windows.Forms.TextBox();
            this.tbxMinFloor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreateElevator = new System.Windows.Forms.Button();
            this.btnElevatorUp = new System.Windows.Forms.Button();
            this.btnElevatorDown = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.nudPerson = new System.Windows.Forms.NumericUpDown();
            this.btnRemovePerson = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "nb etages max";
            // 
            // tbxMaxFloor
            // 
            this.tbxMaxFloor.Location = new System.Drawing.Point(295, 12);
            this.tbxMaxFloor.Name = "tbxMaxFloor";
            this.tbxMaxFloor.Size = new System.Drawing.Size(42, 20);
            this.tbxMaxFloor.TabIndex = 1;
            this.tbxMaxFloor.TextChanged += new System.EventHandler(this.TbxMaxFloor_TextChanged);
            // 
            // tbxMinFloor
            // 
            this.tbxMinFloor.Location = new System.Drawing.Point(295, 38);
            this.tbxMinFloor.Name = "tbxMinFloor";
            this.tbxMinFloor.Size = new System.Drawing.Size(42, 20);
            this.tbxMinFloor.TabIndex = 3;
            this.tbxMinFloor.TextChanged += new System.EventHandler(this.TbxMaxFloor_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "nb etages s-sol";
            // 
            // btnCreateElevator
            // 
            this.btnCreateElevator.Enabled = false;
            this.btnCreateElevator.Location = new System.Drawing.Point(216, 65);
            this.btnCreateElevator.Name = "btnCreateElevator";
            this.btnCreateElevator.Size = new System.Drawing.Size(120, 23);
            this.btnCreateElevator.TabIndex = 4;
            this.btnCreateElevator.Text = "Creer ascenseur";
            this.btnCreateElevator.UseVisualStyleBackColor = true;
            this.btnCreateElevator.Click += new System.EventHandler(this.BtnCreateElevator_Click);
            // 
            // btnElevatorUp
            // 
            this.btnElevatorUp.Location = new System.Drawing.Point(263, 95);
            this.btnElevatorUp.Name = "btnElevatorUp";
            this.btnElevatorUp.Size = new System.Drawing.Size(27, 23);
            this.btnElevatorUp.TabIndex = 5;
            this.btnElevatorUp.Text = "^";
            this.btnElevatorUp.UseVisualStyleBackColor = true;
            this.btnElevatorUp.Click += new System.EventHandler(this.BtnElevatorUp_Click);
            // 
            // btnElevatorDown
            // 
            this.btnElevatorDown.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElevatorDown.Location = new System.Drawing.Point(264, 124);
            this.btnElevatorDown.Name = "btnElevatorDown";
            this.btnElevatorDown.Size = new System.Drawing.Size(27, 23);
            this.btnElevatorDown.TabIndex = 6;
            this.btnElevatorDown.Text = "⇩";
            this.btnElevatorDown.UseVisualStyleBackColor = true;
            this.btnElevatorDown.Click += new System.EventHandler(this.BtnElevatorDown_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "nb personnes";
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(227, 188);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(28, 23);
            this.btnAddPerson.TabIndex = 8;
            this.btnAddPerson.Text = "+";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.BtnAddPerson_Click);
            // 
            // nudPerson
            // 
            this.nudPerson.Location = new System.Drawing.Point(264, 189);
            this.nudPerson.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudPerson.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPerson.Name = "nudPerson";
            this.nudPerson.Size = new System.Drawing.Size(28, 20);
            this.nudPerson.TabIndex = 9;
            this.nudPerson.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnRemovePerson
            // 
            this.btnRemovePerson.Location = new System.Drawing.Point(298, 188);
            this.btnRemovePerson.Name = "btnRemovePerson";
            this.btnRemovePerson.Size = new System.Drawing.Size(28, 23);
            this.btnRemovePerson.TabIndex = 10;
            this.btnRemovePerson.Text = "-";
            this.btnRemovePerson.UseVisualStyleBackColor = true;
            this.btnRemovePerson.Click += new System.EventHandler(this.BtnRemovePerson_Click);
            // 
            // FrmElevator
            // 
            this.AcceptButton = this.btnCreateElevator;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 515);
            this.Controls.Add(this.btnRemovePerson);
            this.Controls.Add(this.nudPerson);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnElevatorDown);
            this.Controls.Add(this.btnElevatorUp);
            this.Controls.Add(this.btnCreateElevator);
            this.Controls.Add(this.tbxMinFloor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxMaxFloor);
            this.Controls.Add(this.label1);
            this.Name = "FrmElevator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elevator";
            this.Load += new System.EventHandler(this.FrmElevator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxMaxFloor;
        private System.Windows.Forms.TextBox tbxMinFloor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreateElevator;
        private System.Windows.Forms.Button btnElevatorUp;
        private System.Windows.Forms.Button btnElevatorDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.NumericUpDown nudPerson;
        private System.Windows.Forms.Button btnRemovePerson;
    }
}

