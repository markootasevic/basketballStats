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


        public ServerThread(NetworkStream tok, List<TransferClass> klijenti)
        {
            formatter = new BinaryFormatter();
            this.stream = tok;
            this.clients = klijenti;
            ThreadStart ts = obradaPodataka;
            Thread nit = new Thread(ts);
            nit.Start();


        }

        private void obradaPodataka()
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
                        case ((int)Operations.Sacuvaj_Mesto):
                        //UbaciMesto ubaci = new UbaciMesto();
                        //transfer.Uspesnost = ubaci.izvrsiSo(transfer.TransferObjekat as OpstiDomenskiObjekat);
                        ////transfer.Signal = Broker.dajSesiju().ubaciMestoUBazu(transfer.TransferObjekat as Mesto);
                        //formater.Serialize(tok, transfer);
                        //break;
                        case ((int)Operations.Vrati_Mesta):
                        //VratiSvaMesta vrati = new VratiSvaMesta();
                        //transfer.Uspesnost = vrati.izvrsiSo(transfer.TransferObjekat as OpstiDomenskiObjekat);
                        //transfer.TransferObjekat = vrati.Lista;
                        //formater.Serialize(tok, transfer);
                        //break;
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
