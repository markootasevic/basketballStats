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
            try
            {
                InitializeComponent();
                gc.connectToServer();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
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
            bool success = gc.insertPlayer(cbCountry.SelectedItem as Country, cbTeam.SelectedItem as Team, txtName.Text, txtDate.Text, txtHeight.Text, txtWeight.Text);
            if(success)
            {
                MessageBox.Show("Uspesno ste ubacili igraca");
            } else
            {
                MessageBox.Show("Doslo je do greske");
            }
        }

        private void InsertPlayer_Load(object sender, EventArgs e)
        {
            cbTeam.DataSource = gc.getAllTeams();
            cbCountry.DataSource = gc.getAllCountries();
            this.Show();
        }
    }
}
