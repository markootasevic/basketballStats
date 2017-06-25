using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public partial class basketballStatsEntities : DbContext
    {
        public basketballStatsEntities(string a)
            : base("name=basketballStatsEntities")
        {
            this.Configuration.ProxyCreationEnabled = false;
        }
    }
    [Serializable]
    partial class Country
    {
        public override string ToString()
        {
            return Name;
        }
    }
    [Serializable]
    partial class Game
    {
        public override string ToString()
        {
            string res = String.Format("{0} {1} : {2} {3}", Team.Name, HomeTeamPts, Team1.Name, GuestTeamPts);
            return res;
        }
    }
    [Serializable]
    partial class Player
    {
        public override string ToString()
        {
            return Name;
        }
    }
    [Serializable] partial class PlaysFor { }
    [Serializable] partial class Stat { }
    [Serializable]
    partial class StatsItem
    {
        public string PlayerName { get; set; }
    }
    [Serializable]
    partial class Team
    {
        public override string ToString()
        {
            return Name;
        }
    }
}
