using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimeraApp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

        }

        private void btnSaved_Click(object sender, EventArgs e)
        {
            Home2 f = new Home2();
            f.lbldatos.Text = rtxtResults.Text;
            this.Hide();
            f.ShowDialog();
        }
    }
}
