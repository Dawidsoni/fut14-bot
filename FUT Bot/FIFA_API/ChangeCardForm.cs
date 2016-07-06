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
    public partial class ChangeCardForm : Form {
        Card card;
        
        public ChangeCardForm(Card card) {
            InitializeComponent();
            this.card = card;
            lName.Text = "Karta: " + card.name;
            numBuy.Value = card.buyPrice;
            numSell.Value = card.sellPrice;
            int i = 0;
            foreach (string acc in AccManager.account.Keys) {
                if (AccManager.account[acc].cards.ContainsKey(card.CardID)) {
                    checkedList.Items.Add(AccManager.account[acc].details.Username);
                    checkedList.SetItemChecked(i++, true);
                }
            }
        }

        private void bCancel_Click(object sender, EventArgs e) {
            Dispose();
        }

        void changeCard(Account acc, long cardID) {
            acc.cards[cardID].buyPrice = (int)numBuy.Value;
            acc.cards[cardID].sellPrice = (int)numSell.Value;
        }

        private void bConfirm_Click(object sender, EventArgs e) {
            foreach (string acc in checkedList.CheckedItems) {
                changeCard(AccManager.account[acc], card.CardID);
            }
            Program.mainForm.removeAndAdd(card);
            SaveManager.saveData();
            Dispose();
        }

    }
}
