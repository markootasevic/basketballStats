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
    public partial class UpdatePlayerStep2 : Form
    {
        Player player;
        GUIController gc;
        public UpdatePlayerStep2(Player p, GUIController g)
        {
            player = p;
            gc = g;
            InitializeComponent();
            cbCountry.DataSource = gc.getAllCountries();
            cbCountry.SelectedIndex = cbCountry.Items.IndexOf(player.Country);
            txtName.Text = player.Name.Trim();
            txtDate.Text = player.BirthDate.ToShortDateString();
            txtHight.Text = player.Height.ToString();
            txtWeight.Text = player.Weight.ToString();
            List<Team> teamList = gc.getAllTeams();
            cbTeam.DataSource = teamList;
            int index = 0;
            for (int i = 0; i < teamList.Count; i++)
            {
                if(teamList[i].TeamID == player.PlaysFors.OrderByDescending(x => x.DateFrom).First().Team.TeamID)
                {
                    index = i;
                    break;
                }
            }
            cbTeam.SelectedIndex = index;
        }

        private void UpdatePlayerStep2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!validateFields())
            {
                return;
            }
            player.Height = Int32.Parse(txtHight.Text);
            player.Weight = Int32.Parse(txtWeight.Text);
            player.BirthDate = DateTime.Parse(txtDate.Text);
            player.Name = txtName.Text;
            Country c = cbCountry.SelectedItem as Country;
            player.CountyID = c.CountryID;
            Team t = cbTeam.SelectedItem as Team;
            if (t.TeamID != player.PlaysFors.Last().Team.TeamID)
            {
                player.PlaysFors.Add(new PlaysFor
                {
                    DateFrom = DateTime.Now,
                    PlayerID = player.PlayerID,
                    TeamID = t.TeamID
                });
            }

            gc.updatePlayer(player);
            MessageBox.Show("Uspesno ste izmenili igraca");
        }

        private bool validateFields()
        {
            bool valid = true;
            string errMsg = "";
            if (String.IsNullOrWhiteSpace(txtDate.Text))
            {
                errMsg += "Morate uneti datum rodjenja" + '\n';
                valid = false;
            }
            if (String.IsNullOrWhiteSpace(txtHight.Text))
            {
                errMsg += "Morate uneti visinu igraca" + '\n';
                valid = false;
            }
            if (String.IsNullOrWhiteSpace(txtName.Text))
            {
                errMsg += "Morate uneti ime igraca" + '\n';
                valid = false;
            }
            if (String.IsNullOrWhiteSpace(txtWeight.Text))
            {
                errMsg += "Morate uneti tezinu igraca" + '\n';
                valid = false;
            }
            if(!valid)
            {
                MessageBox.Show(errMsg);
            }
            return valid;
        }
    }
}
