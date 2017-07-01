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
    
    public partial class SearchGames : Form
    {
        GUIController gc;
        List<Team> teamListHome;
        List<Team> teamListAway;
        List<Team> teamListAll;
        public SearchGames(GUIController gui)
        {
            gc = gui;
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SearchGames_Load(object sender, EventArgs e)
        {
            teamListAll = gc.getAllTeams();
            teamListAway = new List<Team>(teamListAll);
            teamListHome = new List<Team>(teamListAll);
            cbGuestTeam.DataSource = teamListAway;
            cbHomeTeam.DataSource = teamListHome;
            cbTeam.DataSource = teamListAll;
        }

        private void cboxChooseTeam_CheckedChanged(object sender, EventArgs e)
        {
            if(cboxChooseTeam.Checked)
            {
                cbHomeTeam.Enabled = false;
                cbGuestTeam.Enabled = false;
                cbTeam.Enabled = true;
            } else
            {
                cbHomeTeam.Enabled = true;
                cbGuestTeam.Enabled = true;
                cbTeam.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Team home = null;
            Team guest = null;
            Team all = null;
            if(cboxChooseTeam.Checked)
            {
                all = cbTeam.SelectedItem as Team;
            }
            else
            {
                if (cboxOnlyHome.Checked)
                {
                    home = cbHomeTeam.SelectedItem as Team;
                }
                if (cboxOnlyGuest.Checked)
                {
                    guest = cbGuestTeam.SelectedItem as Team;
                } 
            }
            dgvSearchResults.DataSource = gc.searchGames(txtDateFrom.Text, txtDateTo.Text, home, guest, all);
            dgvSearchResults.Columns[0].Visible = false;
            dgvSearchResults.Columns[1].Visible = true;
            dgvSearchResults.Columns[1].HeaderText = "Datum";
            dgvSearchResults.Columns[2].Visible = true;
            dgvSearchResults.Columns[2].HeaderText = "Poeni domaci";
            dgvSearchResults.Columns[3].Visible = true;
            dgvSearchResults.Columns[3].HeaderText = "Poeni gosti";
            dgvSearchResults.Columns[4].Visible = false;
            dgvSearchResults.Columns[5].Visible = false;
            dgvSearchResults.Columns[6].Visible = true;
            dgvSearchResults.Columns[6].HeaderText = "Gostujuci tim";
            dgvSearchResults.Columns[7].Visible = true;
            dgvSearchResults.Columns[7].HeaderText = "Domaci tim";
            dgvSearchResults.Columns[8].Visible = false;
        }
    }
}
