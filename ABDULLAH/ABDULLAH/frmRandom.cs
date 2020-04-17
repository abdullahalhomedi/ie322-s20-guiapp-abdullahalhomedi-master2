using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABDULLAH
{
    public partial class frmRandom : Form
    { 
        Random y = new Random();
    public frmRandom()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnRN_Click(object sender, EventArgs e)
        {
            btnRN.Text = Convert.ToString(y.Next(1, 10));
        }

        private void btnGRC_Click(object sender, EventArgs e)
        {
            int r = y.Next(0, 255);
            int g = y.Next(0, 255);
            int b = y.Next(0, 255);

            label1.Text = Convert.ToString(r) + "-" + Convert.ToString(g) + "-" + Convert.ToString(b);
            btnGRC.BackColor = Color.FromArgb(r, g, b);
            this.BackColor = Color.FromArgb(255 - r, 255 - g, 255 - b);


        }
    }
}
