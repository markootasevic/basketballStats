using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace Forme
{
    public partial class InsertPlayer : Form
    {
        GUIController gc = new GUIController();
        public InsertPlayer()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ///TOOD: skloni ove test podatke posle u ubaci lepo sve
            List<Team> teamList = new List<Team>();

            Team team1 = new Team
            {
                Arena = "arena1",
                Name = "GSW",
                TeamID = 1
            };
            cbTeam.DataSource = teamList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gc.insertPlayer(txtCountry.Text, cbTeam.SelectedItem as Team, txtName.Text, txtDate.Text, txtHeight.Text, txtWeight.Text);
        }
    }
}
