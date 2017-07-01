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
    public partial class SearchStatsStep2 : Form
    {
        Stat stat;
        public SearchStatsStep2(Stat s)
        {
            stat = s;
            InitializeComponent();
        }

        private void SearchStatsStep2_Load(object sender, EventArgs e)
        {
            txtGame.Text = stat.Game.ToString();
            txtPlayer.Text = stat.Player.Name.Trim();
            dgvStatItems.DataSource = stat.StatsItems.ToList();
            for (int i = 0; i < dgvStatItems.Columns.Count; i++)
            {
                if(i == 3 || i == 4)
                {
                    dgvStatItems.Columns[i].Visible = true;
                    if(i == 3)
                    {
                        dgvStatItems.Columns[i].HeaderText = "Naziv";
                    } else
                    {
                        dgvStatItems.Columns[i].HeaderText = "Vrednost";
                    }
                }
                else
                {
                    dgvStatItems.Columns[i].Visible = false;
                }
            }

        }
    }
}
