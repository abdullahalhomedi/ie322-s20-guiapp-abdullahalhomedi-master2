namespace ABDULLAH
{
    partial class frmRandomCombo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdogerater = new System.Windows.Forms.RadioButton();
            this.rdoless = new System.Windows.Forms.RadioButton();
            this.cmbRandom = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReset2 = new System.Windows.Forms.Button();
            this.rdogreater2 = new System.Windows.Forms.RadioButton();
            this.rdoless2 = new System.Windows.Forms.RadioButton();
            this.btngenerate2 = new System.Windows.Forms.Button();
            this.cmbRandom2 = new System.Windows.Forms.ComboBox();
            this.btnback = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rdogerater);
            this.groupBox1.Controls.Add(this.rdoless);
            this.groupBox1.Controls.Add(this.cmbRandom);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnGenerate);
            this.groupBox1.Location = new System.Drawing.Point(38, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 303);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quiz3_AMA18";
            // 
            // rdogerater
            // 
            this.rdogerater.AutoSize = true;
            this.rdogerater.Location = new System.Drawing.Point(151, 151);
            this.rdogerater.Name = "rdogerater";
            this.rdogerater.Size = new System.Drawing.Size(134, 21);
            this.rdogerater.TabIndex = 6;
            this.rdogerater.TabStop = true;
            this.rdogerater.Text = "Greater than 500";
            this.rdogerater.UseVisualStyleBackColor = true;
            // 
            // rdoless
            // 
            this.rdoless.AutoSize = true;
            this.rdoless.Location = new System.Drawing.Point(151, 112);
            this.rdoless.Name = "rdoless";
            this.rdoless.Size = new System.Drawing.Size(110, 21);
            this.rdoless.TabIndex = 5;
            this.rdoless.TabStop = true;
            this.rdoless.Text = "less than 500";
            this.rdoless.UseVisualStyleBackColor = true;
            // 
            // cmbRandom
            // 
            this.cmbRandom.FormattingEnabled = true;
            this.cmbRandom.Location = new System.Drawing.Point(23, 46);
            this.cmbRandom.Name = "cmbRandom";
            this.cmbRandom.Size = new System.Drawing.Size(122, 24);
            this.cmbRandom.TabIndex = 4;
            this.cmbRandom.SelectedIndexChanged += new System.EventHandler(this.cmbRandom_SelectedIndexChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(177, 214);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(83, 30);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(177, 39);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(83, 31);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnReset2);
            this.groupBox2.Controls.Add(this.rdogreater2);
            this.groupBox2.Controls.Add(this.rdoless2);
            this.groupBox2.Controls.Add(this.btngenerate2);
            this.groupBox2.Controls.Add(this.cmbRandom2);
            this.groupBox2.Location = new System.Drawing.Point(445, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 303);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quiz3_AMA18";
            // 
            // btnReset2
            // 
            this.btnReset2.Location = new System.Drawing.Point(188, 233);
            this.btnReset2.Name = "btnReset2";
            this.btnReset2.Size = new System.Drawing.Size(83, 30);
            this.btnReset2.TabIndex = 4;
            this.btnReset2.Text = "Reset";
            this.btnReset2.UseVisualStyleBackColor = true;
            this.btnReset2.Click += new System.EventHandler(this.btnReset2_Click);
            // 
            // rdogreater2
            // 
            this.rdogreater2.AutoSize = true;
            this.rdogreater2.Location = new System.Drawing.Point(188, 151);
            this.rdogreater2.Name = "rdogreater2";
            this.rdogreater2.Size = new System.Drawing.Size(119, 21);
            this.rdogreater2.TabIndex = 3;
            this.rdogreater2.TabStop = true;
            this.rdogreater2.Text = "Greter than 50";
            this.rdogreater2.UseVisualStyleBackColor = true;
            // 
            // rdoless2
            // 
            this.rdoless2.AutoSize = true;
            this.rdoless2.Location = new System.Drawing.Point(188, 102);
            this.rdoless2.Name = "rdoless2";
            this.rdoless2.Size = new System.Drawing.Size(102, 21);
            this.rdoless2.TabIndex = 2;
            this.rdoless2.TabStop = true;
            this.rdoless2.Text = "less than 50";
            this.rdoless2.UseVisualStyleBackColor = true;
            // 
            // btngenerate2
            // 
            this.btngenerate2.Location = new System.Drawing.Point(188, 46);
            this.btngenerate2.Name = "btngenerate2";
            this.btngenerate2.Size = new System.Drawing.Size(83, 30);
            this.btngenerate2.TabIndex = 1;
            this.btngenerate2.Text = "Generate";
            this.btngenerate2.UseVisualStyleBackColor = true;
            this.btngenerate2.Click += new System.EventHandler(this.btngenerate2_Click);
            // 
            // cmbRandom2
            // 
            this.cmbRandom2.FormattingEnabled = true;
            this.cmbRandom2.Location = new System.Drawing.Point(28, 51);
            this.cmbRandom2.Name = "cmbRandom2";
            this.cmbRandom2.Size = new System.Drawing.Size(126, 24);
            this.cmbRandom2.TabIndex = 0;
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(647, 373);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(104, 39);
            this.btnback.TabIndex = 2;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // frmRandomCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::ABDULLAH.Properties.Resources.slideshow_Large_numbers_1_1000x700;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRandomCombo";
            this.Text = "frmRandomCombo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.RadioButton rdogerater;
        private System.Windows.Forms.RadioButton rdoless;
        private System.Windows.Forms.ComboBox cmbRandom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnReset2;
        private System.Windows.Forms.RadioButton rdogreater2;
        private System.Windows.Forms.RadioButton rdoless2;
        private System.Windows.Forms.Button btngenerate2;
        private System.Windows.Forms.ComboBox cmbRandom2;
        private System.Windows.Forms.Button btnback;
    }
}