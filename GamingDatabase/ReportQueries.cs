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
    public partial class ReportQueries : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable dt;
        private string user;
        private string pass;
        public ReportQueries(string u, string p)
        {
            InitializeComponent();
            user = u;
            pass = p;
            connection = new SqlConnection("Data Source=mssql.cs.ksu.edu;Initial Catalog = connorg15; User ID = " + user + "; Password=" + pass);
        }

        private void uxReportQuery1Button_Click(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("SELECT C.CompanyID, C.[Name], COUNT(*) AS GameCount, FORMAT(SUM(GS.OverallSale) * 1000000, 'C') AS TotalGameSales, FORMAT(SUM(GS.OverallSale) / COUNT(*) * 1000000, 'C') AS AverageGameSale FROM Gaming.Company C INNER JOIN Gaming.Game G ON G.CompanyID = C.CompanyID  INNER JOIN Gaming.GameSale GS ON GS.GameID = G.GameID WHERE C.CompanyID =" + uxCompanyID.Text + " GROUP BY C.CompanyID, C.[Name]", connection);
            connection.Open();
            dt = new DataTable();
            adapter.Fill(dt);
            uxDataGridView.DataSource = dt;
            connection.Close();

            
        }

        private void uxReportQuery2Button_Click(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("SELECT TOP 50 G.[Name], G.YearReleased, P.[Name] AS 'Platform Name', FORMAT(SUM(GS.OverallSale * 1000000), 'C') AS TotalSales FROM Gaming.Game G INNER JOIN Gaming.GamePlatform GP ON G.GameID = GP.GameID INNER JOIN Gaming.[Platform] P ON P.PlatformID = GP.PlatformID INNER JOIN Gaming.GameSale GS ON G.GameID = GS.GameID WHERE P.[Name] = '" + uxPlatformName.Text + "' AND G.YearReleased BETWEEN " + uxStart.Text + "AND " + uxEnd.Text + "GROUP BY P.PlatformID, P.[Name], G.[Name], GS.OverallSale, G.YearReleased ORDER BY GS.OverallSale DESC", connection);
                
            connection.Open();
            dt = new DataTable();
            adapter.Fill(dt);
            uxDataGridView.DataSource = dt;
            connection.Close();
        }

        private void uxReportQuery3Button_Click(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("SELECT TOP 10 G.[Name], G.ReviewScore, G.Price, P.[Name] AS 'Platform Name' FROM Gaming.Game G INNER JOIN Gaming.GamePlatform GP ON GP.GameID = G.GameID INNER JOIN Gaming.[Platform] P ON P.PlatformID = GP.PlatformID WHERE G.ReviewScore BETWEEN " + uxMinRating.Text + " AND " + uxMaxRating.Text, connection);
            connection.Open();
            dt = new DataTable();
            adapter.Fill(dt);
            uxDataGridView.DataSource = dt;
            connection.Close();
        }
    }
}
