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
    public partial class SearchTeamsStep1 : Form
    {
        GUIController gc;
        public SearchTeamsStep1(GUIController g)
        {
            gc = g;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvTeam.DataSource = gc.searchTeams(txtName.Text);
            for (int i = 0; i < dgvTeam.Columns.Count; i++)
            {
                if(i == 1 || i == 2)
                {
                    if(i == 1)
                    {
                        dgvTeam.Columns[i].Visible = true;
                        dgvTeam.Columns[i].HeaderText = "Ime";
                    } else
                    {
                        dgvTeam.Columns[i].Visible = true;
                    }
                } else
                {
                    dgvTeam.Columns[i].Visible = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Team t = dgvTeam.SelectedRows[0].DataBoundItem as Team;
                new SearchTeamsStep2(t, t.Name, t.Arena).Show();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
