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
        Communication comm;
        GUIController gc = new GUIController();
        public Home()
        {
            InitializeComponent();
        }

        private void connectToServer()
        {
            comm = new Communication();
            if (!comm.connectToServer())
            {
                Close();
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            connectToServer();
            label1.Text = comm.NumOfClients.ToString();
        }
    }
}
