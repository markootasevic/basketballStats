using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Domain;

namespace Server
{
    public class Server
    {
        BinaryFormatter formatter = new BinaryFormatter();
        Socket socket;
        NetworkStream stream;
        int counter = 1;
        List<TransferClass> clients = new List<TransferClass>();


        public void serverStart()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //IPAddress adresa = IPAddress.Parse("127.0.0.1");
            socket.Bind(new IPEndPoint(IPAddress.Any, 10000));
            Console.WriteLine("Server je uspesno startovan!");
            //Thread krajNit = new Thread(new ThreadStart(kraj));
            //krajNit.Start();
            processClient();


        }

        //private void kraj()
        //{
        //    Console.WriteLine("Broj klijenta kojeg zelis da ugasis?");
        //    string prihvati = Console.ReadLine();
        //    int brojKlijenta = Convert.ToInt32(prihvati);
        //    foreach (TransferClass t in klijenti)
        //    {
        //        if (t.Signal == brojKlijenta)
        //        {
        //            (t.TransferObject as Socket).Close();
        //            klijenti.Remove(t);
        //            break;
        //        }
        //    }
        //}

        private void processClient()
        {
            socket.Listen(5);
            while (true)
            {
                Socket client = socket.Accept();
                stream = new NetworkStream(client);
                TransferClass transfer = new TransferClass();
                //if (clients.Count == 2)
                //{
                //    transfer.Operation = (int)Operations.Kraj;
                //    formatter.Serialize(stream, transfer);
                //    continue;
                //}
                TransferClass transferObject = new TransferClass();
                transferObject.TransferObject = client;
                transferObject.Signal = counter;
                clients.Add(transferObject);
                transfer.Signal = counter;
                formatter.Serialize(stream, transfer);
                counter++;
                ServerThread nit = new ServerThread(stream, clients);

            }
        }


        static void Main(string[] args)
        {
            Server server = new Server();
            server.serverStart();
        }
    }
}
