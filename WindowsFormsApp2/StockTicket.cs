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
    public partial class StockTicket : Form
    {
        public StockTicket()
        {
            InitializeComponent();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            this.txtOutputDhakatoChittagongAc.Text = this.txtDhakatoChittagongAc.Text;
            this.txtOutputDhakatoChittagongnonAc.Text = this.txtDhakatoChittagongnonAc.Text;
            this.txtOutputDhakatoChittagongPremium.Text = this.txtDhakatoChittagongPremium.Text;
            this.txtOutputChittagongtoDhakaAc.Text = this.txtChittagongtoDhakaAc.Text;
            this.txtOutputChittagongtoDhakanonAc.Text = this.txtChittagongtoDhakanonAc.Text;
            this.txtOutputChittagongtoDhakaPremium.Text = this.txtChittagongtoDhakaPremium.Text;
            this.txtOutputFenitoDhakaAc.Text = this.txtFenitoDhakaAc.Text;
            this.txtOutputFenitoDhakanonAc.Text = this.txtFenitoDhakanonAc.Text;
            this.txtOutputFenitoDhakaPremium.Text = this.txtFenitoDhakaPremium.Text;
        }

        private void btnStocked_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
