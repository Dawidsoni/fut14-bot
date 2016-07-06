using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateTeam.Toolkit;
using UltimateTeam.Toolkit.Requests;
using UltimateTeam.Toolkit.Models;

namespace FIFA_AUCTION {
    class Login {
        public static async Task<int> login(EventQueue queue, LoginDetails details, LoggerSave logger) {
            queue.client = new FutClient();
            System.Threading.Thread.Sleep(Const.TIME_SLEEP);
            logger.send(details.Username + ": Trwa logowanie...");
            try {
                var resp = await queue.Login(details);
                logger.send(details.Username + ": Zalogowano. Witaj " + resp.UserAccounts.UserAccountInfo.Personas.First().PersonaName);
                return (await queue.client.GetPileSizeAsync()).Entries[0].Value;
            } catch (Exception exc) {
                logger.send(details.Username + ": Logowanie nie powiodło się.");
                return 0;
            }
        }

        public static async Task<int> reconnect(EventQueue queue, LoginDetails details, LoggerSave logger, Exception exc) {
            if (exc.GetType().ToString() == Const.SESSION_EXPIRED) {
                logger.send(details.Username + " Trwa ponowna proba logowania...");
                int result;
                while (true) {
                    result = await login(queue, details, logger);
                    if (result != 0) break;
                }
                return result;
            }
            return 0;
        }
    }
}
