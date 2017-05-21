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

        public bool connectToServer()
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

        public bool insertPlayer (Country country, Team team, string name, string dob, string height, string weight) 
        {
            Player p = new Player
            {
                BirthDate = DateTime.Parse(dob),
                CountyID = country.CountryID,
                Height = Convert.ToInt32(height),
                Weight = Convert.ToInt32(weight),
                Name = name
            };
            PlaysFor pf = new PlaysFor
            {
                DateFrom = DateTime.Now,
                TeamID = team.TeamID
            };
            return comm.insertPlayer(p,pf);
        }

        public List<Team> getAllTeams()
        {
            return comm.getAllTeams();
        }

        public List<Country> getAllCountries()
        {
            return comm.getAllCountries();
        }

        //public void dodajMesto(TextBox txtNaziv, TextBox txtPttBroj)
        //{
        //    int broj = Convert.ToInt32(txtPttBroj.Text);
        //    string naziv = txtNaziv.Te    xt;
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
