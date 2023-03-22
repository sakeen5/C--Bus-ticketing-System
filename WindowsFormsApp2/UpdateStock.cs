using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class UpdateStock : Form
    {
        public UpdateStock()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.txtOutputTotalAc.Text = this.txtTotalAc.Text;
            this.txtOutputTotalnonAc.Text = this.txtTotalnonAc.Text;
            this.txtOutputTotalPremium.Text = this.txtTotalPremium.Text;
            this.txtOutputReserved.Text = this.txtTotalReserved.Text;

        }

        private void btnUpdated_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
