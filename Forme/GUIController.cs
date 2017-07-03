using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace Forme
{
    public class GUIController
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

        public bool insertPlayer(Country country, Team team, string name, string dob, string height, string weight)
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
            return comm.insertPlayer(p, pf);
        }


        public bool insertTeam(string name, string arena)
        {
            Team t = new Team
            {
                Name = name,
                Arena = arena
            };
            return comm.insertTeam(t);
        }


        public bool insertGame(string homeTeamId, string guestTeamId, string ptsHome, string ptsGuest, string date, List<Player> homePlayers, List<Player> guestPlayers)
        {
            Game g = new Game
            {
                Date = DateTime.Parse(date),
                GuestTeamID = Int32.Parse(guestTeamId),
                HomeTeamID = Int32.Parse(homeTeamId),
                GuestTeamPts = Int32.Parse(ptsGuest),
                HomeTeamPts = Int32.Parse(ptsHome)
            };
            return comm.insertGame(g, homePlayers, guestPlayers);
        }

        public List<Team> getAllTeams()
        {
            return comm.getAllTeams();
        }

        public List<Country> getAllCountries()
        {
            return comm.getAllCountries();
        }

        public List<Player> getPlayerListForTeam(int teamId)
        {
            return comm.getPlayerListForTeam(teamId);
        }

        public List<Game> getAllGames()
        {
            return comm.getAllGames();
        }

        public List<Player> getPlayersForTeamForGame(Team team, Game game)
        {
            return comm.getPlayersForTeamForGame(team, game);
        }

        public bool saveAllStats(List<StatsItem> list)
        {
            return comm.saveAllStats(list);
        }

        public List<Player> searchPlayer(string name)
        {
            return comm.searchPlayer(name);
        }

        public List<Game> searchGames(string dateFrom, string dateTo, Team home, Team guest, Team all)
        {
            GameFilter gf = new GameFilter();
            if(!String.IsNullOrWhiteSpace(dateFrom))
            {
                gf.DateFrom = DateTime.Parse(dateFrom);
            }
            if (!String.IsNullOrWhiteSpace(dateTo))
            {
                gf.DateTo = DateTime.Parse(dateTo);
            }
            gf.AllTeams = all;
            gf.HomeTeam = home;
            gf.GuestTeam = guest;
            return comm.searchGames(gf);
        }

        public List<Stat> searchStats(Player p)
        {
            return comm.searchStats(p);
        }

        public List<Team> searchTeams(string name)
        {
            return comm.searchTeams(name);
        }

        public void updateTeam(Team t)
        {
            comm.updateTeam(t);
        }

        public void updatePlayer(Player p)
        {
            comm.updatePlayer(p);
        }
        //public bool insertGame(DateTime date, int homeTeamId, int homeTeamPts, int guestTeamId, int guestTeamPts)
        //{
        //    Game g = new Game
        //    {
        //        Date = date,
        //        GuestTeamID = guestTeamId,
        //        GuestTeamPts = guestTeamPts,
        //        HomeTeamID = homeTeamId,
        //        HomeTeamPts = homeTeamPts

        //    };


        //}

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