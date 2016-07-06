using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FIFA_AUCTION;

namespace FUT_Bot {
    class SaveManager {
        public static void saveData() {
            StreamWriter writer = new StreamWriter(Const.SAVE_FILE);
            writer.WriteLine(Cip.Cipher.encipher(AccManager.account.Count.ToString(), true, Const.KEY));
            foreach (KeyValuePair<string, Account> pair in AccManager.account) {
                writer.WriteLine(Cip.Cipher.encipher(pair.Key, true, Const.KEY));
                Account.write(pair.Value, writer, Const.KEY);
            }
            writer.Close();
        }

        public static int readData() {
            bool read = false;
            int count = 0;
            if (File.Exists(Const.SAVE_FILE)) read = true;
            StreamReader reader = new StreamReader(new FileStream(Const.SAVE_FILE, FileMode.OpenOrCreate));
            if (read) {
                count = Convert.ToInt32(Cip.Cipher.decipher(reader.ReadLine(), true, Const.KEY));
                for (int i = 0; i < count; i++) {
                    string key = Cip.Cipher.decipher(reader.ReadLine(), true, Const.KEY);
                    Account acc = Account.read(reader, Const.KEY);
                    Task.Run(new Action(() => addNew(key, acc)));
                }
                reader.Close();
            } else {
                reader.Close();
                saveData();
            }
            return count;
        }

        static async void addNew(string key, Account acc) {
            AccManager.add(key, acc);
            bool isEnd = false;
            while (isEnd == false) {
                isEnd = await acc.login();
            }
        }

    }
}
