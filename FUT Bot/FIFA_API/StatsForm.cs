using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FUT_Bot.FIFA_API {
    public partial class StatsForm : Form {
        FIFA_AUCTION.Stats stats = null;
        bool isChange = false;
        DateTime fromDate, toDate;
        
        public StatsForm() {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Tick += delegate { updateLabels(); };
            timer.Interval = Const.REFRESH_TIME;
            timer.Enabled = true;
            comboAcc.SelectedIndex = 0;
            foreach (string str in AccManager.account.Keys) {
                comboAcc.Items.Add(str);
            }
            chart.Series[0].ChartType = SeriesChartType.Line;
            chart.Series[0].IsValueShownAsLabel = true;
        }

        void updateLabels() {
            lAcc.Text = "Zalogowanych kont: " + AccManager.account.Count;
            lCoins.Text = "Liczba coins: " + FIFA_AUCTION.CoinsEdit.priceString((uint)FIFA_AUCTION.SafeBox.allCoins);
            lCurTrade.Text = "Przedmioty w Trade Pile: " + FIFA_AUCTION.CoinsEdit.priceString((uint)FIFA_AUCTION.SafeBox.allCurTrade);
            lMaxTrade.Text = "Maksymalny rozmiar Trade Pile: " + FIFA_AUCTION.CoinsEdit.priceString((uint)FIFA_AUCTION.SafeBox.allMaxTrade);
            lCurWatch.Text = "Obserwowane przedmioty: " + FIFA_AUCTION.CoinsEdit.priceString((uint)FIFA_AUCTION.SafeBox.allCurWatch);
        }

        private void comboAcc_SelectedIndexChanged(object sender, EventArgs e) {
            chart.Series[0].Name = (string)comboAcc.SelectedItem;
            if (comboAcc.SelectedIndex == 0) stats = FIFA_AUCTION.Account.allStats;
            else stats = AccManager.account[(string)comboAcc.SelectedItem].stats;
            isChange = false;
            changeCombo(comboFromDate, stats, 0);
            isChange = true;
            changeCombo(comboToDate, stats, comboFromDate.Items.Count - 1);
        }

        private void combo_SelectedIndexChanged(object sender, EventArgs e) {
            if (isChange) createChart(stats);
        }

        void changeCombo(ComboBox comboBox, FIFA_AUCTION.Stats stats, int index) {
            comboBox.Items.Clear();
            foreach (DateTime dateTime in stats.safeBoxes.Keys.OrderBy(date => date.ToString())) {
                comboBox.Items.Add(dateTime);
            }
            if(comboBox.Items.Count > 0) comboBox.SelectedIndex = index;
        }

        void createChart(FIFA_AUCTION.Stats stats) {
            System.Windows.Forms.MessageBox.Show("A");
        }

    }
}
