using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    class ServerThread
    {
        BinaryFormatter formatter;
        NetworkStream stream;
        List<TransferClass> clients = new List<TransferClass>();
        basketballStatsEntities db;

        public ServerThread(NetworkStream tok, List<TransferClass> klijenti)
        {
            formatter = new BinaryFormatter();
            this.stream = tok;
            this.clients = klijenti;
            ThreadStart ts = processClient;
            Thread nit = new Thread(ts);
            nit.Start();
            db = new basketballStatsEntities();

        }

        private void processClient()
        {
            try
            {
                int operation = 0;
                while (operation != (int)Operations.Kraj)
                {

                    TransferClass transfer = formatter.Deserialize(stream) as TransferClass;
                    operation = transfer.Operation;
                    switch (transfer.Operation)
                    {
                        case ((int)Operations.Save_player):
                            List<Object> list = transfer.TransferObject as List<Object>;
                            db.Players.Add(list[0] as Player);
                            db.PlaysFors.Add(list[1] as PlaysFor);
                            if(db.SaveChanges() != 0)
                            {
                                transfer.Success = true;
                            } else
                            {
                                transfer.Success = false;
                            }
                            formatter.Serialize(stream, transfer);
                            break;
                        case ((int)Operations.Get_all_teams):
                            //VratiSvaMesta vrati = new VratiSvaMesta();

                            transfer.TransferObject = db.Teams.ToList();
                            transfer.Success = true;
                            formatter.Serialize(stream, transfer);
                            break;
                        case ((int)Operations.Get_all_countries):
                            transfer.TransferObject = db.Countries.ToList();
                            transfer.Success = true;
                            formatter.Serialize(stream, transfer);
                            break;

                        case ((int)Operations.Kraj):
                            //Console.WriteLine("Hvala na konekciji!");
                            //foreach (TransferKlasa t in klijenti)
                            //{
                            //    if (t.Signal == transfer.Signal)
                            //    {
                            //        klijenti.Remove(t);
                            //        break;
                            //    }
                            //}
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
