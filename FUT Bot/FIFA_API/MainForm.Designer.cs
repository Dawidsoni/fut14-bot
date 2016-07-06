namespace FUT_Bot.FIFA_API {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.bAddAcc = new System.Windows.Forms.Button();
            this.comboAcc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lCoins = new System.Windows.Forms.Label();
            this.listTrans = new System.Windows.Forms.ListBox();
            this.lTradeMax = new System.Windows.Forms.Label();
            this.listCards = new System.Windows.Forms.ListBox();
            this.lTradeSize = new System.Windows.Forms.Label();
            this.listLogger = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bAddCard = new System.Windows.Forms.Button();
            this.bLogOut = new System.Windows.Forms.Button();
            this.bDelCard = new System.Windows.Forms.Button();
            this.bChangeCard = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lEmail = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lPlatf = new System.Windows.Forms.Label();
            this.bStats = new System.Windows.Forms.Button();
            this.lCurWatch = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bAddAcc
            // 
            this.bAddAcc.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bAddAcc.Location = new System.Drawing.Point(309, 62);
            this.bAddAcc.Name = "bAddAcc";
            this.bAddAcc.Size = new System.Drawing.Size(75, 23);
            this.bAddAcc.TabIndex = 1;
            this.bAddAcc.Text = "Dodaj konto";
            this.bAddAcc.UseVisualStyleBackColor = false;
            this.bAddAcc.Click += new System.EventHandler(this.bAddAcc_Click);
            this.bAddAcc.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.bAddAcc.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // comboAcc
            // 
            this.comboAcc.FormattingEnabled = true;
            this.comboAcc.Location = new System.Drawing.Point(123, 64);
            this.comboAcc.Name = "comboAcc";
            this.comboAcc.Size = new System.Drawing.Size(180, 21);
            this.comboAcc.TabIndex = 2;
            this.comboAcc.TextChanged += new System.EventHandler(this.comboAcc_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(-3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(789, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fifa Ultimate Team Bot";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wybierz konto:";
            // 
            // lCoins
            // 
            this.lCoins.AutoSize = true;
            this.lCoins.Location = new System.Drawing.Point(3, 46);
            this.lCoins.Name = "lCoins";
            this.lCoins.Size = new System.Drawing.Size(81, 13);
            this.lCoins.TabIndex = 5;
            this.lCoins.Text = "Liczba coins: ...";
            // 
            // listTrans
            // 
            this.listTrans.BackColor = System.Drawing.SystemColors.Info;
            this.listTrans.FormattingEnabled = true;
            this.listTrans.Location = new System.Drawing.Point(111, 311);
            this.listTrans.Name = "listTrans";
            this.listTrans.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listTrans.Size = new System.Drawing.Size(522, 121);
            this.listTrans.TabIndex = 18;
            // 
            // lTradeMax
            // 
            this.lTradeMax.AutoSize = true;
            this.lTradeMax.Location = new System.Drawing.Point(4, 113);
            this.lTradeMax.Name = "lTradeMax";
            this.lTradeMax.Size = new System.Drawing.Size(111, 13);
            this.lTradeMax.TabIndex = 9;
            this.lTradeMax.Text = "Rozmiar Trade Pile: ...";
            // 
            // listCards
            // 
            this.listCards.BackColor = System.Drawing.SystemColors.Info;
            this.listCards.FormattingEnabled = true;
            this.listCards.Location = new System.Drawing.Point(153, 21);
            this.listCards.Name = "listCards";
            this.listCards.Size = new System.Drawing.Size(471, 95);
            this.listCards.TabIndex = 16;
            // 
            // lTradeSize
            // 
            this.lTradeSize.AutoSize = true;
            this.lTradeSize.Location = new System.Drawing.Point(3, 69);
            this.lTradeSize.Name = "lTradeSize";
            this.lTradeSize.Size = new System.Drawing.Size(135, 13);
            this.lTradeSize.TabIndex = 10;
            this.lTradeSize.Text = "Przedmioty w Trade Pile: ...";
            // 
            // listLogger
            // 
            this.listLogger.BackColor = System.Drawing.SystemColors.Info;
            this.listLogger.FormattingEnabled = true;
            this.listLogger.Location = new System.Drawing.Point(111, 164);
            this.listLogger.Name = "listLogger";
            this.listLogger.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listLogger.Size = new System.Drawing.Size(522, 121);
            this.listLogger.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(153, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(471, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Licytowane karty";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bAddCard
            // 
            this.bAddCard.BackColor = System.Drawing.Color.Lime;
            this.bAddCard.Location = new System.Drawing.Point(248, 122);
            this.bAddCard.Name = "bAddCard";
            this.bAddCard.Size = new System.Drawing.Size(75, 23);
            this.bAddCard.TabIndex = 15;
            this.bAddCard.Text = "Dodaj";
            this.bAddCard.UseVisualStyleBackColor = false;
            this.bAddCard.Click += new System.EventHandler(this.bAddCard_Click);
            this.bAddCard.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.bAddCard.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // bLogOut
            // 
            this.bLogOut.BackColor = System.Drawing.Color.Red;
            this.bLogOut.Location = new System.Drawing.Point(630, 12);
            this.bLogOut.Name = "bLogOut";
            this.bLogOut.Size = new System.Drawing.Size(75, 23);
            this.bLogOut.TabIndex = 12;
            this.bLogOut.Text = "Wyloguj";
            this.bLogOut.UseVisualStyleBackColor = false;
            this.bLogOut.Click += new System.EventHandler(this.bLogOut_Click);
            this.bLogOut.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.bLogOut.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // bDelCard
            // 
            this.bDelCard.BackColor = System.Drawing.Color.Red;
            this.bDelCard.Location = new System.Drawing.Point(468, 122);
            this.bDelCard.Name = "bDelCard";
            this.bDelCard.Size = new System.Drawing.Size(75, 23);
            this.bDelCard.TabIndex = 14;
            this.bDelCard.Text = "Usuń";
            this.bDelCard.UseVisualStyleBackColor = false;
            this.bDelCard.Click += new System.EventHandler(this.bDelCard_Click);
            this.bDelCard.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.bDelCard.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // bChangeCard
            // 
            this.bChangeCard.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bChangeCard.Location = new System.Drawing.Point(365, 122);
            this.bChangeCard.Name = "bChangeCard";
            this.bChangeCard.Size = new System.Drawing.Size(67, 23);
            this.bChangeCard.TabIndex = 13;
            this.bChangeCard.Text = "Zmień";
            this.bChangeCard.UseVisualStyleBackColor = false;
            this.bChangeCard.Click += new System.EventHandler(this.bChangeCard_Click);
            this.bChangeCard.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.bChangeCard.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(217, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(297, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Historia operacji";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(214, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(297, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Historia transakcji";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Location = new System.Drawing.Point(3, 22);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(50, 13);
            this.lEmail.TabIndex = 6;
            this.lEmail.Text = "E-mail: ...";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.lCurWatch);
            this.panel1.Controls.Add(this.lPlatf);
            this.panel1.Controls.Add(this.lEmail);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.listLogger);
            this.panel1.Controls.Add(this.bDelCard);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.bChangeCard);
            this.panel1.Controls.Add(this.listTrans);
            this.panel1.Controls.Add(this.lTradeSize);
            this.panel1.Controls.Add(this.lTradeMax);
            this.panel1.Controls.Add(this.lCoins);
            this.panel1.Controls.Add(this.bAddCard);
            this.panel1.Controls.Add(this.bLogOut);
            this.panel1.Controls.Add(this.listCards);
            this.panel1.Location = new System.Drawing.Point(34, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 441);
            this.panel1.TabIndex = 20;
            // 
            // lPlatf
            // 
            this.lPlatf.AutoSize = true;
            this.lPlatf.Location = new System.Drawing.Point(4, 132);
            this.lPlatf.Name = "lPlatf";
            this.lPlatf.Size = new System.Drawing.Size(66, 13);
            this.lPlatf.TabIndex = 19;
            this.lPlatf.Text = "Platforma: ...";
            // 
            // bStats
            // 
            this.bStats.Location = new System.Drawing.Point(399, 62);
            this.bStats.Name = "bStats";
            this.bStats.Size = new System.Drawing.Size(75, 23);
            this.bStats.TabIndex = 21;
            this.bStats.Text = "Statystyki";
            this.bStats.UseVisualStyleBackColor = true;
            this.bStats.Click += new System.EventHandler(this.bStats_Click);
            // 
            // lCurWatch
            // 
            this.lCurWatch.AutoSize = true;
            this.lCurWatch.Location = new System.Drawing.Point(4, 91);
            this.lCurWatch.Name = "lCurWatch";
            this.lCurWatch.Size = new System.Drawing.Size(143, 13);
            this.lCurWatch.TabIndex = 20;
            this.lCurWatch.Text = "Obserwowane przedmioty: ...";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.bStats);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboAcc);
            this.Controls.Add(this.bAddAcc);
            this.Name = "MainForm";
            this.Text = "FUT BOT";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAddAcc;
        private System.Windows.Forms.ComboBox comboAcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lCoins;
        public System.Windows.Forms.ListBox listTrans;
        private System.Windows.Forms.Label lTradeMax;
        public System.Windows.Forms.ListBox listCards;
        private System.Windows.Forms.Label lTradeSize;
        public System.Windows.Forms.ListBox listLogger;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bAddCard;
        private System.Windows.Forms.Button bLogOut;
        private System.Windows.Forms.Button bDelCard;
        private System.Windows.Forms.Button bChangeCard;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bStats;
        private System.Windows.Forms.Label lPlatf;
        private System.Windows.Forms.Label lCurWatch;
    }
}