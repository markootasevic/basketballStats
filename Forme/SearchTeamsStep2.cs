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
    public partial class SearchTeamsStep2 : Form
    {
        Team team;
        public SearchTeamsStep2(Team t, string name, string arena)
        {
            team = t;
            InitializeComponent();
            txtName.Text = name;
            txtArena.Text = arena;
        }

        private void SearchTeamsStep2_Load(object sender, EventArgs e)
        {
            dgvPlayers.DataSource = team.PlaysFors;
            for (int i = 0; i < dgvPlayers.Columns.Count; i++)
            {
                if(i == 4)
                {
                    dgvPlayers.Columns[i].Visible = true;
                    dgvPlayers.Columns[i].HeaderText = "Ime Prezime";
                } else
                {
                    dgvPlayers.Columns[i].Visible = false;
                }
            }
        }
    }
}
