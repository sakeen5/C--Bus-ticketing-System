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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
            
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

        private void btnStockTicket_Click(object sender, EventArgs e)
        {
            new StockTicket().Show();
            this.Hide();
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            new UpdateStock().Show();
            this.Hide();
        }

        private void btnSellingHistory_Click(object sender, EventArgs e)
        {
            new SellHistory().Show();
            this.Hide();
        }

        private void btnBusSchedule_Click(object sender, EventArgs e)
        {
            new BusSchedule().Show();
            this.Hide();
        }
    }
}
