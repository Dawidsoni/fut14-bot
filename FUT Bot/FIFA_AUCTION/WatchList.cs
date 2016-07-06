using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateTeam.Toolkit;
using UltimateTeam.Toolkit.Constants;
using UltimateTeam.Toolkit.Exceptions;
using UltimateTeam.Toolkit.Extensions;
using UltimateTeam.Toolkit.Factories;
using UltimateTeam.Toolkit.Models;
using UltimateTeam.Toolkit.Parameters;
using UltimateTeam.Toolkit.Requests;
using UltimateTeam.Toolkit.Services;
using System.Collections.Concurrent;

namespace FIFA_AUCTION {
    class WatchList : RequestBase {
        public ConcurrentDictionary<long, Card> cards;
        public ConcurrentDictionary<long, uint> current;

        public WatchList(RequestRes res) : base(res) {}

        public async void update() {
            while (true) {
                try {
                    var resp = await queue.GetWatchlist();
                    safeInfo.CurWatch = resp.AuctionInfo.Count;
                    uint count = 0, val = 0;
                    foreach (AuctionInfo auction in resp.AuctionInfo) {
                        if (canceled) return;
                        try {
                            if (safeInfo.CurTrade < safeInfo.MaxTrade && auction.Expires <= 0) {
                                current.TryRemove(auction.TradeId, out val);
                                await queue.SendItemToTradePile(auction.ItemData);
                                history.addBought(logger, details.Username, cards[auction.ItemData.ResourceId].name, (int)auction.CurrentBid);
                                safeInfo.CurTrade++;
                            } else if (cards.ContainsKey(auction.ItemData.ResourceId) && auction.CurrentBid > current[auction.TradeId] && auction.CalculateBid() <= cards[auction.ItemData.ResourceId].buyPrice) {
                                current[auction.TradeId] = auction.CalculateBid();
                                await queue.PlaceBid(auction, auction.CalculateBid());
                                logger.send(details.Username + ": Zalicytowałem na " + current[auction.TradeId] + " przedmiot \"" + cards[auction.ItemData.ResourceId].name + "\"");
                            }
                            count++;
                            if (count >= Const.MAX_WATCH) break;
                        } catch (Exception exc) {
                            remove(auction);
                        }
                    }
                } catch (Exception exc) {
                    Task.WaitAll(Login.reconnect(queue, details, logger, exc));
                }
            }
        }

        void remove(AuctionInfo auction) {
            try {
                Task.WaitAll(queue.RemoveFromWatchlist(auction));
            } catch (Exception exc) {
                Task.WaitAll(Login.reconnect(queue, details, logger, exc));
            }
        }
    }
}
