using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FIFA_AUCTION;
using FUT_Bot.FIFA_API;

namespace FUT_Bot {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static MainForm mainForm = null;

        [STAThread]
        static void Main() {
            Stock.readData();
            int maxAcc = SaveManager.readData();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (maxAcc == 0) {
                Application.Run(new LoginForm());
            }
            if (maxAcc == 0 && AccManager.account.Count == 0) return;
            mainForm = new MainForm();
            Application.Run(mainForm);
        }
    }
}
