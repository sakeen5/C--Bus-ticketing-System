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
    public partial class BusSchedule : Form
    {
        AdminPanel al = new AdminPanel();
        public BusSchedule()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            al.Show();
        }

        private void cmbChittagong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
