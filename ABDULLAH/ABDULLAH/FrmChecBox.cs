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
    public partial class FrmChecBox : Form
    {
        public FrmChecBox()
        {
            InitializeComponent();
        }

        private void BtnBack2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            String msg = "";
            if (ChkCoffee.Checked == true)
            {
                msg = ChkCoffee.Text;
            }
            if (ChkDonut.Checked == true)
            {
                msg = msg + " " + ChkDonut.Text;
            }
            if (ChkBrawnie.Checked == true)
            {
                msg = msg + " " + ChkBrawnie.Text;
            }
            
            if (msg.Length == 0) 
            { msg = "Nothing ordered"; }
            MessageBox.Show( " order " + msg);
        }

    }
}
