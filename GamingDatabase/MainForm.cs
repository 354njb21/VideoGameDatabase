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
        private string username;
        private string password;
        public GamingDatabase()
        {
            InitializeComponent();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            username = loginForm.GetUser();
            password = loginForm.GetPassword();
        }

        private void uxCompanyLookupButton_Click(object sender, EventArgs e)
        {
            CompanyLookup companyLookup = new CompanyLookup(username, password);
            companyLookup.Show();
        }

        private void uxAddGameButton_Click(object sender, EventArgs e)
        {
            AddGame addGame = new AddGame(username, password);
            addGame.Show();
        }

        private void uxUpdateGameButton_Click(object sender, EventArgs e)
        {
            UpdateGame gamePopUp = new UpdateGame(username, password);
            gamePopUp.Show();
        }

        private void uxLookupGameButton_Click(object sender, EventArgs e)
        {
            GameLookup gameLookup = new GameLookup(username, password);
            gameLookup.Show();
        }

        private void uxGameSalesButton_Click(object sender, EventArgs e)
        {
            GameSales gameSales = new GameSales(username, password);
            gameSales.Show();
        }

        private void uxPlatformSalesButton_Click(object sender, EventArgs e)
        {
            PlatformSales platformSales = new PlatformSales(username, password);
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
            //ReportQueries reportQueries = new ReportQueries(username, password);
            //reportQueries.Show();
        }
    }
}
