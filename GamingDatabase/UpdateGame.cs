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
    public partial class UpdateGame : Form
    {
        private SqlConnection connection;
        private string user;
        private string pass;
        public UpdateGame()
        {
            InitializeComponent();
        }

        public UpdateGame(string u, string p)
        {
            InitializeComponent();
            user = u;
            pass = p;
            connection = new SqlConnection("Data Source=mssql.cs.ksu.edu;Initial Catalog = connorg15; User ID = " + user + "; Password=" + pass);
        }

        private void uxUpdateGameButton_Click(object sender, EventArgs e)
        {
            try
            {
                string gameID = uxGameID.Text;
                string companyID = uxCompanyID.Text;
                string name = uxGameName.Text;
                string genre = uxGameGenre.Text;
                string rating = uxGameRating.Text;
                string yearReleased = uxYearReleased.Text;
                string price = uxPrice.Text;
                string reviewScore = uxGameReviewScore.Text;

                if (gameID.Equals(""))
                {
                    MessageBox.Show("Please enter in a GameID");
                    return;
                }
                if (companyID.Equals(""))
                {
                    MessageBox.Show("Please enter in a CompanyID");
                    return;
                }
                if (name.Equals(""))
                {
                    MessageBox.Show("Please enter in a Name");
                    return;
                }
                if (genre.Equals(""))
                {
                    MessageBox.Show("Please enter in a Genre");
                    return;
                }
                if (rating.Equals(""))
                {
                    MessageBox.Show("Please enter in a Rating");
                    return;
                }
                if (yearReleased.Equals(""))
                {
                    MessageBox.Show("Please enter in a Year Released");
                    return;
                }
                if (price.Equals(""))
                {
                    MessageBox.Show("Please enter in a Price");
                    return;
                }
                if (reviewScore.Equals(""))
                {
                    MessageBox.Show("Please enter in a Review Score");
                    return;
                }
                SqlCommand command = new SqlCommand("Update Gaming.Game Set CompanyID= '" + companyID + "', Name= '" + name + "', Genre= '" + genre + "', Rating= '" + rating + "', YearReleased= '" + yearReleased + "', Price = '" + price + "', ReviewScore = '" + reviewScore + "' Where GameID = " + gameID, connection);
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Game Successfully Updated");
                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid information was entered, please try again.");
                uxCompanyID.Clear();
                uxGameID.Clear();
                uxGameName.Clear();
                uxGameReviewScore.Clear();
                uxPrice.Clear();
                uxYearReleased.Clear();
                connection.Close();
            }
            
        }
    }
}
