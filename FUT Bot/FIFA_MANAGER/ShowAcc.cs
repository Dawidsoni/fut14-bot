using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FIFA_AUCTION;
using System.Collections.Concurrent;

namespace FUT_Bot {
    class ShowAcc {
        Account acc = null;
        ConcurrentQueue<Task> queue = new ConcurrentQueue<Task>();

        public void setAcc(Account acc) {
            string result;
            this.acc = acc;
            queue.Enqueue(new Task(new Action(() => {
                this.acc = acc;
                Program.mainForm.clearListBox(Program.mainForm.listLogger);
                foreach (string str in acc.logger.listMessages.Values) {
                    Program.mainForm.addItem(Program.mainForm.listLogger, str);
                    if (acc.logger.queueMessages.Count > 0 && acc.logger.queueMessages.First() == str) acc.logger.queueMessages.TryDequeue(out result);
                }
                Program.mainForm.clearListBox(Program.mainForm.listTrans);
                foreach (string str in acc.history.listMessages.Values) {
                    Program.mainForm.addItem(Program.mainForm.listTrans, str);
                    if (acc.history.queueMessages.Count > 0 && acc.history.queueMessages.First() == str) acc.history.queueMessages.TryDequeue(out result);
                }
                Program.mainForm.clearListBox(Program.mainForm.listCards);
                foreach (Card card in acc.cards.Values) {
                    Program.mainForm.addItem(Program.mainForm.listCards, card);
                }
            })));
        }

        public void update() {
            while (true) {
                updateOnce();
                while (queue.Count > 0) {
                    Task result;
                    queue.TryDequeue(out result);
                    result.Start();
                    Task.WaitAll(result);
                }
                System.Threading.Thread.Sleep(Const.REFRESH_TIME);
            }
        }

        void updateOnce() {
            string result;
            if (acc != null) {
                Program.mainForm.changeLabels(acc.details.Username, stringLabel(acc.safeInfo.NumCoins), stringLabel(acc.safeInfo.CurTrade), stringLabel(acc.safeInfo.MaxTrade), stringLabel(acc.safeInfo.CurWatch));
                while (acc.logger.queueMessages.Count > 0) {
                    acc.logger.queueMessages.TryDequeue(out result);
                    Program.mainForm.addItem(Program.mainForm.listLogger, result);
                }
                while (acc.history.queueMessages.Count > 0) {
                    acc.history.queueMessages.TryDequeue(out result);
                    Program.mainForm.addItem(Program.mainForm.listTrans, result);
                }
            }
        }

        string stringLabel(int value) {
            return (value == -1 ? "..." : FIFA_AUCTION.CoinsEdit.priceString((uint)value));
        }

    }
}
