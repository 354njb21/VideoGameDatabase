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
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable dt;
        private string user;
        private string pass;

        public GameLookup(string u, string p)
        {
            InitializeComponent();
            user = u;
            pass = p;
            connection = new SqlConnection("Data Source=mssql.cs.ksu.edu;Initial Catalog = connorg15; User ID = " + user + "; Password=" + pass);
        }

        private void uxFindGame_Click(object sender, EventArgs e)
        {
            string game = uxGameTitle.Text;
            connection.Open();
            if (game.Equals("")) MessageBox.Show("Please enter in a Game Title");
            adapter = new SqlDataAdapter("Select * From Gaming.Game Where Name = '" + game + "'", connection);
            dt = new DataTable();
            adapter.Fill(dt);
            uxGameDataGridView.DataSource = dt;
            connection.Close();
        }

        private void FindAllGameButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            adapter = new SqlDataAdapter("Select * From Gaming.Game", connection);
            dt = new DataTable();
            adapter.Fill(dt);
            uxGameDataGridView.DataSource = dt;
            connection.Close();
        }

        private void uxFindGameReleaseYear_Click(object sender, EventArgs e)
        {
            string year = uxYearReleased.Text;
            connection.Open();
            if (year.Equals("")) MessageBox.Show("Please enter a valid year.");
            adapter = new SqlDataAdapter("Select * From Gaming.Game Where YearReleased='" + year + "'", connection);
            dt = new DataTable();
            adapter.Fill(dt);
            uxGameDataGridView.DataSource = dt;
            connection.Close();
        }

        private void uxFindGameByGenreButton_Click(object sender, EventArgs e)
        {
            string genre = uxGenre.Text;
            connection.Open();
            if (genre.Equals("")) MessageBox.Show("Please enter a valid genre");
            adapter = new SqlDataAdapter("Select * From Gaming.Game Where Genre='" + genre + "'", connection);
            dt = new DataTable();
            adapter.Fill(dt);
            uxGameDataGridView.DataSource = dt;
            connection.Close();
        }

        private void uxFindGameByRatingButton_Click(object sender, EventArgs e)
        {
            string rating = uxRating.Text;
            connection.Open();
            if (rating.Equals("")) MessageBox.Show("Please enter a valid genre");
            adapter = new SqlDataAdapter("Select * From Gaming.Game Where Rating='" + rating + "'", connection);
            dt = new DataTable();
            adapter.Fill(dt);
            uxGameDataGridView.DataSource = dt;
            connection.Close();
        }
    }
}
