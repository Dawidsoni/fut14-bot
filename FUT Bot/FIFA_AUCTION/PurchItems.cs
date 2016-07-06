using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateTeam.Toolkit.Models;
using System.Collections.Concurrent;

namespace FIFA_AUCTION {
    class PurchItems : RequestBase  {
        public ConcurrentDictionary<long, Card> cards;

        public PurchItems(RequestRes res) : base(res) {}

        public async void update() {
            while (true) {
                if (safeInfo.CurTrade < safeInfo.MaxTrade) {
                    try {
                        var resp = await queue.getPurchasedItems();
                        foreach (ItemData item in resp.ItemData) {
                            await queue.SendItemToTradePile(item);
                            history.addBought(logger, details.Username, cards[item.ResourceId].name, (int)item.LastSalePrice);
                            safeInfo.CurTrade++;
                        }
                    } catch (Exception exc) {
                        Task.WaitAll(Login.reconnect(queue, details, logger, exc));
                    }
                }
                System.Threading.Thread.Sleep(Const.PURCH_SLEEP);
            }
        }
    }
}
