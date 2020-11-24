using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamingDatabase
{
    public partial class UpdateGame : Form
    {
        private string gameTitle;

        public UpdateGame()
        {
            InitializeComponent();
        }

        public UpdateGame(string gameTitle)
        {
            InitializeComponent();
            this.gameTitle = gameTitle;

            uxGameName.Text = gameTitle;
        }

        private void uxUpdateGameButton_Click(object sender, EventArgs e)
        {
            UpdateGame updateGame = new UpdateGame();
            updateGame.Close();
        }
    }
}
