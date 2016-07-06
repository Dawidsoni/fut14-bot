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
using System.Threading;

namespace FIFA_AUCTION {
    class Search : RequestBase{
        static ConcurrentDictionary<long, uint> current;
        SearchParameters searchParams;
        Card card;

        public Search(RequestRes res, ConcurrentDictionary<long, uint> cur, Card card) : base(res) {
            current = cur;
            this.card = card;
            newParams(card);
        }

        public async void update(CancellationToken cancel) {
            while (true) {
                bool ifCancel = false, ifRest = false;
                for (uint page = 1;ifRest == false; page++) {
                    if (cancel.IsCancellationRequested) {
                        ifCancel = true;
                        break;
                    }
                    else if (safeInfo.CurTrade >= safeInfo.MaxTrade || safeInfo.NumCoins < Const.MIN_COINS) {
                        System.Threading.Thread.Sleep(Const.RE_TRY_SLEEP);
                        break;
                    }
                    searchParams.ResourceId = card.CardID;
                    searchParams.MaxBid = (uint)card.buyPrice;
                    searchParams.Page = page;
                    try {
                        var resp = await queue.SearchAsync(searchParams);
                        foreach (AuctionInfo auction in resp.AuctionInfo) {
                            if (auction.Expires > Const.MAX_SECONDS) ifRest = true;
                            if (auction.ItemData.ResourceId == card.CardID && auction.CalculateBid() <= card.buyPrice) {
                                current.TryAdd(auction.TradeId, auction.CalculateBid());
                                await queue.PlaceBid(auction, auction.CalculateBid());
                                logger.send(details.Username + ": Zalicytowałem na " + current[auction.TradeId] + " przedmiot \"" + card.name + "\" i dodałem do watch list");
                            }
                        }
                    } catch (Exception exc) {
                        Task.WaitAll(Login.reconnect(queue, details, logger, exc));
                    }
                }
                if (ifCancel) break;
            }
        }

        void newParams(Card card) {
            if(Stock.players.ContainsKey(card.CardID)) {
                searchParams = new PlayerSearchParameters();
            } else if (Stock.contracts.ContainsKey(card.CardID)) {
                searchParams = new DevelopmentSearchParameters() {
                    DevelopmentType = DevelopmentType.Contract
                };
            } else {
                throw new Exception("Nie ma dostepnej takiej karty do licytowania");
            }
        }

    }
}
