using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA_AUCTION {
    class Const {
        public const int MAX_WATCH = 10;
        public const int MAX_SECONDS = 3600;
        public const int TIME_SLEEP = 1000; //1 second;
        public const int COINS_SLEEP = 1000 * 60 * 5; //5 min
        public const int TRADE_SLEEP = 1000 * 60 * 10; //10 min
        public const int PURCH_SLEEP = 1000 * 60 * 5; //5 min
        public const int RE_TRY_SLEEP = 1000 * 10; //10 seconds
        public const int STATS_SLEEP = 1000 * 60 * 10; //10 min
        public const int EVENT_SLEEP = 100;
        public const int MIN_COINS = 1000;
        public const int MAX_MESSAGES_SIZE = 100;
        public const string SESSION_EXPIRED = "UltimateTeam.Toolkit.Exceptions.ExpiredSessionException";
        public const string PLAYERS_FILE = "players.data";
        public const string CONCTRACTS_FILE = "contracts.data";
    }
}
