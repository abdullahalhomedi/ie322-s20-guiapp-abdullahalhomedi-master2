namespace ABDULLAH
{
    partial class frmRadio
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
            this.BtnReset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RdRed2 = new System.Windows.Forms.RadioButton();
            this.RdGreen2 = new System.Windows.Forms.RadioButton();
            this.RdBlue2 = new System.Windows.Forms.RadioButton();
            this.RdYellow2 = new System.Windows.Forms.RadioButton();
            this.RdRed1 = new System.Windows.Forms.RadioButton();
            this.RdGreen1 = new System.Windows.Forms.RadioButton();
            this.RdBlue1 = new System.Windows.Forms.RadioButton();
            this.RdYellow1 = new System.Windows.Forms.RadioButton();
            this.Btnback = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(316, 70);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(165, 48);
            this.BtnReset.TabIndex = 0;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdYellow1);
            this.groupBox1.Controls.Add(this.RdBlue1);
            this.groupBox1.Controls.Add(this.RdGreen1);
            this.groupBox1.Controls.Add(this.RdRed1);
            this.groupBox1.Location = new System.Drawing.Point(441, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 232);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grouped radio Buttons";
            // 
            // RdRed2
            // 
            this.RdRed2.AutoSize = true;
            this.RdRed2.Location = new System.Drawing.Point(114, 217);
            this.RdRed2.Name = "RdRed2";
            this.RdRed2.Size = new System.Drawing.Size(53, 21);
            this.RdRed2.TabIndex = 2;
            this.RdRed2.TabStop = true;
            this.RdRed2.Text = "Red";
            this.RdRed2.UseVisualStyleBackColor = true;
            this.RdRed2.CheckedChanged += new System.EventHandler(this.RdRed2_CheckedChanged);
            // 
            // RdGreen2
            // 
            this.RdGreen2.AutoSize = true;
            this.RdGreen2.Location = new System.Drawing.Point(114, 266);
            this.RdGreen2.Name = "RdGreen2";
            this.RdGreen2.Size = new System.Drawing.Size(65, 21);
            this.RdGreen2.TabIndex = 3;
            this.RdGreen2.TabStop = true;
            this.RdGreen2.Text = "Green";
            this.RdGreen2.UseVisualStyleBackColor = true;
            this.RdGreen2.CheckedChanged += new System.EventHandler(this.RdGreen2_CheckedChanged);
            // 
            // RdBlue2
            // 
            this.RdBlue2.AutoSize = true;
            this.RdBlue2.Location = new System.Drawing.Point(114, 314);
            this.RdBlue2.Name = "RdBlue2";
            this.RdBlue2.Size = new System.Drawing.Size(54, 21);
            this.RdBlue2.TabIndex = 4;
            this.RdBlue2.TabStop = true;
            this.RdBlue2.Text = "Blue";
            this.RdBlue2.UseVisualStyleBackColor = true;
            this.RdBlue2.CheckedChanged += new System.EventHandler(this.RdBlue2_CheckedChanged);
            // 
            // RdYellow2
            // 
            this.RdYellow2.AutoSize = true;
            this.RdYellow2.Location = new System.Drawing.Point(114, 354);
            this.RdYellow2.Name = "RdYellow2";
            this.RdYellow2.Size = new System.Drawing.Size(66, 21);
            this.RdYellow2.TabIndex = 5;
            this.RdYellow2.TabStop = true;
            this.RdYellow2.Text = "Yellow";
            this.RdYellow2.UseVisualStyleBackColor = true;
            this.RdYellow2.CheckedChanged += new System.EventHandler(this.RdYellow2_CheckedChanged);
            // 
            // RdRed1
            // 
            this.RdRed1.AutoSize = true;
            this.RdRed1.Location = new System.Drawing.Point(82, 45);
            this.RdRed1.Name = "RdRed1";
            this.RdRed1.Size = new System.Drawing.Size(53, 21);
            this.RdRed1.TabIndex = 0;
            this.RdRed1.TabStop = true;
            this.RdRed1.Text = "Red";
            this.RdRed1.UseVisualStyleBackColor = true;
            // 
            // RdGreen1
            // 
            this.RdGreen1.AutoSize = true;
            this.RdGreen1.Location = new System.Drawing.Point(82, 94);
            this.RdGreen1.Name = "RdGreen1";
            this.RdGreen1.Size = new System.Drawing.Size(65, 21);
            this.RdGreen1.TabIndex = 1;
            this.RdGreen1.TabStop = true;
            this.RdGreen1.Text = "Green";
            this.RdGreen1.UseVisualStyleBackColor = true;
            // 
            // RdBlue1
            // 
            this.RdBlue1.AutoSize = true;
            this.RdBlue1.Location = new System.Drawing.Point(82, 142);
            this.RdBlue1.Name = "RdBlue1";
            this.RdBlue1.Size = new System.Drawing.Size(54, 21);
            this.RdBlue1.TabIndex = 2;
            this.RdBlue1.TabStop = true;
            this.RdBlue1.Text = "Blue";
            this.RdBlue1.UseVisualStyleBackColor = true;
            // 
            // RdYellow1
            // 
            this.RdYellow1.AutoSize = true;
            this.RdYellow1.Location = new System.Drawing.Point(82, 182);
            this.RdYellow1.Name = "RdYellow1";
            this.RdYellow1.Size = new System.Drawing.Size(66, 21);
            this.RdYellow1.TabIndex = 3;
            this.RdYellow1.TabStop = true;
            this.RdYellow1.Text = "Yellow";
            this.RdYellow1.UseVisualStyleBackColor = true;
            // 
            // Btnback
            // 
            this.Btnback.Location = new System.Drawing.Point(672, 420);
            this.Btnback.Name = "Btnback";
            this.Btnback.Size = new System.Drawing.Size(95, 24);
            this.Btnback.TabIndex = 6;
            this.Btnback.Text = "back";
            this.Btnback.UseVisualStyleBackColor = true;
            this.Btnback.Click += new System.EventHandler(this.Btnback_Click);
            // 
            // frmRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btnback);
            this.Controls.Add(this.RdYellow2);
            this.Controls.Add(this.RdBlue2);
            this.Controls.Add(this.RdGreen2);
            this.Controls.Add(this.RdRed2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnReset);
            this.Name = "frmRadio";
            this.Text = "frmRadio";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RdYellow1;
        private System.Windows.Forms.RadioButton RdBlue1;
        private System.Windows.Forms.RadioButton RdGreen1;
        private System.Windows.Forms.RadioButton RdRed1;
        private System.Windows.Forms.RadioButton RdRed2;
        private System.Windows.Forms.RadioButton RdGreen2;
        private System.Windows.Forms.RadioButton RdBlue2;
        private System.Windows.Forms.RadioButton RdYellow2;
        private System.Windows.Forms.Button Btnback;
    }
}