﻿using System;
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
    }
}
