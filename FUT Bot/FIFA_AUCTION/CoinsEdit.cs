using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA_AUCTION {
    class CoinsEdit {
        //200 - 1000 co 50
        //1000 - 10000 co 100
        //10000+ co 250
        public static void changeToAuction(ref uint coins) {
            if (coins < 1000) {
                coins /= 50;
                coins *= 50;
            } else if (coins < 10000) {
                coins /= 100;
                coins *= 100;
            } else {
                coins /= 250;
                coins *= 250;
            }
        }

        public static uint nextPrice(uint coins) {
            if (coins < 1000) {
                return coins + 50;
            } else if (coins < 10000) {
                return coins + 100;
            } else {
                return coins + 250;
            }
        }

        public static uint prevPrice(uint coins) {
            if (coins <= 1000) {
                return coins - 50;
            } else if (coins <= 10000) {
                return coins - 100;
            } else {
                return coins - 250;
            }
        }

        public static string priceString(uint credits) {
            string wynCoins = "";
            for (int licz = 0; licz < credits.ToString().Length; licz++) {
                wynCoins += credits.ToString()[licz];
                if (licz % 3 == (credits.ToString().Length % 3 + 2) % 3) wynCoins += " ";
            }
            return wynCoins;
        }

    }
}