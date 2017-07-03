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
        public override bool Equals(object obj)
        {
            Country c = obj as Country;
            if(c == null)
            {
                return false;
            }
            if(this.CountryID == c.CountryID)
            {
                return true;
            }
            return false;
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
    [Serializable] partial class PlaysFor {
        public override string ToString()
        {
            if(Team != null)
            {
                return Team.Name;
            } else
            {
                return "";
            }
        }
    }
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
