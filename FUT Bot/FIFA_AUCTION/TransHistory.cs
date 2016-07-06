using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateTeam.Toolkit.Models;

namespace FIFA_AUCTION {
    public class TransHistory : LoggerBase {

        public void addBought(LoggerSave logger, string user, string name, int price) {
            string message = user + ": Kupiłem przedmiot \"" + name + "\" za " + price;
            addMessage(message);
            logger.send(message);
        }

        public void addSold(LoggerSave logger, string user, string name, AuctionInfo auction) {
            string message = user + ": Sprzedałem przedmiot \"" + name + "\" za " + auction.CurrentBid;
            addMessage(message);
            logger.send(message);
        }

    }
}
