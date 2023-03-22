using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApp2
{
    public partial class Login : Form
    {
        private static readonly SqlConnection Connection = Database.GetConnection();
        
        public Login()
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();
            SqlDataReader reader;
            int r = 0;

            if (rbAdmin.Checked)
            {
                Connection.Open();

                try
                {
                    //Enter Table name where [Table Name]
                    SqlCommand cmd1 = new SqlCommand(String.Format("SELECT * FROM admintable WHERE username={0} and password='{1}'", username, password), Connection);
                    reader = cmd1.ExecuteReader();
                    while (reader.Read())
                    {
                        r++;
                    }
                    if (r > 0)
                    {
                        Connection.Close();

                        new AdminPanel().Show();
                        this.Hide();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Invalid Credentials");
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show("Invalid Inputs\n\n" + er);
                }

                Connection.Close();
            }
            else if (rbPassanger.Checked)
            {
                Connection.Open();

                r = 0;

                try
                {
                    //Enter Table name where [Table Name]
                    SqlCommand cmd2 = new SqlCommand(String.Format("SELECT * FROM usertable WHERE username={0} and password='{1}'", username, password), Connection);
                    reader = cmd2.ExecuteReader();

                    if (r > 0)
                    {
                        Connection.Close();

                        new PriceList().Show();
                        this.Hide();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Invalid Credentials");
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show("Invalid Inputs\n\n" + er);
                }

                Connection.Close();
            }
            else
                MessageBox.Show("Invalid Selection");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
           new Form1().Show();
            this.Hide();
        }
    }
}
