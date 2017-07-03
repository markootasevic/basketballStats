using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class TransferClass
    {
        Object tranferObject;

        bool success;

        public bool Success
        {
            get { return success; }
            set { success = value; }
        }

        int operation;

        int signal;

        public int Signal
        {
            get { return signal; }
            set { signal = value; }
        }

        public int Operation
        {
            get { return operation; }
            set { operation = value; }
        }

        public Object TransferObject
        {
            get { return tranferObject; }
            set { tranferObject = value; }
        }
    }

    public enum Operations
    {
        Save_player = 1,
        Get_all_teams,
        Get_all_countries,
        Save_Team,
        Save_game,
        Get_players_for_team,
        Get_all_games,
        Get_Player_For_Team_For_Game,
        Save_all_stats,
        Search_player,
        Search_games,
        Search_stats,
        Search_teams,
        Update_team,
        Update_player,
        End
    };
}