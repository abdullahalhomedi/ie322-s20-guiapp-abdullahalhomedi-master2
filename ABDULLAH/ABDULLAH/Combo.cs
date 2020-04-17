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
    public partial class Combo : Form
    {
        public Combo()
        {
            InitializeComponent();

            CmbDays.Items.Add("Sunday");
            CmbDays.Items.Add("Monday");
            CmbDays.Items.Add("Tuseday");
            CmbDays.Items.Add("Wednsday");
            CmbDays.Items.Add("Thursday");
            CmbDays.Items.Add("Friday");
            CmbDays.Items.Add("Saturday");

        }

        private void btnBack4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void CmbDays_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Combo_Load(object sender, EventArgs e)
        {
        }

        private void btnMethod1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CmbDays.Text);

        }

        private void btnRemove2_Click(object sender, EventArgs e)
        {
            CmbDays.Items.Remove("Friday");
        }

        private void btnRemove1_Click(object sender, EventArgs e)
        {
            CmbDays.Items.RemoveAt(1);
        }

        private void btnRemove3_Click(object sender, EventArgs e)
        {
            if (CmbDays.Items.Count >= 1)
            {
                CmbDays.Items.RemoveAt(CmbDays.Items.Count - 1); 
            }
            else
            {
                MessageBox.Show("Cant remove last item");
            }
        }

        private void btnMethod2_Click(object sender, EventArgs e)
        {
            var item = CmbDays.GetItemText(CmbDays.SelectedItem);
            MessageBox.Show(item);
        }

        private void btnRemove4_Click(object sender, EventArgs e)
        {
            if (CmbDays.Items.Count >= 2)
            {
                CmbDays.Items.RemoveAt(CmbDays.Items.Count - 2);
            }
            else
            {
                MessageBox.Show("Cant remove  second last item");
            }
        }
    }
} 
