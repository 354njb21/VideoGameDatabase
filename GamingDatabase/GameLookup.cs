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
    public partial class GameLookup : Form
    {
        private SqlConnection connection = new SqlConnection("Data Source=mssql.cs.ksu.edu;Initial Catalog = connorg15; User ID = username; Password=Password");
        private SqlDataAdapter adapter;
        private DataTable dt;

        public GameLookup()
        {
            InitializeComponent();
        }

        private void uxFindGame_Click(object sender, EventArgs e)
        {
            string game = uxGameTitle.Text;
            connection.Open();
            if (game.Equals("")) MessageBox.Show("Please enter in a Game Title");
            connection.Close();
            ShowData(game);
        }

        public void ShowData(string game)
        {
            adapter = new SqlDataAdapter("Select GameID, Name From Gaming.Game Where Name = '" + game + "'", connection);
            dt = new DataTable();
            adapter.Fill(dt);
            uxGameDataGridView.DataSource = dt;
        }
    }
}
