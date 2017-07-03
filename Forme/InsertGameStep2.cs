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
    public partial class InsertGameStep2 : Form
    {
        GUIController gc;
        Team homeTeam;
        Team guestTeam;
        string ptsHome;
        string ptsGuest;
        string date;
        //treba da posaljem list playerId
        BindingList<Player> homeTeamPlayers = new BindingList<Player>();
        BindingList<Player> guestTeamPlayers = new BindingList<Player>();
        public InsertGameStep2(GUIController gui, Team homeTeam, Team guestTeam, string ptsHome, string ptsGuest, string date)
        {
            gc = gui;
            this.homeTeam = homeTeam;
            this.guestTeam = guestTeam;
            this.ptsHome = ptsHome;
            this.ptsGuest = ptsGuest;
            this.date = date;
            InitializeComponent();
        }

        private void InsertGameStep2_Load(object sender, EventArgs e)
        {
            lblHomeTeam.Text = homeTeam.Name;
            lblGuestTeam.Text = guestTeam.Name;
            cbHomePlayer.DataSource = gc.getPlayerListForTeam(homeTeam.TeamID);
            cbGuestPlayer.DataSource = gc.getPlayerListForTeam(guestTeam.TeamID);
            List<Player> lista = gc.getPlayerListForTeam(guestTeam.TeamID);
            dgvHomePlayers.DataSource = homeTeamPlayers;
            dgvGuestPlayers.DataSource = guestTeamPlayers;


            foreach (DataGridViewColumn col in dgvGuestPlayers.Columns)
            {
                col.ReadOnly = true;
            }

            foreach (DataGridViewColumn col in dgvHomePlayers.Columns)
            {
                col.ReadOnly = true;
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (homeTeamPlayers.Contains(cbHomePlayer.SelectedItem as Player))
            {
                MessageBox.Show("Ne mozete dodati istog igraca 2 puta");
            }
            else
            {
                homeTeamPlayers.Add(cbHomePlayer.SelectedItem as Player);

                dgvHomePlayers.Columns[dgvGuestPlayers.Columns.Count - 1].Visible = false;
                dgvHomePlayers.Columns[dgvGuestPlayers.Columns.Count - 2].Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Player p = dgvHomePlayers.SelectedRows[0].DataBoundItem as Player;
                homeTeamPlayers.Remove(p);
            }
            catch (Exception ex)
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (guestTeamPlayers.Contains(cbGuestPlayer.SelectedItem as Player))
            {
                MessageBox.Show("Ne mozete dodati istog igraca 2 puta");
            }
            else
            {
                guestTeamPlayers.Add(cbGuestPlayer.SelectedItem as Player);

                dgvGuestPlayers.Columns[dgvGuestPlayers.Columns.Count - 1].Visible = false;
                dgvGuestPlayers.Columns[dgvGuestPlayers.Columns.Count - 2].Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Player p = dgvGuestPlayers.SelectedRows[0].DataBoundItem as Player;
                guestTeamPlayers.Remove(p);
            }
            catch (Exception ex)
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(homeTeamPlayers.Count == 0 || guestTeamPlayers.Count == 0)
            {
                MessageBox.Show("Morate uneti bar 1 igraca i za domacine i za goste");
            }
            bool res = gc.insertGame(homeTeam.TeamID.ToString(), guestTeam.TeamID.ToString(), ptsHome, ptsGuest, date, homeTeamPlayers.ToList(), guestTeamPlayers.ToList());
            if(res)
            {
                MessageBox.Show("Uspesno ste ubacili utakmicu");
            } else
            {
                MessageBox.Show("Nije uspelo ubacivanje utakmice");

            }
        }
    }
}
