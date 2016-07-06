namespace FUT_Bot.FIFA_API {
    partial class AddCardForm {
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.comboName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bConfirm = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.numSell = new System.Windows.Forms.NumericUpDown();
            this.numBuy = new System.Windows.Forms.NumericUpDown();
            this.checkedList = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numSell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBuy)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dodaj kartę na koncie do licytowania ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboType
            // 
            this.comboType.FormattingEnabled = true;
            this.comboType.Items.AddRange(new object[] {
            "Zawodnicy",
            "Kontrakty"});
            this.comboType.Location = new System.Drawing.Point(15, 69);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(143, 21);
            this.comboType.TabIndex = 1;
            this.comboType.TextChanged += new System.EventHandler(this.comboType_TextChanged);
            // 
            // comboName
            // 
            this.comboName.FormattingEnabled = true;
            this.comboName.Location = new System.Drawing.Point(183, 69);
            this.comboName.Name = "comboName";
            this.comboName.Size = new System.Drawing.Size(241, 21);
            this.comboName.Sorted = true;
            this.comboName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Typ karty:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nazwa karty:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cena licytacji:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cena sprzedaży:";
            // 
            // bConfirm
            // 
            this.bConfirm.Location = new System.Drawing.Point(271, 243);
            this.bConfirm.Name = "bConfirm";
            this.bConfirm.Size = new System.Drawing.Size(75, 23);
            this.bConfirm.TabIndex = 9;
            this.bConfirm.Text = "Potwierdź ";
            this.bConfirm.UseVisualStyleBackColor = true;
            this.bConfirm.Click += new System.EventHandler(this.bConfirm_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(352, 243);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 10;
            this.bCancel.Text = "Anuluj";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // numSell
            // 
            this.numSell.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numSell.Location = new System.Drawing.Point(183, 118);
            this.numSell.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numSell.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numSell.Name = "numSell";
            this.numSell.Size = new System.Drawing.Size(101, 20);
            this.numSell.TabIndex = 11;
            this.numSell.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // numBuy
            // 
            this.numBuy.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numBuy.Location = new System.Drawing.Point(15, 118);
            this.numBuy.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numBuy.Minimum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numBuy.Name = "numBuy";
            this.numBuy.Size = new System.Drawing.Size(84, 20);
            this.numBuy.TabIndex = 12;
            this.numBuy.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // checkedList
            // 
            this.checkedList.FormattingEnabled = true;
            this.checkedList.Location = new System.Drawing.Point(15, 172);
            this.checkedList.Name = "checkedList";
            this.checkedList.Size = new System.Drawing.Size(234, 94);
            this.checkedList.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Konta dla karty:";
            // 
            // AddCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 285);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkedList);
            this.Controls.Add(this.numBuy);
            this.Controls.Add(this.numSell);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bConfirm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboName);
            this.Controls.Add(this.comboType);
            this.Controls.Add(this.label1);
            this.Name = "AddCardForm";
            this.Text = "Dodaj kartę ";
            ((System.ComponentModel.ISupportInitialize)(this.numSell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBuy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.ComboBox comboName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bConfirm;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.NumericUpDown numSell;
        private System.Windows.Forms.NumericUpDown numBuy;
        private System.Windows.Forms.CheckedListBox checkedList;
        private System.Windows.Forms.Label label6;
    }
}