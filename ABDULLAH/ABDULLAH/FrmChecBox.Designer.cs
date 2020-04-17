namespace ABDULLAH
{
    partial class FrmChecBox
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
            this.btnShow = new System.Windows.Forms.Button();
            this.ChkCoffee = new System.Windows.Forms.CheckBox();
            this.ChkDonut = new System.Windows.Forms.CheckBox();
            this.ChkBrawnie = new System.Windows.Forms.CheckBox();
            this.BtnBack2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(38, 36);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(116, 41);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // ChkCoffee
            // 
            this.ChkCoffee.AutoSize = true;
            this.ChkCoffee.Location = new System.Drawing.Point(124, 110);
            this.ChkCoffee.Name = "ChkCoffee";
            this.ChkCoffee.Size = new System.Drawing.Size(69, 21);
            this.ChkCoffee.TabIndex = 1;
            this.ChkCoffee.Text = "Coffee";
            this.ChkCoffee.UseVisualStyleBackColor = true;
            // 
            // ChkDonut
            // 
            this.ChkDonut.AutoSize = true;
            this.ChkDonut.Location = new System.Drawing.Point(124, 152);
            this.ChkDonut.Name = "ChkDonut";
            this.ChkDonut.Size = new System.Drawing.Size(69, 21);
            this.ChkDonut.TabIndex = 2;
            this.ChkDonut.Text = "Donut";
            this.ChkDonut.UseVisualStyleBackColor = true;
            // 
            // ChkBrawnie
            // 
            this.ChkBrawnie.AutoSize = true;
            this.ChkBrawnie.Location = new System.Drawing.Point(124, 198);
            this.ChkBrawnie.Name = "ChkBrawnie";
            this.ChkBrawnie.Size = new System.Drawing.Size(77, 21);
            this.ChkBrawnie.TabIndex = 3;
            this.ChkBrawnie.Text = "Brawnie";
            this.ChkBrawnie.UseVisualStyleBackColor = true;
            // 
            // BtnBack2
            // 
            this.BtnBack2.Location = new System.Drawing.Point(606, 364);
            this.BtnBack2.Name = "BtnBack2";
            this.BtnBack2.Size = new System.Drawing.Size(121, 37);
            this.BtnBack2.TabIndex = 4;
            this.BtnBack2.Text = "Back";
            this.BtnBack2.UseVisualStyleBackColor = true;
            this.BtnBack2.Click += new System.EventHandler(this.BtnBack2_Click);
            // 
            // FrmChecBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ABDULLAH.Properties.Resources.CoffeeFinder_ArticleHeader_Desktop_1176x712;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBack2);
            this.Controls.Add(this.ChkBrawnie);
            this.Controls.Add(this.ChkDonut);
            this.Controls.Add(this.ChkCoffee);
            this.Controls.Add(this.btnShow);
            this.Name = "FrmChecBox";
            this.Text = "FrmChecBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.CheckBox ChkCoffee;
        private System.Windows.Forms.CheckBox ChkDonut;
        private System.Windows.Forms.CheckBox ChkBrawnie;
        private System.Windows.Forms.Button BtnBack2;
    }
}