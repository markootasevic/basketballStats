using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    //class OvverideSettings
    //{
    //}
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
    [Serializable] partial class StatsItem { }
    [Serializable]
    partial class Team
    {
        public override string ToString()
        {
            return Name;
        }
    }
}
