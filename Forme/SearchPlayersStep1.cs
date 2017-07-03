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
    public partial class SearchPlayersStep1 : Form
    {
        GUIController gc;
        public SearchPlayersStep1(GUIController gui)
        {
            gc = gui;
            InitializeComponent();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvFoundPlayers.DataSource = null;
            dgvFoundPlayers.DataSource = gc.searchPlayer(txtSearch.Text);
            setColumns();
        }

        private void setColumns()
        {
            for (int i = 0; i < dgvFoundPlayers.Columns.Count; i++)
            {
                if(i == 1)
                {
                    dgvFoundPlayers.Columns[i].Visible = true;
                } else
                {
                    dgvFoundPlayers.Columns[i].Visible = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if(String.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    MessageBox.Show("Morate uneti kriterijum pretrage");
                    return;
                }
                Player p = dgvFoundPlayers.SelectedRows[0].DataBoundItem as Player;
                new SearchPlayersStep2(p).Show();
            }
            catch (Exception)
            {
            }
        }
    }
}
