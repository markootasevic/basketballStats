using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme
{
    public partial class SearchStatsStep1 : Form
    { 
        GUIController gc;
        public SearchStatsStep1(GUIController g)
        {
            gc = g;
            InitializeComponent();
        }

        private void SearchStatsStep1_Load(object sender, EventArgs e)
        {
            List<Team> teamList = gc.getAllTeams();
            cbTeam.DataSource = teamList;
            if (teamList.Count != 0)
            {
                Team t = cbTeam.SelectedItem as Team;
                cbPlayer.DataSource = gc.getPlayerListForTeam(t.TeamID);
            }

        }

        private void cbTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            Team t = cbTeam.SelectedItem as Team;
            cbPlayer.DataSource = gc.getPlayerListForTeam(t.TeamID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Player p = cbPlayer.SelectedItem as Player;
            dgvStats.DataSource = gc.searchStats(p);
            dgvStats.Columns[0].Visible = false;
            dgvStats.Columns[1].Visible = false;
            dgvStats.Columns[2].Visible = false;
            dgvStats.Columns[3].Visible = true;
            dgvStats.Columns[3].HeaderText = "Utakmica";
            dgvStats.Columns[4].Visible = true;
            dgvStats.Columns[4].HeaderText = "Igrac";
            dgvStats.Columns[5].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Stat s = dgvStats.SelectedRows[0].DataBoundItem as Stat;
                new SearchStatsStep2(s).Show();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
