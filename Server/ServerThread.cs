using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Server
{
    class ServerThread
    {
        BinaryFormatter formatter;
        NetworkStream stream;
        List<TransferClass> clients = new List<TransferClass>();
        //basketballStatsEntities db;

        public ServerThread(NetworkStream tok, List<TransferClass> klijenti)
        {
            formatter = new BinaryFormatter();
            this.stream = tok;
            this.clients = klijenti;
            ThreadStart ts = processClient;
            Thread nit = new Thread(ts);
            nit.Start();
            //db = new basketballStatsEntities();
            //db.Configuration.ProxyCreationEnabled = false;

        }

        private void processClient()
        {
            try
            {
                int operation = 0;
                while (operation != (int)Operations.End)
                {

                    TransferClass transfer = formatter.Deserialize(stream) as TransferClass;
                    operation = transfer.Operation;
                    switch (transfer.Operation)
                    {
                        case ((int)Operations.Save_player):
                            using (basketballStatsEntities db = new basketballStatsEntities("a"))
                            {
                                db.Configuration.ProxyCreationEnabled = false;
                                List<Object> list = transfer.TransferObject as List<Object>;
                                db.Players.Add(list[0] as Player);
                                db.PlaysFors.Add(list[1] as PlaysFor);
                                if (db.SaveChanges() != 0)
                                {
                                    transfer.Success = true;
                                }
                                else
                                {
                                    transfer.Success = false;
                                }
                                formatter.Serialize(stream, transfer);
                            }
                            break;
                        case ((int)Operations.Get_all_teams):
                            //VratiSvaMesta vrati = new VratiSvaMesta();
                            using (basketballStatsEntities db = new basketballStatsEntities("a"))
                            {
                                db.Configuration.ProxyCreationEnabled = false;
                                transfer.TransferObject = db.Teams.ToList();
                                transfer.Success = true;
                                formatter.Serialize(stream, transfer);
                            }
                            break;
                        case ((int)Operations.Get_all_countries):
                            using (basketballStatsEntities db = new basketballStatsEntities("a"))
                            {
                                db.Configuration.ProxyCreationEnabled = false;
                                transfer.TransferObject = db.Countries.ToList();
                                transfer.Success = true;
                                formatter.Serialize(stream, transfer);
                            }
                            break;

                        case ((int)Operations.Save_Team):
                            using (basketballStatsEntities db = new basketballStatsEntities("a"))
                            {
                                Team team = transfer.TransferObject as Team;
                                db.Teams.Add(team);
                                if (db.SaveChanges() != 0)
                                {
                                    transfer.Success = true;
                                }
                                else
                                {
                                    transfer.Success = false;
                                }
                                formatter.Serialize(stream, transfer);
                            }
                            break;


                        case ((int)Operations.Save_game):
                            transfer.Success = false;
                            using (basketballStatsEntities db = new basketballStatsEntities("a"))
                            {
                                List<Object> objList = transfer.TransferObject as List<Object>;
                                Game game = objList[0] as Game;
                                List<Player> homePlayers = objList[1] as List<Player>;
                                List<Player> guestPlayers = objList[2] as List<Player>;
                                db.Games.Add(game);

                                if (db.SaveChanges() != 0)
                                {
                                    transfer.Success = true;
                                }
                                else
                                {
                                    transfer.Success = false;
                                    formatter.Serialize(stream, transfer);
                                    break;
                                }

                                foreach (var home in homePlayers)
                                {
                                    Stat s = new Stat
                                    {
                                        GameID = game.GameID,
                                        PlayerID = home.PlayerID,
                                    };
                                    db.Stats.Add(s);
                                }

                                foreach (var guest in guestPlayers)
                                {
                                    Stat s = new Stat
                                    {
                                        GameID = game.GameID,
                                        PlayerID = guest.PlayerID,
                                    };
                                    db.Stats.Add(s);
                                }
                                if (db.SaveChanges() != 0)
                                {
                                    transfer.Success = true;
                                }
                                else
                                {
                                    transfer.Success = false;
                                }
                            }
                            formatter.Serialize(stream, transfer);
                            break;


                        case ((int)Operations.Get_players_for_team):
                            using (basketballStatsEntities db = new basketballStatsEntities("a"))
                            {
                                db.Configuration.ProxyCreationEnabled = false;
                                int teamId = (int)transfer.TransferObject;
                                List<PlaysFor> playsFor = db.PlaysFors.Where(pf => pf.TeamID == teamId).ToList();
                                List<Player> result = new List<Player>();
                                foreach (var pf in playsFor)
                                {
                                    if (pf.DateTo != null && DateTime.Compare(DateTime.Now, pf.DateTo ?? DateTime.Now) >= 0)
                                    {
                                        continue;
                                    }
                                    Player p = db.Players.Include("Country").FirstOrDefault(pl => pl.PlayerID == pf.PlayerID);
                                    result.Add(p);
                                }
                                transfer.TransferObject = result;
                                transfer.Success = true;
                                formatter.Serialize(stream, transfer);
                            }
                            break;

                        case (int)Operations.Get_all_games:
                            try
                            {
                                using (basketballStatsEntities db = new basketballStatsEntities("a"))
                                {
                                    List<Game> gameList = db.Games.Include("Team").Include("Team1").ToList();
                                    transfer.TransferObject = gameList;
                                    transfer.Success = true;
                                    formatter.Serialize(stream, transfer);
                                }
                            }
                            catch (Exception e)
                            {

                                throw e;
                            }
                            break;

                        case ((int)Operations.Get_Player_For_Team_For_Game):
                            using (basketballStatsEntities db = new basketballStatsEntities("a"))
                            {
                                List<Object> objList = transfer.TransferObject as List<Object>;
                                Team team = objList[0] as Team;
                                Game game = objList[1] as Game;
                                List<Player> res = new List<Player>();
                                List<PlaysFor> playsFor = db.PlaysFors.Include("Country").Where(pf => pf.TeamID == team.TeamID && (pf.DateTo == null || DateTime.Compare(DateTime.Now, pf.DateTo ?? DateTime.Now) < 0)).ToList();
                                foreach (var pf in playsFor)
                                {
                                    Player p = db.Players.Include("Stats").FirstOrDefault(pl => pl.PlayerID == pf.PlayerID);
                                    Stat s = db.Stats.FirstOrDefault(st => st.PlayerID == p.PlayerID && st.GameID == game.GameID);
                                    if (s != null)
                                    {
                                        res.Add(p);
                                    }
                                }
                                transfer.TransferObject = res;
                                transfer.Success = true;
                                formatter.Serialize(stream, transfer);
                            }
                            break;

                        case ((int)Operations.Save_all_stats):
                            using (basketballStatsEntities db = new basketballStatsEntities("a"))
                            {
                                List<StatsItem> list = transfer.TransferObject as List<StatsItem>;
                                foreach (var si in list)
                                {
                                    db.StatsItems.Add(si);
                                }
                                if (db.SaveChanges() != 0)
                                {
                                    transfer.Success = true;
                                }
                                else
                                {
                                    transfer.Success = false;
                                }
                                formatter.Serialize(stream, transfer);
                            }
                            break;

                        case ((int)Operations.Search_player):
                            using (basketballStatsEntities db = new basketballStatsEntities("a"))
                            {
                                string name = transfer.TransferObject as string;
                                List<Player> players = db.Players.Include("Country").Include("PlaysFors").Where(p => p.Name.ToLower().Contains(name.ToLower())).ToList();
                                for (int i = 0; i < players.Count; i++)
                                {
                                    int pId = players[i].PlayerID;
                                    List<PlaysFor> pf = db.PlaysFors.Include("Team").Where(p => p.PlayerID == pId).ToList();
                                    players[i].PlaysFors = pf;
                                }
                                transfer.TransferObject = players;
                                formatter.Serialize(stream, transfer);
                            }
                            break;

                        case ((int)Operations.Search_games):
                            using (basketballStatsEntities db = new basketballStatsEntities("a"))
                            {
                                GameFilter gf = transfer.TransferObject as GameFilter;
                                List<Game> games = db.Games.Include("Team").Include("Team1").ToList();
                                if (gf.DateFrom != null)
                                {
                                    DateTime date = DateTime.Parse(gf.DateFrom.ToString());
                                    games = games.Where(g => DateTime.Compare(g.Date, date) >= 0).ToList();
                                }
                                if (gf.DateTo != null)
                                {
                                    DateTime date = DateTime.Parse(gf.DateTo.ToString());
                                    games = games.Where(g => DateTime.Compare(g.Date, date) <= 0).ToList();
                                }
                                if (gf.AllTeams != null)
                                {
                                    games = games.Where(g => g.HomeTeamID == gf.AllTeams.TeamID || g.GuestTeamID == gf.AllTeams.TeamID).ToList();
                                }
                                else
                                {
                                    if (gf.HomeTeam != null)
                                    {
                                        games = games.Where(g => g.HomeTeamID == gf.HomeTeam.TeamID).ToList();
                                    }
                                    if (gf.GuestTeam != null)
                                    {
                                        games = games.Where(g => g.GuestTeamID == gf.GuestTeam.TeamID).ToList();
                                    }
                                }

                                transfer.TransferObject = games;
                                formatter.Serialize(stream, transfer);
                            }
                            break;

                        case ((int)Operations.Search_stats):
                            using (basketballStatsEntities db = new basketballStatsEntities("a"))
                            {
                                Player player = transfer.TransferObject as Player;
                                List<Stat> statsList = db.Stats.Include("Game").Include("Player").Include("StatsItems").Where(s => s.PlayerID == player.PlayerID).ToList();
                                foreach (var stat in statsList)
                                {
                                    Game game = db.Games.Include("Team1").Include("Team").FirstOrDefault(g => g.GameID == stat.GameID);
                                    stat.Game = game;
                                }
                                transfer.TransferObject = statsList;
                                formatter.Serialize(stream, transfer);

                            }

                            break;

                        case ((int)Operations.Search_teams):
                            using (basketballStatsEntities db = new basketballStatsEntities("a"))
                            {
                                string name = transfer.TransferObject as string;
                                List<Team> teamList = db.Teams.Include("PlaysFors").Where(t => t.Name.ToLower().Contains(name.ToLower())).ToList();
                                foreach (var team in teamList)
                                {
                                    team.PlaysFors = new List<PlaysFor>();
                                    List<PlaysFor> pf = db.PlaysFors.Include("Player").Where(p => p.TeamID == team.TeamID).ToList();
                                    foreach (var p in pf)
                                    {
                                        if (p.DateTo != null && DateTime.Compare(DateTime.Now, p.DateTo ?? DateTime.Now) >= 0)
                                        {
                                            continue;
                                        }
                                        team.PlaysFors.Add(p);
                                    }
                                    team.PlaysFors = pf;
                                }
                                transfer.TransferObject = teamList;
                                formatter.Serialize(stream, transfer);
                            }

                            break;

                        case ((int)Operations.Update_team):
                            using (basketballStatsEntities db = new basketballStatsEntities("a"))
                            {
                                Team team = transfer.TransferObject as Team;
                                Team dbTeam = db.Teams.FirstOrDefault(t => t.TeamID == team.TeamID);
                                dbTeam.Arena = team.Arena;
                                dbTeam.Name = team.Name;
                                db.SaveChanges();
                            }
                            break;

                        case ((int)Operations.Update_player):
                            using (basketballStatsEntities db = new basketballStatsEntities("a"))
                            {
                                Player player = transfer.TransferObject as Player;
                                Player dbPlayer = db.Players.Include("PlaysFors").FirstOrDefault(p => p.PlayerID == player.PlayerID);
                                if(player.PlaysFors.Count != dbPlayer.PlaysFors.Count)
                                {
                                    PlaysFor pf = db.PlaysFors.OrderByDescending(a => a.DateFrom).First();
                                    pf.DateTo = DateTime.Now;
                                    db.PlaysFors.Add(player.PlaysFors.Last());
                                }
                                dbPlayer.Height = player.Height;
                                dbPlayer.Weight = player.Weight;
                                dbPlayer.CountyID = player.CountyID;
                                dbPlayer.BirthDate = player.BirthDate;
                                dbPlayer.Name = player.Name;
                                db.SaveChanges();
                            }


                            break;
                        case ((int)Operations.End):
                            break;

                    }

                    //***default case:
                    //using (basketballStatsEntities db = new basketballStatsEntities("a"))
                    //{
                    //}
                    //break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Prekid niti:" + ex.Message);
            }
        }
    }
}