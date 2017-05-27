using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
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
            socket.Bind(new IPEndPoint(IPAddress.Any, 55555));
            Console.WriteLine("Server je uspesno startovan!");
            //Thread krajNit = new Thread(new ThreadStart(kraj));
            //krajNit.Start();
            processClient();


        }


        private void processClient()
        {
            socket.Listen(5);
            while (true)
            {
                Socket client = socket.Accept();
                stream = new NetworkStream(client);
                TransferClass transferObject = new TransferClass();
                transferObject.TransferObject = client;
                transferObject.Signal = counter;
                clients.Add(transferObject);
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