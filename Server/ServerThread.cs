﻿using Domain;
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
                            using (basketballStatsEntities db = new basketballStatsEntities())
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
                            using (basketballStatsEntities db = new basketballStatsEntities())
                            {
                                db.Configuration.ProxyCreationEnabled = false;
                                transfer.TransferObject = db.Teams.ToList();
                                transfer.Success = true;
                                formatter.Serialize(stream, transfer);
                            }
                            break;
                        case ((int)Operations.Get_all_countries):
                            using (basketballStatsEntities db = new basketballStatsEntities())
                            {
                                db.Configuration.ProxyCreationEnabled = false;
                                transfer.TransferObject = db.Countries.ToList();
                                transfer.Success = true;
                                formatter.Serialize(stream, transfer);
                            }
                            break;

                        case ((int)Operations.Save_Team):
                            using (basketballStatsEntities db = new basketballStatsEntities())
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
                            using (basketballStatsEntities db = new basketballStatsEntities())
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
                            using (basketballStatsEntities db = new basketballStatsEntities())
                            {
                                db.Configuration.ProxyCreationEnabled = false;
                                int teamId =(int) transfer.TransferObject;
                                List<PlaysFor> playsFor = db.PlaysFors.Where(pf => pf.TeamID == teamId).ToList();
                                List<Player> result = new List<Player>();
                                foreach(var pf in playsFor)
                                {
                                    if(pf.DateTo != null && DateTime.Compare(DateTime.Now, pf.DateTo ?? DateTime.Now) >= 0)
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


                        case ((int)Operations.End):
                            break;

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Prekid niti:" + ex.Message);
            }
        }
    }
}