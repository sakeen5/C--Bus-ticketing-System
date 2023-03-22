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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        override protected void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
            {
                Application.Exit();
            }
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            new Registration().Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();

        }

        private void btnPriceList_Click(object sender, EventArgs e)
        {
            new PriceList().Show();
            this.Hide();
        }

        private void btnPriceList_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPriceList_Click_2(object sender, EventArgs e)
        {

            new PriceList().Show();
            this.Hide();
        }
    }
}
