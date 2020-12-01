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

namespace GamingDatabase
{
    public partial class LoginForm : Form
    {
        string user;
        string pass;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void uxLoginButton_Click(object sender, EventArgs e)
        {
            if (GetConnection())
            {
                MessageBox.Show("Successful Login");
                Close();
            }
            else
            {
                MessageBox.Show("Invalid User And/Or Password, please try again");
                uxUsername.Text = "";
                uxPassword.Text = "";
            }
        }

        public bool GetConnection()
        {
            try
            {
                if (uxUsername.Text != "" && uxPassword.Text != "")
                {
                    user = uxUsername.Text;
                    pass = uxPassword.Text;
                    SqlConnection con = new SqlConnection("Data Source=mssql.cs.ksu.edu;Initial Catalog = connorg15; User ID = " + uxUsername.Text + "; Password=" + uxPassword.Text);
                    con.Open();
                    con.Close();
                    return true;
                }
            } catch(Exception)
            {
                return false;
            }
            return false;
        }

        public string GetUser() { return user; }
        public string GetPassword() { return pass; }
    }
}
