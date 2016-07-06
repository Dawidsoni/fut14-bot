using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA_AUCTION {
    public class SafeBox {
        int numCoins = -1, maxTrade = -1, curTrade = -1, curWatch = -1;

        public static int allCoins, allMaxTrade, allCurTrade, allCurWatch;

        public int NumCoins {
            get {return numCoins;}
            set {
                if(numCoins != -1) allCoins -= numCoins;
                allCoins += value;
                numCoins = value;
            }
        }

        public int MaxTrade {
            get { return maxTrade; }
            set {
                if(maxTrade != -1) allMaxTrade -= maxTrade;
                allMaxTrade += value;
                maxTrade = value;
            }
        }

        public int CurTrade {
            get { return curTrade; }
            set {
                if(curTrade != -1) allCurTrade -= curTrade;
                allCurTrade += value;
                curTrade = value;
            }
        }

        public int CurWatch {
            get { return curWatch; }
            set {
                if(curWatch != -1) allCurWatch -= curWatch;
                allCurWatch += value;
                curWatch = value;
            }
        }

        public SafeBox copy() {
            SafeBox res = new SafeBox();
            res.numCoins = numCoins;
            res.maxTrade = maxTrade;
            res.curTrade = curTrade;
            res.curWatch = curWatch;
            return res;
        }

        public static SafeBox staticObj() {
            SafeBox res = new SafeBox();
            res.numCoins = allCoins;
            res.maxTrade = allMaxTrade;
            res.curTrade = allCurTrade;
            res.curWatch = allCurWatch;
            return res;
        }
    
    }
}
