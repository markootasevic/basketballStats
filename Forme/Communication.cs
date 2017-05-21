using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;

namespace Forme
{
    class Communication
    {
        TcpClient client;
        NetworkStream stream;
        BinaryFormatter formatter = new BinaryFormatter();
        int numOfClients;

        public int NumOfClients
        {
            get { return numOfClients; }
            set { numOfClients = value; }
        }

        public bool connectToServer()
        {
            try
            {
                client = new TcpClient("127.0.0.1", 10000);
                stream = client.GetStream();
                //TransferClass transfer = formatter.Deserialize(stream) as TransferClass;
                //if (transfer.Operation == (int)Operations.Kraj)
                //{
                //    return false;
                //}
                //numOfClients = transfer.Signal;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool insertPlayer(Player player,PlaysFor playsFor)
        {
            List<Object> list = new List<Object>();
            list.Add(player);
            list.Add(playsFor);
            TransferClass transfer = new TransferClass();
            transfer.TransferObject = list;
            transfer.Operation = (int)Operations.Save_player;
            formatter.Serialize(stream, transfer);
            transfer = formatter.Deserialize(stream) as TransferClass;
            if (transfer.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        //public int dodajMesto(Mesto m)
        //{

        //    TransferClass transfer = new TransferClass();
        //    transfer.Operation = (int)Operations.Sacuvaj_Mesto;
        //    transfer.TransferObject = m;
        //    formater.Serialize(tok, transfer);
        //    transfer = formater.Deserialize(tok) as TransferClass;
        //    if (transfer.Success)
        //    {
        //        return 1;
        //    }
        //    else
        //    {
        //        return 0;
        //    }
        //    //return transfer.Signal;
        //}

        public List<Team> getAllTeams()
        {

            TransferClass transfer = new TransferClass();
            transfer.Operation = (int)Operations.Get_all_teams;
            formatter.Serialize(stream, transfer);
            transfer = formatter.Deserialize(stream) as TransferClass;
            if (transfer.Success)
            {
                return transfer.TransferObject as List<Team>;
            }
            else
            {
                return null;
            }
        }

        public List<Country> getAllCountries()
        {

            try
            {
                TransferClass transfer = new TransferClass();
                transfer.Operation = (int)Operations.Get_all_countries;

                formatter.Serialize(stream, transfer);
                transfer = formatter.Deserialize(stream) as TransferClass;
                if (transfer.Success)
                {
                    return transfer.TransferObject as List<Country>;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void zatvori()
        {
            TransferClass transfer = new TransferClass();
            transfer.Operation = (int)Operations.Kraj;
            transfer.Signal = numOfClients;
            formatter.Serialize(stream, transfer);
        }
    }
}
