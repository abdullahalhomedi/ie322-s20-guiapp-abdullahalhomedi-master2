namespace ABDULLAH
{
    partial class frmRandom
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
            this.btnGRC = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnRN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGRC
            // 
            this.btnGRC.Location = new System.Drawing.Point(46, 33);
            this.btnGRC.Name = "btnGRC";
            this.btnGRC.Size = new System.Drawing.Size(383, 100);
            this.btnGRC.TabIndex = 0;
            this.btnGRC.Text = "Generate Random Color";
            this.btnGRC.UseVisualStyleBackColor = true;
            this.btnGRC.Click += new System.EventHandler(this.btnGRC_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(623, 388);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(124, 33);
            this.btnback.TabIndex = 1;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnRN
            // 
            this.btnRN.Location = new System.Drawing.Point(88, 290);
            this.btnRN.Name = "btnRN";
            this.btnRN.Size = new System.Drawing.Size(140, 38);
            this.btnRN.TabIndex = 2;
            this.btnRN.Text = "Random Number";
            this.btnRN.UseVisualStyleBackColor = true;
            this.btnRN.Click += new System.EventHandler(this.btnRN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "r-g-b";
            // 
            // frmRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRN);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnGRC);
            this.Name = "frmRandom";
            this.Text = "frmRandom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGRC;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnRN;
        private System.Windows.Forms.Label label1;
    }
}