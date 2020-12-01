using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Players
{
    public partial class Streamers : Form
    {
        private SqlConnection connection = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDb;Initial Catalog=VideoGames;Integrated Security=True");
        private SqlDataAdapter adapter;
        private DataTable dt;

        public Streamers()
        {
            InitializeComponent();

            connection.Open();
            adapter = new SqlDataAdapter("Select * From Players.Streamers", connection);
            dt = new DataTable();
            adapter.Fill(dt);
            uxStreamerDataView.DataSource = dt;
            connection.Close();
        }

        private void uxSubscriberFilterButton_Click(object sender, EventArgs e)
        {
            string max = uxMaxSubscribers.Text;
            string min = uxMinSubscribers.Text;

            connection.Open();
            if (max.Equals("") && min.Equals("")) MessageBox.Show("Enter a min and or max value");

            else if (max.Equals("") && min.Length > 0)
            {
                adapter = new SqlDataAdapter("Select * From Players.Streamers Where Subscribers>'" + min + "'", connection);
                dt = new DataTable();
                adapter.Fill(dt);
                uxStreamerDataView.DataSource = dt;
                connection.Close();
            }

            else if (min.Equals("") && max.Length > 0)
            {
                adapter = new SqlDataAdapter("Select * From Players.Streamers Where Subscribers<'" + max + "'", connection);
                dt = new DataTable();
                adapter.Fill(dt);
                uxStreamerDataView.DataSource = dt;
                connection.Close();
            }

            else
            {
                adapter = new SqlDataAdapter("Select * From Players.Streamers Where Subscribers<'" + max + "'" + "and Subscribers>'" + min + "'", connection);
                dt = new DataTable();
                adapter.Fill(dt);
                uxStreamerDataView.DataSource = dt;
                connection.Close();
            }
        }

        private void uxFilterByViewsButton_Click(object sender, EventArgs e)
        {
            string max = uxMaxViews.Text;
            string min = uxMinViews.Text;

            connection.Open();
            if (max.Equals("") && min.Equals("")) MessageBox.Show("Enter a min and or max value");

            else if (max.Equals("") && min.Length > 0)
            {
                adapter = new SqlDataAdapter("Select * From Players.Streamers Where Viewers>'" + min + "'", connection);
                dt = new DataTable();
                adapter.Fill(dt);
                uxStreamerDataView.DataSource = dt;
                connection.Close();
            }

            else if (min.Equals("") && max.Length > 0)
            {
                adapter = new SqlDataAdapter("Select * From Players.Streamers Where Viewers<'" + max + "'", connection);
                dt = new DataTable();
                adapter.Fill(dt);
                uxStreamerDataView.DataSource = dt;
                connection.Close();
            }

            else
            {
                adapter = new SqlDataAdapter("Select * From Players.Streamers Where Viewers<'" + max + "'" + "and Viewers>'" + min + "'", connection);
                dt = new DataTable();
                adapter.Fill(dt);
                uxStreamerDataView.DataSource = dt;
                connection.Close();
            }
        }
    }
}
