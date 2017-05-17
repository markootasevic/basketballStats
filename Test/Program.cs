using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

                var model = _db.Countries.ToList();
                var a = 0;
                Console.WriteLine("sta je ovo bre");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
