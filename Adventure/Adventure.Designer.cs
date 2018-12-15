namespace Adventure
{
    partial class Adventure
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHP = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGold = new System.Windows.Forms.Label();
            this.lblExp = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gold:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "EXP";
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Location = new System.Drawing.Point(110, 19);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(35, 13);
            this.lblHP.TabIndex = 2;
            this.lblHP.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Level";
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.Location = new System.Drawing.Point(110, 45);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(35, 13);
            this.lblGold.TabIndex = 4;
            this.lblGold.Text = "label5";
            // 
            // lblExp
            // 
            this.lblExp.AutoSize = true;
            this.lblExp.Location = new System.Drawing.Point(110, 73);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(35, 13);
            this.lblExp.TabIndex = 5;
            this.lblExp.Text = "label6";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(110, 99);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(35, 13);
            this.lblLevel.TabIndex = 6;
            this.lblLevel.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Hit Points:";
            // 
            // Adventure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 651);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblExp);
            this.Controls.Add(this.lblGold);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblHP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Adventure";
            this.Text = "My Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.Label lblExp;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label label8;
    }
}

