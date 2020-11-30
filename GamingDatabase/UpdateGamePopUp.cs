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
    public partial class UpdateGamePopUp : Form
    {
        public UpdateGamePopUp()
        {
            InitializeComponent();
        }

        private void uxSubmitButton_Click(object sender, EventArgs e)
        {
            string title = uxGameToUpdate.Text;
            
            UpdateGamePopUp gamePopUp = new UpdateGamePopUp();
            gamePopUp.Close();
        }

    }
}
