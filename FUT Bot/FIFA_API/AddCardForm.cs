using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FIFA_AUCTION;

namespace FUT_Bot.FIFA_API {
    public partial class AddCardForm : Form {
        Account acc;

        public AddCardForm(Account acc) {
            InitializeComponent();
            this.acc = acc;
            comboType.SelectedIndex = 0;
            int i = 0;
            foreach (string cur in AccManager.account.Keys) {
                checkedList.Items.Add(cur);
                checkedList.SetItemChecked(i++, true);
            }
        }

        void addCard(Account acc, Card card, bool apiChanged) {
            acc.addCard(card);
            if(apiChanged) Program.mainForm.addItem(Program.mainForm.listCards, card);
        }

        private void bConfirm_Click(object sender, EventArgs e) {
            Card card = new Card(((IdNamePair)comboName.SelectedItem).id,(int) numBuy.Value,(int) numSell.Value);
            foreach(string curAcc in checkedList.CheckedItems) {
                addCard(AccManager.account[curAcc], card, acc == AccManager.account[curAcc]);
            }
            SaveManager.saveData();
            Dispose();
        }

        private void bCancel_Click(object sender, EventArgs e) {
            Dispose();
        }

        private void comboType_TextChanged(object sender, EventArgs e) {
            comboName.Items.Clear();
            if (comboType.Text == "Zawodnicy") {
                foreach (KeyValuePair<long, string> tuple in Stock.players) {
                    comboName.Items.Add(new IdNamePair(tuple.Key, tuple.Value));
                }
            } else if (comboType.Text == "Kontrakty") {
                foreach (KeyValuePair<long, string> tuple in Stock.contracts) {
                    comboName.Items.Add(new IdNamePair(tuple.Key, tuple.Value));
                }
            } else throw new Exception("Zła wartość na liście typów kart");
            comboName.SelectedIndex = 0;
        }
    }
}
