using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FIFA_AUCTION {
    class Stock {
        static public Dictionary<long, string> cards = new Dictionary<long, string>();
        static public Dictionary<long, string> players = new Dictionary<long,string>();
        static public Dictionary<long, string> contracts = new Dictionary<long, string>();
       

        static public void readData() {
            readDict(Const.PLAYERS_FILE, players);
            readDict(Const.CONCTRACTS_FILE, contracts);
        }

        static void readDict(string file, Dictionary<long, string> dict) {
            StreamReader reader = new StreamReader(file);
            int ile = Convert.ToInt32(reader.ReadLine());
            for (int i = 0; i < ile; i++) {
                long resID = Convert.ToInt64(reader.ReadLine());
                string key = reader.ReadLine();
                dict.Add(resID, key);
                cards.Add(resID, key);
            }
            reader.Close();
        }

    }
}
