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
    public partial class SearchPlayersStep2 : Form
    {
        public SearchPlayersStep2(Player p)
        {
            InitializeComponent();
            txtCountry.Text = p.Country.Name.Trim();
            txtDate.Text = p.BirthDate.ToString();
            txtHeight.Text = p.Height.ToString();
            txtName.Text = p.Name;
            txtTeam.Text = p.PlaysFors.Last().Team.Name;
            txtWeight.Text = p.Weight.ToString();

        }
    }
}
