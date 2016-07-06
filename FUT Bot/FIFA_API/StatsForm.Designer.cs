namespace FUT_Bot.FIFA_API {
    partial class StatsForm {
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lTitle = new System.Windows.Forms.Label();
            this.lAcc = new System.Windows.Forms.Label();
            this.lCoins = new System.Windows.Forms.Label();
            this.lCurTrade = new System.Windows.Forms.Label();
            this.lMaxTrade = new System.Windows.Forms.Label();
            this.lCurWatch = new System.Windows.Forms.Label();
            this.comboAcc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboFromDate = new System.Windows.Forms.ComboBox();
            this.comboToDate = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // lTitle
            // 
            this.lTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lTitle.Location = new System.Drawing.Point(-3, 9);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(564, 30);
            this.lTitle.TabIndex = 0;
            this.lTitle.Text = "Statystyki kont";
            this.lTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lAcc
            // 
            this.lAcc.AutoSize = true;
            this.lAcc.Location = new System.Drawing.Point(12, 51);
            this.lAcc.Name = "lAcc";
            this.lAcc.Size = new System.Drawing.Size(107, 13);
            this.lAcc.TabIndex = 1;
            this.lAcc.Text = "Zalogowanych kont: ";
            // 
            // lCoins
            // 
            this.lCoins.AutoSize = true;
            this.lCoins.Location = new System.Drawing.Point(12, 74);
            this.lCoins.Name = "lCoins";
            this.lCoins.Size = new System.Drawing.Size(72, 13);
            this.lCoins.TabIndex = 2;
            this.lCoins.Text = "Liczba coins: ";
            // 
            // lCurTrade
            // 
            this.lCurTrade.AutoSize = true;
            this.lCurTrade.Location = new System.Drawing.Point(12, 96);
            this.lCurTrade.Name = "lCurTrade";
            this.lCurTrade.Size = new System.Drawing.Size(126, 13);
            this.lCurTrade.TabIndex = 3;
            this.lCurTrade.Text = "Przedmioty w Trade Pile: ";
            // 
            // lMaxTrade
            // 
            this.lMaxTrade.AutoSize = true;
            this.lMaxTrade.Location = new System.Drawing.Point(12, 118);
            this.lMaxTrade.Name = "lMaxTrade";
            this.lMaxTrade.Size = new System.Drawing.Size(158, 13);
            this.lMaxTrade.TabIndex = 4;
            this.lMaxTrade.Text = "Maksymalny rozmiar Trade Pile: ";
            // 
            // lCurWatch
            // 
            this.lCurWatch.AutoSize = true;
            this.lCurWatch.Location = new System.Drawing.Point(12, 140);
            this.lCurWatch.Name = "lCurWatch";
            this.lCurWatch.Size = new System.Drawing.Size(134, 13);
            this.lCurWatch.TabIndex = 6;
            this.lCurWatch.Text = "Obserwowane przedmioty: ";
            // 
            // comboAcc
            // 
            this.comboAcc.FormattingEnabled = true;
            this.comboAcc.Items.AddRange(new object[] {
            "Wszystkie konta"});
            this.comboAcc.Location = new System.Drawing.Point(197, 67);
            this.comboAcc.Name = "comboAcc";
            this.comboAcc.Size = new System.Drawing.Size(188, 21);
            this.comboAcc.TabIndex = 7;
            this.comboAcc.SelectedIndexChanged += new System.EventHandler(this.comboAcc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Wykres konta:";
            // 
            // chart
            // 
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(197, 96);
            this.chart.Name = "chart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Seria";
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(408, 252);
            this.chart.TabIndex = 9;
            this.chart.Text = "Wykres ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Od daty:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(498, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Do daty:";
            // 
            // comboFromDate
            // 
            this.comboFromDate.FormattingEnabled = true;
            this.comboFromDate.Location = new System.Drawing.Point(391, 66);
            this.comboFromDate.Name = "comboFromDate";
            this.comboFromDate.Size = new System.Drawing.Size(104, 21);
            this.comboFromDate.TabIndex = 16;
            this.comboFromDate.SelectedIndexChanged += new System.EventHandler(this.combo_SelectedIndexChanged);
            // 
            // comboToDate
            // 
            this.comboToDate.FormattingEnabled = true;
            this.comboToDate.Location = new System.Drawing.Point(501, 66);
            this.comboToDate.Name = "comboToDate";
            this.comboToDate.Size = new System.Drawing.Size(104, 21);
            this.comboToDate.TabIndex = 18;
            this.comboToDate.SelectedIndexChanged += new System.EventHandler(this.combo_SelectedIndexChanged);
            // 
            // StatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 373);
            this.Controls.Add(this.comboToDate);
            this.Controls.Add(this.comboFromDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboAcc);
            this.Controls.Add(this.lCurWatch);
            this.Controls.Add(this.lMaxTrade);
            this.Controls.Add(this.lCurTrade);
            this.Controls.Add(this.lCoins);
            this.Controls.Add(this.lAcc);
            this.Controls.Add(this.lTitle);
            this.Name = "StatsForm";
            this.Text = "Statystyki kont";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Label lAcc;
        private System.Windows.Forms.Label lCoins;
        private System.Windows.Forms.Label lCurTrade;
        private System.Windows.Forms.Label lMaxTrade;
        private System.Windows.Forms.Label lCurWatch;
        private System.Windows.Forms.ComboBox comboAcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboFromDate;
        private System.Windows.Forms.ComboBox comboToDate;

    }
}