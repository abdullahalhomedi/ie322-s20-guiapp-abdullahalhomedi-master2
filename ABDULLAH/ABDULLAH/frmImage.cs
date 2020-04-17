using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABDULLAH
{
    public partial class frmImage : Form
    {  
        public frmImage()
        {
           
            InitializeComponent();
           
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            pictry.Image = Image.FromFile("C:\\Users\\abdul\\Pictures\\power rengers\\imagesUKZSF90O.jpg");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }

        private void pictry_Click(object sender, EventArgs e)
        {

        }

        private void btnImage2_Click(object sender, EventArgs e)
        {
            try 
            {
                pictry2.Image = ABDULLAH.Properties.Resources.batman;
            }
            catch(Exception)
            {
                MessageBox.Show("error craeting image from resource!");
            }
        }

       
    }
}
