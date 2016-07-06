namespace FUT_Bot.FIFA_API {
    partial class ChangeCardForm {
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
            this.bConfirm = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.lName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numBuy = new System.Windows.Forms.NumericUpDown();
            this.numSell = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.checkedList = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numBuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSell)).BeginInit();
            this.SuspendLayout();
            // 
            // bConfirm
            // 
            this.bConfirm.Location = new System.Drawing.Point(39, 286);
            this.bConfirm.Name = "bConfirm";
            this.bConfirm.Size = new System.Drawing.Size(75, 23);
            this.bConfirm.TabIndex = 0;
            this.bConfirm.Text = "Akceptuj";
            this.bConfirm.UseVisualStyleBackColor = true;
            this.bConfirm.Click += new System.EventHandler(this.bConfirm_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(158, 286);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 1;
            this.bCancel.Text = "Anuluj";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // lName
            // 
            this.lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lName.Location = new System.Drawing.Point(1, 9);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(308, 30);
            this.lName.TabIndex = 0;
            this.lName.Text = "Zmień dane karty";
            this.lName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(40, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cena licytacji:";
            // 
            // numBuy
            // 
            this.numBuy.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numBuy.Location = new System.Drawing.Point(138, 50);
            this.numBuy.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numBuy.Minimum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numBuy.Name = "numBuy";
            this.numBuy.Size = new System.Drawing.Size(69, 20);
            this.numBuy.TabIndex = 0;
            this.numBuy.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // numSell
            // 
            this.numSell.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numSell.Location = new System.Drawing.Point(138, 80);
            this.numSell.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numSell.Minimum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numSell.Name = "numSell";
            this.numSell.Size = new System.Drawing.Size(69, 20);
            this.numSell.TabIndex = 0;
            this.numSell.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(40, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cena sprzedaży: ";
            // 
            // checkedList
            // 
            this.checkedList.FormattingEnabled = true;
            this.checkedList.Location = new System.Drawing.Point(39, 138);
            this.checkedList.Name = "checkedList";
            this.checkedList.Size = new System.Drawing.Size(194, 124);
            this.checkedList.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Zmiana dla kont:";
            // 
            // ChangeCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 339);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numSell);
            this.Controls.Add(this.numBuy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bConfirm);
            this.Name = "ChangeCardForm";
            this.Text = "Zmiana danych karty";
            ((System.ComponentModel.ISupportInitialize)(this.numBuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSell)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bConfirm;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numBuy;
        private System.Windows.Forms.NumericUpDown numSell;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox checkedList;
        private System.Windows.Forms.Label label1;
    }
}