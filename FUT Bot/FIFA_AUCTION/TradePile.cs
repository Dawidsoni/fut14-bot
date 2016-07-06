using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateTeam.Toolkit.Models;
using System.Collections.Concurrent;

namespace FIFA_AUCTION {
    class TradePile : RequestBase {
        public ConcurrentDictionary<long, Card> cards;

        public TradePile(RequestRes res) : base(res) {}

        public async void update() {
            while (true) {
                try {
                    AuctionResponse resp = await queue.GetTradePile();
                    safeInfo.CurTrade = resp.AuctionInfo.Count;
                    foreach (AuctionInfo auction in resp.AuctionInfo) {
                        if (canceled) return;
                        if (auction.Expires <= 0) {
                            try {
                                if (cards.ContainsKey(auction.ItemData.ResourceId)) {
                                    uint price = (uint)cards[auction.ItemData.ResourceId].sellPrice;
                                    await queue.ListAuction(new AuctionDetails(auction.ItemData.Id, AuctionDuration.OneHour, CoinsEdit.prevPrice(price), price));
                                    logger.send(details.Username + ": Wystawiłem przedmiot \"" + cards[auction.ItemData.ResourceId].name + "\" za " + price);
                                }
                            } catch (Exception exc) {
                                remove(auction);
                            }
                        }
                    }
                } catch (Exception exc) {
                    Task.WaitAll(Login.reconnect(queue, details, logger, exc));
                    continue;
                }
                System.Threading.Thread.Sleep(Const.TRADE_SLEEP);
            }
        }

        async void remove(AuctionInfo auction) {
            try {
                await queue.RemoveFromTradePile(auction);
                if (auction.CurrentBid > 0) {
                    history.addSold(logger, details.Username, cards[auction.ItemData.ResourceId].name, auction);
                }
            } catch (Exception exc) {
                Login.reconnect(queue, details, logger, exc);
            }
        }

    }
}
