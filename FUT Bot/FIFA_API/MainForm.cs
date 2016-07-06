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
using System.Windows;

namespace FUT_Bot.FIFA_API {
    public partial class MainForm : Form {
        public delegate void AddAccDel(string key);
        public AddAccDel addAccDel;
        public Account acc;
        ShowAcc showAcc = new ShowAcc();

        public MainForm() {
            InitializeComponent();
            addAccDel = new AddAccDel(addAcc);
            Task.Run(new Action(showAcc.update));  
        }

        public void addAcc(string key) {
            comboAcc.Items.Add(key);
            comboAcc.SelectedItem = comboAcc.Items[comboAcc.Items.Count - 1];
        }

        public void changeLabels(string email, string coins, string tradeSize, string tradeMax, string curWatch) {
            try {
                Invoke((MethodInvoker)delegate { lEmail.Text =  email; });
                Invoke((MethodInvoker)delegate { lCoins.Text = "Liczba coins: " + coins; });
                Invoke((MethodInvoker)delegate { lTradeSize.Text = "Przedmioty w Trade Pile: " + tradeSize; });
                Invoke((MethodInvoker)delegate { lTradeMax.Text = "Rozmiar Trade Pile: " + tradeMax; });
                Invoke((MethodInvoker)delegate { lCurWatch.Text = "Obserwowane przedmioty: " + curWatch; });
                Invoke((MethodInvoker)delegate { lPlatf.Text = "Platforma: " + acc.details.Platform.ToString(); });
            } catch (Exception exc) { }
        }

        public void addItem(ListBox listBox, object item) {
            Invoke((MethodInvoker)delegate { 
                listBox.Items.Insert(0, item);
                if (listBox.Items.Count > FIFA_AUCTION.Const.MAX_MESSAGES_SIZE) {
                    listBox.Items.Remove(listBox.Items[FIFA_AUCTION.Const.MAX_MESSAGES_SIZE]);
                }
            });
        }

        public void clearListBox(ListBox listBox) {
            Invoke((MethodInvoker)delegate {
                listBox.Items.Clear();
            });
        }

        public void removeAndAdd(Card card) {
            Invoke((MethodInvoker)delegate {
                int index = listCards.Items.IndexOf(listCards.SelectedItem);
                listCards.Items.Remove(listCards.SelectedItem);
                listCards.Items.Insert(index, card);
            });
        }

        public void setAcc(string key) {
            this.acc = AccManager.account[key];
            showAcc.setAcc(AccManager.account[key]);
        }

        private void mouseEnter(object sender, EventArgs e) {
            Button button = (Button)sender;
            if (button == bAddCard) button.BackColor = Color.Green;
            else if (button == bChangeCard || button == bAddAcc) button.BackColor = Color.Blue;
            else button.BackColor = Color.DarkViolet;
        }

        private void mouseLeave(object sender, EventArgs e) {
            Button button = (Button)sender;
            if (button == bAddCard) button.BackColor = Color.Lime;
            else if (button == bChangeCard || button == bAddAcc) button.BackColor = Color.DeepSkyBlue;
            else button.BackColor = Color.Red;
        }

        private void bAddAcc_Click(object sender, EventArgs e) {
            new LoginForm().Show();
        }

        private void comboAcc_TextChanged(object sender, EventArgs e) {
            setAcc((string)comboAcc.SelectedItem);
        }

        private void bDelCard_Click(object sender, EventArgs e) {
            if (listCards.SelectedItem == null) {
                System.Windows.Forms.MessageBox.Show("Najpierw zaznacz element, który chcesz usunąć");
                return;
            }
            new DeleteCardForm((Card)listCards.SelectedItem).Show();
        }

        private void bChangeCard_Click(object sender, EventArgs e) {
            if (listCards.SelectedItem == null) {
                System.Windows.Forms.MessageBox.Show("Najpierw zaznacz element, który chcesz usunąć");
                return;
            }
            Card card = (Card)listCards.SelectedItem;
            new ChangeCardForm(card).Show();
        }

        private void bAddCard_Click(object sender, EventArgs e) {
            new AddCardForm(acc).Show();
        }

        private void bLogOut_Click(object sender, EventArgs e) {
            acc.removeAcc();
            AccManager.remove(acc.details.Username);
            SaveManager.saveData();
            System.Windows.Forms.MessageBox.Show("Wylogowano pomyślnie z konta " + acc.details.Username);
            comboAcc.Items.Remove(acc.details.Username);
            comboAcc.SelectedIndex = comboAcc.Items.Count - 1;
        }

        private void bStats_Click(object sender, EventArgs e) {
            new StatsForm().Show();
        }

    }
}
