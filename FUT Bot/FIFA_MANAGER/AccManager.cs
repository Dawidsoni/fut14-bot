using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FIFA_AUCTION;
using FUT_Bot.FIFA_API;
using System.Collections.Concurrent;

namespace FUT_Bot {
    class AccManager {
        public static ConcurrentDictionary<string, Account> account = new ConcurrentDictionary<string, Account>();

        public static void add(string key, Account value) {
            account.TryAdd(key, value);
            Task.Run(new Action(() => value.update()));
            Task.Run(new Action(() => addToApi(key)));
        }

        public static void remove(string email) {
            Account outAcc = null;
            account.TryRemove(email, out outAcc);
        }

        static void addToApi(string key) {
            while (Program.mainForm == null || Program.mainForm.IsHandleCreated == false) {
                System.Threading.Thread.Sleep(Const.REFRESH_TIME);
            }
            Program.mainForm.Invoke(Program.mainForm.addAccDel, new object[] { key });
        }

    }
}
