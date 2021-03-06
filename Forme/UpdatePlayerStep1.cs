﻿using System;
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
    public partial class UpdatePlayerStep1 : Form
    {
        GUIController gc;
        public UpdatePlayerStep1(GUIController g)
        {
            gc = g;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(txtSearch.Text))
            {
                MessageBox.Show("Morate uneti ime ili deo imena igraca");
                return;
            }
            dgvFoundPlayers.DataSource = gc.searchPlayer(txtSearch.Text);
            for (int i = 0; i < dgvFoundPlayers.Columns.Count; i++)
            {
                if (i == 1)
                {
                    dgvFoundPlayers.Columns[i].Visible = true;
                }
                else
                {
                    dgvFoundPlayers.Columns[i].Visible = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                new UpdatePlayerStep2(dgvFoundPlayers.SelectedRows[0].DataBoundItem as Player,gc).Show();
            }
            catch (Exception ex)
            {
            }
        }
    }
}
