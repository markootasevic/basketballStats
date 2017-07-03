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
    public partial class InsetTeam : Form
    {
        GUIController gc;
        public InsetTeam(GUIController gui)
        {
            gc = gui;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!validateFields())
            {
                return;
            }
            bool success = gc.insertTeam(txtName.Text, txtArena.Text);

            if (success)
            {
                MessageBox.Show("Uspesno ste ubacili tim");
            }
            else
            {
                MessageBox.Show("Doslo je do greske");
            }
        }

        private bool validateFields()
        {
            bool valid = false;
            string errMsg = "";
            if(String.IsNullOrWhiteSpace(txtArena.Text))
            {
                errMsg += "Morate uneti naziv arene" + '\n';
                valid = false;
            }
            if (String.IsNullOrWhiteSpace(txtName.Text))
            {
                errMsg += "Morate uneti naziv tima" + '\n';
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
