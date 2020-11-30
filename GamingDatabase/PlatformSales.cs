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
    public partial class PlatformSales : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable dt;
        private string user;
        private string pass;

        public PlatformSales(string u, string p)
        {
            InitializeComponent();
            user = u;
            pass = p;
            connection = new SqlConnection("Data Source=mssql.cs.ksu.edu;Initial Catalog = connorg15; User ID = " + user + "; Password=" + pass);
        }

        private void uxFilterPlatformSales_Click(object sender, EventArgs e)
        {
            string minYear = uxStartYear.Text;
            string maxYear = uxEndYear.Text;
            string platform = uxPlatform.Text;

            if (minYear.Equals(""))
            {
                MessageBox.Show("Enter a valid Start Year");
                return;
            }
            if (maxYear.Equals(""))
            {
                MessageBox.Show("Enter a valid End Year");
                return;
            }
            if (platform.Equals(""))
            {
                MessageBox.Show("Enter a valid Platform");
                return;
            }
            connection.Open();
            adapter = new SqlDataAdapter("SELECT P.PlatformID, P.[Name], S.[Year], S.Sales AS 'Sales in Millions' FROM Gaming.[Platform] P INNER JOIN[Platform].Sales S ON S.PlatformID = P.PlatformID WHERE S.[Year] BETWEEN " + minYear + "and " + maxYear + "and S.PlatformID= " + platform, connection);
            dt = new DataTable();
            adapter.Fill(dt);
            uxDataGridView.DataSource = dt;
            connection.Close();
        }
    }
}
