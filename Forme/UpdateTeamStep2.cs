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
    public partial class UpdateTeamStep2 : Form
    {
        Team team;
        GUIController gc;
        public UpdateTeamStep2(Team t, GUIController g)
        {
            team = t;
            gc = g;
            InitializeComponent();
            txtArena.Text = t.Arena.Trim();
            txtName.Text = t.Name;
        }

        private void UpdateTeamStep2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!validateFields())
            {
                return;
            }
            team.Name = txtName.Text;
            team.Arena = txtArena.Text;
            gc.updateTeam(team);
            MessageBox.Show("Uspesno ste izmenili tim");
        }

        private bool validateFields()
        {
            bool valid = true;
            string errMsg = "";
            if (String.IsNullOrWhiteSpace(txtArena.Text))
            {
                errMsg += "Morate uneti naziv arene" + '\n';
                valid = false;
            }
            if (String.IsNullOrWhiteSpace(txtName.Text))
            {
                errMsg += "Morate uneti naziv tima" + '\n';
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
