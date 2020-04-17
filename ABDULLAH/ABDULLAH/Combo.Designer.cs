namespace ABDULLAH
{
    partial class Combo
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
            this.btnMethod1 = new System.Windows.Forms.Button();
            this.btnMethod2 = new System.Windows.Forms.Button();
            this.CmbDays = new System.Windows.Forms.ComboBox();
            this.btnRemove1 = new System.Windows.Forms.Button();
            this.btnRemove2 = new System.Windows.Forms.Button();
            this.btnRemove3 = new System.Windows.Forms.Button();
            this.btnRemove4 = new System.Windows.Forms.Button();
            this.btnBack4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMethod1
            // 
            this.btnMethod1.Location = new System.Drawing.Point(40, 42);
            this.btnMethod1.Name = "btnMethod1";
            this.btnMethod1.Size = new System.Drawing.Size(132, 62);
            this.btnMethod1.TabIndex = 0;
            this.btnMethod1.Text = "Show Selected Method1";
            this.btnMethod1.UseVisualStyleBackColor = true;
            this.btnMethod1.Click += new System.EventHandler(this.btnMethod1_Click);
            // 
            // btnMethod2
            // 
            this.btnMethod2.Location = new System.Drawing.Point(169, 42);
            this.btnMethod2.Name = "btnMethod2";
            this.btnMethod2.Size = new System.Drawing.Size(132, 62);
            this.btnMethod2.TabIndex = 1;
            this.btnMethod2.Text = "Show Selected Method2";
            this.btnMethod2.UseVisualStyleBackColor = true;
            this.btnMethod2.Click += new System.EventHandler(this.btnMethod2_Click);
            // 
            // CmbDays
            // 
            this.CmbDays.BackColor = System.Drawing.SystemColors.MenuBar;
            this.CmbDays.FormattingEnabled = true;
            this.CmbDays.Location = new System.Drawing.Point(95, 133);
            this.CmbDays.Name = "CmbDays";
            this.CmbDays.Size = new System.Drawing.Size(206, 24);
            this.CmbDays.TabIndex = 2;
            this.CmbDays.SelectedIndexChanged += new System.EventHandler(this.CmbDays_SelectedIndexChanged);
            // 
            // btnRemove1
            // 
            this.btnRemove1.Location = new System.Drawing.Point(69, 302);
            this.btnRemove1.Name = "btnRemove1";
            this.btnRemove1.Size = new System.Drawing.Size(144, 69);
            this.btnRemove1.TabIndex = 3;
            this.btnRemove1.Text = "Remove by Index";
            this.btnRemove1.UseVisualStyleBackColor = true;
            this.btnRemove1.Click += new System.EventHandler(this.btnRemove1_Click);
            // 
            // btnRemove2
            // 
            this.btnRemove2.Location = new System.Drawing.Point(237, 302);
            this.btnRemove2.Name = "btnRemove2";
            this.btnRemove2.Size = new System.Drawing.Size(144, 69);
            this.btnRemove2.TabIndex = 4;
            this.btnRemove2.Text = "Remove by Name";
            this.btnRemove2.UseVisualStyleBackColor = true;
            this.btnRemove2.Click += new System.EventHandler(this.btnRemove2_Click);
            // 
            // btnRemove3
            // 
            this.btnRemove3.Location = new System.Drawing.Point(619, 33);
            this.btnRemove3.Name = "btnRemove3";
            this.btnRemove3.Size = new System.Drawing.Size(138, 90);
            this.btnRemove3.TabIndex = 5;
            this.btnRemove3.Text = "Remove last item";
            this.btnRemove3.UseVisualStyleBackColor = true;
            this.btnRemove3.Click += new System.EventHandler(this.btnRemove3_Click);
            // 
            // btnRemove4
            // 
            this.btnRemove4.Location = new System.Drawing.Point(619, 157);
            this.btnRemove4.Name = "btnRemove4";
            this.btnRemove4.Size = new System.Drawing.Size(137, 98);
            this.btnRemove4.TabIndex = 6;
            this.btnRemove4.Text = "Remove 2nd last item";
            this.btnRemove4.UseVisualStyleBackColor = true;
            this.btnRemove4.Click += new System.EventHandler(this.btnRemove4_Click);
            // 
            // btnBack4
            // 
            this.btnBack4.Location = new System.Drawing.Point(629, 393);
            this.btnBack4.Name = "btnBack4";
            this.btnBack4.Size = new System.Drawing.Size(127, 34);
            this.btnBack4.TabIndex = 7;
            this.btnBack4.Text = "Back";
            this.btnBack4.UseVisualStyleBackColor = true;
            this.btnBack4.Click += new System.EventHandler(this.btnBack4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(37, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Days";
            // 
            // Combo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack4);
            this.Controls.Add(this.btnRemove4);
            this.Controls.Add(this.btnRemove3);
            this.Controls.Add(this.btnRemove2);
            this.Controls.Add(this.btnRemove1);
            this.Controls.Add(this.CmbDays);
            this.Controls.Add(this.btnMethod2);
            this.Controls.Add(this.btnMethod1);
            this.Name = "Combo";
            this.Text = "Combo";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Combo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMethod1;
        private System.Windows.Forms.Button btnMethod2;
        private System.Windows.Forms.ComboBox CmbDays;
        private System.Windows.Forms.Button btnRemove1;
        private System.Windows.Forms.Button btnRemove2;
        private System.Windows.Forms.Button btnRemove3;
        private System.Windows.Forms.Button btnRemove4;
        private System.Windows.Forms.Button btnBack4;
        private System.Windows.Forms.Label label1;
    }
}