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
    public partial class InsertPlayer : Form
    {
        public GUIController gc;
        public InsertPlayer()
        {
            InitializeComponent();
        }

        public InsertPlayer(GUIController gc)
        {
            this.gc = gc;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool success = gc.insertPlayer(cbCountry.SelectedItem as Country, cbTeam.SelectedItem as Team, txtName.Text, txtDate.Text, txtHeight.Text, txtWeight.Text);
            if (success)
            {
                MessageBox.Show("Uspesno ste ubacili igraca");
            }
            else
            {
                MessageBox.Show("Doslo je do greske");
            }
        }

        private void InsertPlayer_Load(object sender, EventArgs e)
        {
            try
            {
                cbTeam.DataSource = gc.getAllTeams();
                cbCountry.DataSource = gc.getAllCountries();
                this.Show();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
