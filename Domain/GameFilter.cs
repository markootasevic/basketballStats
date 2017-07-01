using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class GameFilter
    {
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public Team HomeTeam { get; set; }
        public Team GuestTeam { get; set; }
        public Team AllTeams { get; set; }
    }
}
