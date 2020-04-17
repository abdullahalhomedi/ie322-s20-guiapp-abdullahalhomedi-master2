namespace ABDULLAH
{
    partial class frmImage
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
            this.btnImage = new System.Windows.Forms.Button();
            this.pictry = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictry2 = new System.Windows.Forms.PictureBox();
            this.btnImage2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictry)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictry2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(129, 335);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(168, 61);
            this.btnImage.TabIndex = 0;
            this.btnImage.Text = "Image From File";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // pictry
            // 
            this.pictry.Location = new System.Drawing.Point(41, 45);
            this.pictry.Name = "pictry";
            this.pictry.Size = new System.Drawing.Size(250, 197);
            this.pictry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictry.TabIndex = 1;
            this.pictry.TabStop = false;
            this.pictry.Click += new System.EventHandler(this.pictry_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(665, 390);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 35);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictry2);
            this.groupBox1.Controls.Add(this.pictry);
            this.groupBox1.Location = new System.Drawing.Point(58, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 281);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PIC BOX";
            // 
            // pictry2
            // 
            this.pictry2.Location = new System.Drawing.Point(341, 45);
            this.pictry2.Name = "pictry2";
            this.pictry2.Size = new System.Drawing.Size(250, 197);
            this.pictry2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictry2.TabIndex = 2;
            this.pictry2.TabStop = false;
            // 
            // btnImage2
            // 
            this.btnImage2.Location = new System.Drawing.Point(427, 335);
            this.btnImage2.Name = "btnImage2";
            this.btnImage2.Size = new System.Drawing.Size(177, 60);
            this.btnImage2.TabIndex = 4;
            this.btnImage2.Text = "Image From Source";
            this.btnImage2.UseVisualStyleBackColor = true;
            this.btnImage2.Click += new System.EventHandler(this.btnImage2_Click);
            // 
            // frmImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnImage2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnImage);
            this.Name = "frmImage";
            this.Text = "frmImage";
            ((System.ComponentModel.ISupportInitialize)(this.pictry)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictry2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.PictureBox pictry;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictry2;
        private System.Windows.Forms.Button btnImage2;
    }
}