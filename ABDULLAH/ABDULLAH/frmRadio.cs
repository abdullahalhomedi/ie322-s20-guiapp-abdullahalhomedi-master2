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
    public partial class frmRadio : Form
    {
        public frmRadio()
        {
            InitializeComponent();
        }

        private void Btnback_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void RdRed2_CheckedChanged(object sender, EventArgs e)
        {
            if (RdRed2.Checked == true)
            
                RdRed2.ForeColor = Color.FromArgb(255, 0, 0); 
            else
                RdRed2.ForeColor = Color.FromArgb(0, 0, 0);

        }

        private void RdGreen2_CheckedChanged(object sender, EventArgs e)
        {
            if (RdGreen2.Checked == true)
            
                RdGreen2.ForeColor = Color.FromArgb(0, 255, 0); 
            else
                RdGreen2.ForeColor = Color.FromArgb(0, 0, 0);

        }

        private void RdBlue2_CheckedChanged(object sender, EventArgs e)
        {
            if (RdBlue2.Checked == true)
            
                RdBlue2.ForeColor = Color.FromArgb(0, 0, 255); 
            else
                RdBlue2.ForeColor = Color.FromArgb(0, 0, 0);


        }

        private void RdYellow2_CheckedChanged(object sender, EventArgs e)
        {
            if (RdYellow2.Checked == true)
            
                RdYellow2.ForeColor = Color.FromArgb(255, 255, 0); 
            else
                RdYellow2.ForeColor = Color.FromArgb(0, 0, 0);


        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            RdRed2.Checked = false;
            RdGreen2.Checked = false;
            RdBlue2.Checked = false;
            RdYellow2.Checked = false;



            RdYellow2.ForeColor = Color.FromArgb(0, 0, 0);
            RdBlue2.ForeColor = Color.FromArgb(0, 0, 0);
            RdGreen2.ForeColor = Color.FromArgb(0, 0, 0);
            RdRed2.ForeColor = Color.FromArgb(0, 0, 0);
        }
    }
}
