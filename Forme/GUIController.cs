using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace Forme
{
    class GUIController
    {
        static Communication comm = new Communication();

        public bool poveziSeSaServerom()
        {
            bool result = comm.connectToServer();
            if (result)
            {
                MessageBox.Show("Uspesna konekcija!");
                return true;
            }
            else
            {
                MessageBox.Show("Neuspesna konekcija!");
                return false;
            }
        }

        public void insertPlayer (string country, Team team, string name, string dob, string height, string weight) 
        {
            Player p = new Player
            {
                BirthDate = DateTime.Parse(dob),
                Country = new Country
                {
                    CountryID = 1,
                    Name = "Srb"
                },
                
            };
        }

        //public void dodajMesto(TextBox txtNaziv, TextBox txtPttBroj)
        //{
        //    int broj = Convert.ToInt32(txtPttBroj.Text);
        //    string naziv = txtNaziv.Text;
        //    Mesto m = new Mesto();
        //    m.Naziv = naziv;
        //    m.PttBroj = broj;
        //    try
        //    {
        //        if (comm.dodajMesto(m) == 1)
        //        {
        //            MessageBox.Show("Uspesno ste ubacili mesto!");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        return;
        //    }
        //}

        //public void vratiMesta(ComboBox mesta)
        //{
        //    mesta.DataSource = comm.vratiMesta();
        //}

        //public void vratiMestaTabela(DataGridView mesta)
        //{
        //    List<OpstiDomenskiObjekat> mestaOpsta = comm.vratiMesta();
        //    //mesta.DataSource = k.vratiMesta();
        //    List<Mesto> mestaTabela = mestaOpsta.OfType<Mesto>().ToList<Mesto>();
        //    mesta.DataSource = mestaTabela;
        //}
    }
}
