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
    public partial class AddGame : Form
    {
        private SqlConnection connection;
        private string user;
        private string pass;

        public AddGame(string u, string p)
        {
            InitializeComponent();
            user = u;
            pass = p;
            connection = new SqlConnection("Data Source=mssql.cs.ksu.edu;Initial Catalog = connorg15; User ID = " + user + "; Password=" + pass);
        }

        private void uxAddButton_Click(object sender, EventArgs e)
        {
            string companyID = uxCompanyID.Text;
            string name = uxName.Text;
            string genre = uxGenre.Text;
            string rating = uxRating.Text;
            string yearReleased = uxYearReleased.Text;
            string price = uxPrice.Text;
            string reviewScore = uxReviewScore.Text;

            if (companyID.Equals(""))
            {
                MessageBox.Show("Please enter a companyID");
                return;
            }
            if (name.Equals(""))
            {
                MessageBox.Show("Please enter a Name");
                return;
            }
            if (genre.Equals(""))
            {
                MessageBox.Show("Please enter a Genre");
                return;
            }
            if (rating.Equals(""))
            {
                MessageBox.Show("Please enter a Rating");
                return;
            }
            if (yearReleased.Equals(""))
            {
                MessageBox.Show("Please enter a Release Years");
                return;
            }
            if (price.Equals(""))
            {
                MessageBox.Show("Please enter a Price");
                return;
            }
            if (reviewScore.Equals(""))
            {
                MessageBox.Show("Please enter a Review Score");
                return;
            }
            SqlCommand com = new SqlCommand("Insert into Gaming.Game (CompanyID, Name, Genre, Rating, YearReleased, Price, ReviewScore) Values('" + companyID + "','" + name + "','" + genre + "','" + rating + "','" + yearReleased + "', '" + price + "', '" + reviewScore + "')", connection);
            connection.Open();
            com.ExecuteNonQuery();
            MessageBox.Show("Added Successfully");
            connection.Close();
        }
    }
}
