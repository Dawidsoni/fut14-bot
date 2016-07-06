using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA_AUCTION {
    [Serializable]
    public class Card {
        long cardID;
        public long CardID {
            get {
                return cardID;
            }
            set {
                name = (Stock.cards.ContainsKey(value) ? Stock.cards[value] : value.ToString());
                cardID = value;
            }
        }
        public int buyPrice, sellPrice;
        public string name;

        public Card() { }

        public Card(long card, int buy, int sell) {
            CardID = card;
            buyPrice = buy;
            sellPrice = sell;
        }

        public override string ToString() {
            return "Karta \"" + name + "\" Cena licytowania: \"" + buyPrice + "\" Cena sprzedawania: \"" + sellPrice + "\"";
        }
    }
}
