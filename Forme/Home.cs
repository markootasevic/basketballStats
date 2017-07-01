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
    public partial class Home : Form
    {
        GUIController gc = new GUIController();
        public Home()
        {
            InitializeComponent();
        }

        private void connectToServer()
        { 
            if (!gc.connectToServer())
            {
                Close();
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            connectToServer();
        }

        private void unosIgracaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InsertPlayer(gc).Show();
        }

        private void unosTimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InsetTeam(gc).Show();
        }

        private void unosUtakmiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InsertGameStep1(gc).Show();
        }

        private void unosStatistikeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new cbPlayer(gc).Show();
        }

        private void pretragaIgracaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SearchPlayersStep1(gc).Show();
        }

        private void pretragaUtakmiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SearchGames(gc).Show();
        }

        private void pretragaStatistikeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SearchStatsStep1(gc).Show();
        }

        private void pregragaTimovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SearchTeamsStep1(gc).Show();
        }
    }
}
