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
    public partial class DeleteGame : Form
    {
        private SqlConnection connection;
        private string user;
        private string pass;
        public DeleteGame(string u, string p)
        {
            InitializeComponent();
            user = u;
            pass = p;
            connection = new SqlConnection("Data Source=mssql.cs.ksu.edu;Initial Catalog = connorg15; User ID = " + user + "; Password=" + pass);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string gameID = uxGameID.Text;
                connection.Open();
                if (gameID.Equals("")) MessageBox.Show("Please enter in a Game Title");
                SqlCommand cmd = new SqlCommand("DELETE FROM Gaming.Game WHERE Game.GameID = " + gameID, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("GameID " + gameID + " has been deleted.");
                connection.Close();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid information, please try again.");
                connection.Close();
            }
        }
    }
}
