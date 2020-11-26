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
using System.Windows.Navigation;
using Players;
namespace GamingDatabase
{
    public partial class GamingDatabase : Form
    {
        //Access to SQL
        public GamingDatabase()
        {
            InitializeComponent();
        }

        private void uxCompanyLookupButton_Click(object sender, EventArgs e)
        {
            CompanyLookup companyLookup = new CompanyLookup();
            companyLookup.Show();
        }

        private void uxAddGameButton_Click(object sender, EventArgs e)
        {
            AddGame addGame = new AddGame();
            addGame.Show();
        }

        private void uxUpdateGameButton_Click(object sender, EventArgs e)
        {
            UpdateGamePopUp gamePopUp = new UpdateGamePopUp();
            gamePopUp.Show();
        }

        private void uxLookupGameButton_Click(object sender, EventArgs e)
        {
            GameLookup gameLookup = new GameLookup();
            gameLookup.Show();
        }

        private void uxGameSalesButton_Click(object sender, EventArgs e)
        {
            GameSales gameSales = new GameSales();
            gameSales.Show();
        }

        private void uxPlatformSalesButton_Click(object sender, EventArgs e)
        {
            PlatformSales platformSales = new PlatformSales();
            platformSales.Show();

            
        }

        private void uxStreamersButton_Click(object sender, EventArgs e)
        {
            Streamers streamers = new Streamers();
            streamers.Show();
        }

        private void uxRetailSalesButton_Click(object sender, EventArgs e)
        {
            RetailSales retailSales = new RetailSales();
            retailSales.Show();
        }

        private void uxReportQueriesButton_Click(object sender, EventArgs e)
        {
            ReportQueries reportQueries = new ReportQueries();
            reportQueries.Show();
        }
    }
}
