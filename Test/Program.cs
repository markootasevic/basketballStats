using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using Domain;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                basketballStatsEntities _db = new basketballStatsEntities();

                var model = _db.Countries.First(c => c.CountryID == 1002);
                var a = 0;
                //Player p = new Player
                //{
                //    BirthDate = DateTime.Now,
                //    CountyID = 1002,
                //    Height = 202,
                //    Name = "Pera peric",
                //    Weight = 110
                //};
                //_db.Players.Add(p);
                //_db.SaveChanges();
                Console.WriteLine("ubacen igrac");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
