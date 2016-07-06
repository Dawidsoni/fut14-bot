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
using UltimateTeam.Toolkit.Models;

namespace FUT_Bot {
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e) {

        }

        private void bCancel_Click(object sender, EventArgs e) {
            Dispose();
        }

        private void mouseEnter(object sender, EventArgs e) {
            Button button = (Button)sender;
            if (button == bConfirm) button.BackColor = Color.Green;
            else button.BackColor = Color.DarkViolet;
        }

        private void mouseLeave(object sender, EventArgs e) {
            Button button = (Button)sender;
            if (button == bConfirm) button.BackColor = Color.Lime;
            else button.BackColor = Color.Red;
        }

        private async void bConfirm_Click(object sender, EventArgs e) {
            if (wrongData()) return;
            Account acc = new Account(new LoginDetails(tEmail.Text, tPass.Text, tAnswer.Text, (rPs3.Checked ? Platform.Ps3 : (rXbox.Checked ? Platform.Xbox360 : Platform.Pc))));
            Form loading = new LoadingForm("Trwa logowanie...");
            loading.Show();
            Hide();
            bool logged = await acc.login();
            loading.Dispose();
            if (logged) {
                login(acc);
                Dispose();
            } else {
                Show();
                System.Windows.Forms.MessageBox.Show("Nie można się zalogować. Spróbuj ponownie.");
            }
        }

        private bool wrongData() {
            if (tEmail.Text == "" || tPass.Text == "" || tAnswer.Text == "") {
                System.Windows.Forms.MessageBox.Show("Wypełnij wszystkie pola.");
                return true;
            } else if (AccManager.account.ContainsKey(tEmail.Text)) {
                System.Windows.Forms.MessageBox.Show("Podany E-mail jest już zalogowany.");
                return true;
            }
            return false;
        }

        void login(Account acc) {
            AccManager.add(tEmail.Text, acc);
            if (cRemem.Checked) SaveManager.saveData();
        }

    }
}
