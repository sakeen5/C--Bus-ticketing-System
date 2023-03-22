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
    public partial class Registration : Form
    {
        private static readonly SqlConnection Connection = Database.GetConnection();

        public Registration()
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string phone = txtPhoneNo.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            string query;
            int numberOfRowsAffect = 0;

           
            try
                {
                    Connection.Open();
                    //Enter Table name where [Table Name]
                    query = String.Format("INSERT INTO usertable VALUES('{0}','{1}','{2}','{3}')", username.Trim(), password.Trim(), phone.Trim(), email.Trim());
                    SqlCommand cmd1 = new SqlCommand(query, Connection);
                    numberOfRowsAffect = cmd1.ExecuteNonQuery();

                    if (numberOfRowsAffect > 0)
                    {
                        Connection.Close();
                        MessageBox.Show("Registration Successful");
                        new Form1().Show();
                        this.Hide();
                    }
                    else
                        Connection.Close();
                }
                catch (Exception er)
                {
                    Connection.Close();
                    MessageBox.Show("Invalid Inputs 1\n\n" + er);
                }

                Connection.Close();
        }
    }
}
