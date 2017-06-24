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
    public partial class InsertGameStep1 : Form
    {
        GUIController gc;
        public InsertGameStep1(GUIController gui)
        {
            gc = gui;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                new InsertGameStep2(gc, cbHomeTeam.SelectedItem as Team, cbAwayTeam.SelectedItem as Team, txtHomePts.Text, txtGuestPts.Text, txtDate.Text).Show();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void InsertGameStep1_Load(object sender, EventArgs e)
        {
            List<Team> teams = gc.getAllTeams();
            List<Team> teams1 =new List<Team>(teams);
            cbAwayTeam.DataSource = teams;
            cbHomeTeam.DataSource = teams1;
        }
    }
}
