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
    public partial class cbPlayer : Form
    {
        public GUIController gc;
        public List<Game> allGames;
        private BindingList<StatsItem> statItems = new BindingList<StatsItem>();
        public cbPlayer(GUIController g)
        {
            InitializeComponent();
            gc = g;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbPlayer_Load(object sender, EventArgs e)
        {
            dgvStatItems.DataSource = statItems;
            allGames = gc.getAllGames();
            cbGame.DataSource = allGames;
            Game game = cbGame.SelectedItem as Game;
            cbTeam.DataSource = new List<Team>
            {
                game.Team,
                game.Team1
            };
            Team t = cbTeam.SelectedItem as Team;
            cbPlayers.DataSource = gc.getPlayersForTeamForGame(t, game);


            dgvStatItems.Columns[0].Name = "Ime igraca";
            dgvStatItems.Columns[1].Visible = false;
            dgvStatItems.Columns[2].Visible = false;
            dgvStatItems.Columns[3].Name = "Naziv";
            dgvStatItems.Columns[4].Name = "Vrednost";
            dgvStatItems.Columns[5].Visible = false;
        }

        private void cbGame_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTeam.DataSource = null;
            Game game = cbGame.SelectedItem as Game;
            cbTeam.DataSource = new List<Team>
            {
                game.Team,
                game.Team1
            };
        }

        private void cbTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbPlayers.DataSource = null;
            cbPlayers.DataSource = gc.getPlayersForTeamForGame(cbTeam.SelectedItem as Team, cbGame.SelectedItem as Game);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!validateFieldsForItem())
            {
                return;
            }
            dgvStatItems.Columns[0].Name = "Ime igraca";
            dgvStatItems.Columns[1].Visible = false;
            dgvStatItems.Columns[2].Visible = false;
            dgvStatItems.Columns[3].Name = "Naziv";
            dgvStatItems.Columns[4].Name = "Vrednost";
            dgvStatItems.Columns[5].Visible = false;

            Player p = cbPlayers.SelectedItem as Player;
            Game game = cbGame.SelectedItem as Game;
            StatsItem si = new StatsItem
            {
                Name = txtName.Text,
                Value = Int32.Parse(txtValue.Text),
                StatsID = p.Stats.FirstOrDefault(st => st.GameID == game.GameID).StatsID,
                PlayerName = p.Name
            };

            statItems.Add(si);
            txtName.Clear();
            txtName.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StatsItem si = dgvStatItems.SelectedRows[0].DataBoundItem as StatsItem;
            statItems.Remove(si);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(statItems.Count == 0)
            {
                MessageBox.Show("Morate uneti bar 1 stavku statistike");
                return;
            }
            bool success = gc.saveAllStats(statItems.ToList());
            if (success)
            {
                MessageBox.Show("Uspesno ste sacuvali statistiku");
            } else
            {
                MessageBox.Show("Dogodila se greska, molimo vas pokusajte ponovo");
            }
        }

        private bool validateFieldsForItem()
        {
            bool valid = true;
            string errMsg = "";
            if (String.IsNullOrWhiteSpace(txtName.Text))
            {
                errMsg += "Morate uneti naziv stavke statistike" + '\n';
                valid = false;
            }
            if (String.IsNullOrWhiteSpace(txtValue.Text))
            {
                errMsg += "Morate uneti vrednost stavke statistike" + '\n';
                valid = false;
            }
            if (!valid)
            {
                MessageBox.Show(errMsg);
            }
            return valid;
        }
    }
}
