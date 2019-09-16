/*
 * Created by: Sasha Malko
 * Created on: 13-Sep-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #8 - Basketball Teams
 * This program changes the text in the labels depending on which menu item is clicked. 
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasketballTeamsSashaM
{
    public partial class frmBasketballTeams : Form
    {
        public frmBasketballTeams()
        {
            InitializeComponent();
        }

        // this will change the window to have a Toronto Raptors theme
        private void MniToronto_Click(object sender, EventArgs e)
        {
            lblCities.Text = "Toronto";
            lblCities.Font = new Font("Impact", 40F);
            lblCities.Location = new Point(45, 62);
            lblTeam.Text = "Raptors";
            lblTeam.Font = new Font("Segoe Print", 20F);
            lblTeam.Location = new Point(165, 150);
            picTeam.Image = Properties.Resources.Raptors;
        }

        // this will change the window to have a Cleveland Cavaliers theme
        private void MniCleveland_Click(object sender, EventArgs e)
        {
            lblCities.Text = "Cleveland";
            lblCities.Font = new Font("Comic Sans MS", 40F);
            lblCities.Location = new Point(55, 60);
            lblTeam.Text = "Cavaliers";
            lblTeam.Font = new Font("Gabriola", 30F);
            lblTeam.Location = new Point(110, 150);
            picTeam.Image = Properties.Resources.Cavaliers;
        }

        // this will change the window to have a Miami Heat theme
        private void MniMiami_Click(object sender, EventArgs e)
        {
            lblCities.Text = "Miami";
            lblCities.Font = new Font("MV Boli", 40F);
            lblCities.Location = new Point(150, 60);
            lblTeam.Text = "Heat";
            lblTeam.Font = new Font("MS Gothic", 30F);
            lblTeam.Location = new Point(40, 150);
            picTeam.Image = Properties.Resources.Heat;
        }

        // this will change the window to have a Boston Celtics theme
        private void MniBoston_Click(object sender, EventArgs e)
        {
            lblCities.Text = "Boston";
            lblCities.Font = new Font("Ink Free", 40F);
            lblCities.Location = new Point(70, 60);
            lblTeam.Text = "Celtics";
            lblTeam.Font = new Font("Sylfaen", 30F);
            lblTeam.Location = new Point(140, 120);
            picTeam.Image = Properties.Resources.Celtics;
        }
    }
}
