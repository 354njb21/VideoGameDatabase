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
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable dt;
        private string user;
        private string pass;
        public GameSales(string u, string p)
        {
            InitializeComponent();
            user = u;
            pass = p;
            connection = new SqlConnection("Data Source=mssql.cs.ksu.edu;Initial Catalog = connorg15; User ID = " + user + "; Password=" + pass);
        }

        private void uxFilterBtn_Click(object sender, EventArgs e)
        {
            string platform = uxPlatformName.Text;
            if (platform.Equals(""))
            {
                MessageBox.Show("Please enter a valid Platform Name");
                return;
            }
            connection.Open();
            adapter = new SqlDataAdapter("SELECT Game.GameID, Game.[Name], OverallSale AS 'Sales (in Millions)', [Platform].[Name] AS 'Platform Name' FROM Gaming.GameSale INNER JOIN Gaming.Game ON Game.GameID = GameSale.GameID INNER JOIN Gaming.GamePlatform ON GamePlatform.GameID = Game.GameID INNER JOIN Gaming.[Platform] ON[Platform].PlatformID = GamePlatform.PlatformID WHERE[Platform].[Name] = '" + platform + "'", connection);
            dt = new DataTable();
            adapter.Fill(dt);
            uxGameSalesDataGridView.DataSource = dt;
            connection.Close();
        }
    }
}
