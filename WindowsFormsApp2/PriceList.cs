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
    public partial class PriceList : Form
    {
        public PriceList()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.lblDestination.Text = this.cmbDestination.Text;
            this.lblTime.Text = this.cmbTime.Text;
            this.lblTypeandPrice.Text = this.cmbTypeandPrice.Text;
            this.lblDateofOrder.Text = this.dtpDateofOrder.Text;
            this.txtOutputTickets.Text = this.txtTickets.Text;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
