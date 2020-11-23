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
    public partial class GameSales : Form
    {
        private SqlConnection connection = new SqlConnection("Data Source=mssql.cs.ksu.edu;Initial Catalog = connorg15; User ID = username; Password=Password");
        private SqlDataAdapter adapter;
        private DataTable dt;

        public GameSales()
        {
            InitializeComponent();
        }

        private void uxFilterBtn_Click(object sender, EventArgs e)
        {
            string start = uxStartYear.Text;
            string end = uxEndYear.Text;
        }
    }
}
