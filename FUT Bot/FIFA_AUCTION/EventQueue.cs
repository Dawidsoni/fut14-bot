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
using System.Threading;

namespace FIFA_AUCTION {
    public class EventQueue {
        public FutClient client;
        long counter = 0, current = 0;

        public EventQueue() { }

        public EventQueue(FutClient cli) {
            client = cli;
        }

        public async Task<LoginResponse> Login(LoginDetails param) {
            long waitFor = counter;
            Interlocked.Increment(ref counter);
            while (waitFor > current) {
                Thread.Sleep(Const.EVENT_SLEEP);
            }
            Task.Run(new Action(increment));
            return await client.LoginAsync(param);
        }

        public async Task<PurchasedItemsResponse> getPurchasedItems() {
            long waitFor = counter;
            Interlocked.Increment(ref counter);
            while (waitFor > current) {
                Thread.Sleep(Const.EVENT_SLEEP);
            }
            Task.Run(new Action(increment));
            return await client.GetPurchasedItemsAsync();
        }

        public async Task<ListAuctionResponse> ListAuction(AuctionDetails details) {
            long waitFor = counter;
            Interlocked.Increment(ref counter);
            while (waitFor > current) {
                Thread.Sleep(Const.EVENT_SLEEP);
            }
            Task.Run(new Action(increment));
            return await client.ListAuctionAsync(details);
        }

        public async Task RemoveFromTradePile(AuctionInfo auction) {
            long waitFor = counter;
            Interlocked.Increment(ref counter);
            while (waitFor > current) {
                Thread.Sleep(Const.EVENT_SLEEP);
            }
            Task.Run(new Action(increment));
            await client.RemoveFromTradePileAsync(auction);
        }

        public async Task<AuctionResponse> GetTradePile() {
            long waitFor = counter;
            Interlocked.Increment(ref counter);
            while (waitFor > current) {
                Thread.Sleep(Const.EVENT_SLEEP);
            }
            Task.Run(new Action(increment));
            return await client.GetTradePileAsync();
        }

        public async Task<CreditsResponse> GetCredits() {
            long waitFor = counter;
            Interlocked.Increment(ref counter);
            while (waitFor > current) {
                Thread.Sleep(Const.EVENT_SLEEP);
            }
            Task.Run(new Action(increment));
            return await client.GetCreditsAsync();
        }

        public async Task<AuctionResponse> SearchAsync(SearchParameters param) {
            long waitFor = counter;
            Interlocked.Increment(ref counter);
            while (waitFor > current) {
                Thread.Sleep(Const.EVENT_SLEEP);
            }
            Task.Run(new Action(increment));
            return await client.SearchAsync(param);
        }

        public async Task<AuctionResponse> PlaceBid(AuctionInfo auction, uint bid) {
            long waitFor = counter;
            Interlocked.Increment(ref counter);
            while (waitFor > current) {
                Thread.Sleep(Const.EVENT_SLEEP);
            }
            Task.Run(new Action(increment));
            return await client.PlaceBidAsync(auction, bid);
        }

        public async Task<WatchlistResponse> GetWatchlist() {
            long waitFor = counter;
            Interlocked.Increment(ref counter);
            while (waitFor > current) {
                Thread.Sleep(Const.EVENT_SLEEP);
            }
            Task.Run(new Action(increment));
            return await client.GetWatchlistAsync();
        }

        public async Task<SendItemToTradePileResponse> SendItemToTradePile(ItemData item) {
            long waitFor = counter;
            Interlocked.Increment(ref counter);
            while (waitFor > current) {
                Thread.Sleep(Const.EVENT_SLEEP);
            }
            Task.Run(new Action(increment));
            return await client.SendItemToTradePileAsync(item);
        }

        public async Task RemoveFromWatchlist(AuctionInfo auction) {
            long waitFor = counter;
            Interlocked.Increment(ref counter);
            while (waitFor > current) {
                Thread.Sleep(Const.EVENT_SLEEP);
            }
            Task.Run(new Action(increment));
            await client.RemoveFromWatchlistAsync(auction);
        }

        void increment() {
            System.Threading.Thread.Sleep(Const.TIME_SLEEP);
            Interlocked.Increment(ref current);
        }

    }
}
