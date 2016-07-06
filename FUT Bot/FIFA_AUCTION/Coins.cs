using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateTeam.Toolkit;
using UltimateTeam.Toolkit.Models;

namespace FIFA_AUCTION {
    public class Coins : RequestBase {

        public Coins(RequestRes res) : base(res) {}

        public async void update() {
            while (true) {
                if (canceled) return;
                try {
                    CreditsResponse resp = await queue.GetCredits();
                    if (resp.Credits > 0) {
                        safeInfo.NumCoins = (int)resp.Credits;
                        logger.send(details.Username + ": Posiadasz " + resp.Credits + " coins");
                    }
                } catch (Exception exc) {
                    Task.WaitAll(Login.reconnect(queue, details, logger, exc));
                    continue;
                }
                System.Threading.Thread.Sleep(Const.COINS_SLEEP);
            }
        }
    }
}
