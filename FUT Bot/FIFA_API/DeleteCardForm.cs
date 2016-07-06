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
    public partial class DeleteCardForm : Form {
        Card card;
        public DeleteCardForm(Card card) {
            InitializeComponent();
            this.card = card;
            lName.Text = "Usuń kartę: " + card.name;
            int i = 0;
            foreach (string acc in AccManager.account.Keys) {
                if (AccManager.account[acc].cards.ContainsKey(card.CardID)) {
                    checkedList.Items.Add(AccManager.account[acc].details.Username);
                    checkedList.SetItemChecked(i++, true);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            Dispose();
        }

        void delCard(Account acc, long cardID, bool apiChanged) {
            acc.removeCard(acc.cards[cardID]);
        }

        private void button1_Click(object sender, EventArgs e) {
            foreach (string acc in checkedList.CheckedItems) {
                delCard(AccManager.account[acc], card.CardID, AccManager.account[acc].cards[card.CardID] == card);
            }
            SaveManager.saveData();
            Program.mainForm.setAcc(Program.mainForm.acc.details.Username);
            Dispose();
        }


    }
}
