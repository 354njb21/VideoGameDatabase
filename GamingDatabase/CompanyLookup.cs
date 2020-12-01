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
    public partial class CompanyLookup : Form
    {
        // Use your user and pass
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable dt;
        private string user;
        private string pass;

        public CompanyLookup(string u, string p)
        {
            InitializeComponent();
            user = u;
            pass = p;
            connection = new SqlConnection("Data Source=mssql.cs.ksu.edu;Initial Catalog = connorg15; User ID = " + user + "; Password=" + pass);
        }

        private void uxFindCompanyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string name = uxCompanyName.Text;
                connection.Open();
                if (name.Equals(""))
                {
                    MessageBox.Show("Please enter in a Company Name");
                    connection.Close();
                    return;
                }
                connection.Close();
                ShowData(name);
            }
            catch (Exception)
            {
                MessageBox.Show("Error with information, please try again.");
            }
        }

        public void ShowData(string name)
        {
            adapter = new SqlDataAdapter("Select CompanyID, Name From Gaming.Company Where Name like '%" + name + "%'", connection);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView.DataSource = dt;
        }

        private void uxFindAll_Click(object sender, EventArgs e)
        {
            connection.Open();
            adapter = new SqlDataAdapter("Select * From Gaming.Company", connection);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView.DataSource = dt;
            connection.Close();
        }
    }
}
