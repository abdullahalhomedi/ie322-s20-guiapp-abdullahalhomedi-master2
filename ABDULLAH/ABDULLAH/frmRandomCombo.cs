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
    public partial class frmRandomCombo : Form
    {
        Random x = new Random();
        public frmRandomCombo()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random x = new Random();
            cmbRandom.ResetText();
            cmbRandom.Items.Clear();

          
            for(int i=0 ; i < x.Next(1,50)-1 ; i++)
            { 
                cmbRandom.Items.Add(x.Next(100, 999)); 
            }
            
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void cmbRandom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbRandom.ResetText();
            cmbRandom.Items.Clear();
            rdoless.Checked = false;
            rdogerater.Checked = false;


        }

        private void btngenerate2_Click(object sender, EventArgs e)
        {
            cmbRandom2.ResetText();
            cmbRandom2.Items.Clear();

            Random x = new Random();
            for (int i = 0; i < x.Next(2, 9) -1; i++)
            {
                cmbRandom2.Items.Add(x.Next(10, 99));
            }
        }

        private void btnReset2_Click(object sender, EventArgs e)
        {
            cmbRandom2.ResetText();
            cmbRandom2.Items.Clear();
            rdoless2.Checked = false;
            rdogreater2.Checked = false;

        }
    }
}
