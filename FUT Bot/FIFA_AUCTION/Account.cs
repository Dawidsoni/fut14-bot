using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UltimateTeam.Toolkit;
using UltimateTeam.Toolkit.Models;
using UltimateTeam.Toolkit.Parameters;
using System.Collections.Concurrent;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace FIFA_AUCTION {
     public partial class Account {
        public SafeBox safeInfo = new SafeBox();
        public Stats stats = null;
        public TransHistory history = new TransHistory();
        public LoggerSave logger = null;
        public LoginDetails details;
        public ConcurrentDictionary<long, Card> cards = new ConcurrentDictionary<long, Card>();
        RequestRes res = null;
        FutClient client = new FutClient();
        WatchList auction = null;
        PurchItems purchItems = null;
        Coins coins = null;
        TradePile tradePile = null;
        ConcurrentDictionary<long, uint> current = new ConcurrentDictionary<long, uint>();
        ConcurrentDictionary<Card, CancellationTokenSource> tasks = new ConcurrentDictionary<Card, CancellationTokenSource>();
        List<Card> oldCards = null;

        static public Stats allStats = null;

        public Account() { }

        public Account(LoginDetails details, List<Card> cards = null) {
            this.oldCards = cards;
            this.details = details;
            logger = new LoggerSave(details.Username + ".data");
            res = new RequestRes(new EventQueue(client), logger, details, safeInfo, history);
            this.coins = new Coins(res);
            this.tradePile = new TradePile(res);
            this.tradePile.cards = this.cards;
            this.auction = new WatchList(res);
            this.auction.cards = this.cards;
            this.auction.current = this.current;
            this.purchItems = new PurchItems(res);
            this.purchItems.cards = this.cards;
            this.stats = new Stats(safeInfo, false);
            if (allStats == null) {
                allStats = new Stats(null, true);
                Task.Run(new Action(allStats.update));
            }
        }

        public async Task<bool> login() {
            safeInfo.MaxTrade = await Login.login(res.queue, res.details, res.logger);
            return Convert.ToBoolean(safeInfo.MaxTrade);
        }

        public async void update(List<Card> cards) {
            update();
            foreach (Card card in cards) {
                addCard(card);
            }
        }

        public async void update() {
            Task.Run(new Action(coins.update));
            Task.Run(new Action(tradePile.update));
            Task.Run(new Action(auction.update));
            Task.Run(new Action(purchItems.update));
            Task.Run(new Action(stats.update));
            if (oldCards != null) {
                foreach (Card card in oldCards) {
                    addCard(card);
                }
            }
        }

        public async void addCard(Card card) {
            cards.TryAdd(card.CardID, card);
            Search search = new Search(res, current, card);
            CancellationTokenSource cancel = new CancellationTokenSource();
            tasks.TryAdd(card, cancel);
            Task.Run(new Action(() => search.update(cancel.Token)), cancel.Token);
        }

        public void removeCard(Card card) {
            Card outVal = null;
            cards.TryRemove(card.CardID,out outVal);
            tasks[card].Cancel();
        }

        public void removeAcc() {
            foreach (Card card in cards.Values) {
                removeCard(card);
            }
            coins.cancel();
            tradePile.cancel();
            auction.cancel();
        }

    }
}
