namespace FUT_Bot {
    partial class LoginForm {
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
            this.lLog = new System.Windows.Forms.Label();
            this.lEmail = new System.Windows.Forms.Label();
            this.lPass = new System.Windows.Forms.Label();
            this.lAnswer = new System.Windows.Forms.Label();
            this.bConfirm = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.rXbox = new System.Windows.Forms.RadioButton();
            this.rPc = new System.Windows.Forms.RadioButton();
            this.rPs3 = new System.Windows.Forms.RadioButton();
            this.tEmail = new System.Windows.Forms.TextBox();
            this.tPass = new System.Windows.Forms.TextBox();
            this.tAnswer = new System.Windows.Forms.TextBox();
            this.lPlatf = new System.Windows.Forms.Label();
            this.cRemem = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lLog
            // 
            this.lLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lLog.Location = new System.Drawing.Point(-2, 9);
            this.lLog.Name = "lLog";
            this.lLog.Size = new System.Drawing.Size(368, 35);
            this.lLog.TabIndex = 0;
            this.lLog.Text = "Zaloguj się";
            this.lLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Location = new System.Drawing.Point(32, 59);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(38, 13);
            this.lEmail.TabIndex = 1;
            this.lEmail.Text = "E-mail:";
            // 
            // lPass
            // 
            this.lPass.AutoSize = true;
            this.lPass.Location = new System.Drawing.Point(32, 86);
            this.lPass.Name = "lPass";
            this.lPass.Size = new System.Drawing.Size(39, 13);
            this.lPass.TabIndex = 2;
            this.lPass.Text = "Hasło:";
            // 
            // lAnswer
            // 
            this.lAnswer.AutoSize = true;
            this.lAnswer.Location = new System.Drawing.Point(32, 113);
            this.lAnswer.Name = "lAnswer";
            this.lAnswer.Size = new System.Drawing.Size(63, 13);
            this.lAnswer.TabIndex = 3;
            this.lAnswer.Text = "Odpowiedź:";
            // 
            // bConfirm
            // 
            this.bConfirm.BackColor = System.Drawing.Color.Lime;
            this.bConfirm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bConfirm.Location = new System.Drawing.Point(35, 256);
            this.bConfirm.Name = "bConfirm";
            this.bConfirm.Size = new System.Drawing.Size(75, 23);
            this.bConfirm.TabIndex = 4;
            this.bConfirm.Text = "Potwierdź";
            this.bConfirm.UseVisualStyleBackColor = false;
            this.bConfirm.Click += new System.EventHandler(this.bConfirm_Click);
            this.bConfirm.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.bConfirm.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.Color.Red;
            this.bCancel.Location = new System.Drawing.Point(116, 256);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(74, 23);
            this.bCancel.TabIndex = 5;
            this.bCancel.Text = "Anuluj";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            this.bCancel.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.bCancel.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // rXbox
            // 
            this.rXbox.AutoSize = true;
            this.rXbox.Location = new System.Drawing.Point(98, 172);
            this.rXbox.Name = "rXbox";
            this.rXbox.Size = new System.Drawing.Size(103, 17);
            this.rXbox.TabIndex = 6;
            this.rXbox.TabStop = true;
            this.rXbox.Text = "XBOX 360/ONE";
            this.rXbox.UseVisualStyleBackColor = true;
            // 
            // rPc
            // 
            this.rPc.AutoSize = true;
            this.rPc.Location = new System.Drawing.Point(98, 195);
            this.rPc.Name = "rPc";
            this.rPc.Size = new System.Drawing.Size(39, 17);
            this.rPc.TabIndex = 7;
            this.rPc.TabStop = true;
            this.rPc.Text = "PC";
            this.rPc.UseVisualStyleBackColor = true;
            // 
            // rPs3
            // 
            this.rPs3.AutoSize = true;
            this.rPs3.Checked = true;
            this.rPs3.Location = new System.Drawing.Point(98, 149);
            this.rPs3.Name = "rPs3";
            this.rPs3.Size = new System.Drawing.Size(70, 17);
            this.rPs3.TabIndex = 8;
            this.rPs3.TabStop = true;
            this.rPs3.Text = "PS3/PS4";
            this.rPs3.UseVisualStyleBackColor = true;
            // 
            // tEmail
            // 
            this.tEmail.Location = new System.Drawing.Point(98, 59);
            this.tEmail.Name = "tEmail";
            this.tEmail.Size = new System.Drawing.Size(154, 20);
            this.tEmail.TabIndex = 9;
            // 
            // tPass
            // 
            this.tPass.Location = new System.Drawing.Point(98, 85);
            this.tPass.Name = "tPass";
            this.tPass.PasswordChar = '*';
            this.tPass.Size = new System.Drawing.Size(154, 20);
            this.tPass.TabIndex = 10;
            // 
            // tAnswer
            // 
            this.tAnswer.Location = new System.Drawing.Point(98, 112);
            this.tAnswer.Name = "tAnswer";
            this.tAnswer.Size = new System.Drawing.Size(154, 20);
            this.tAnswer.TabIndex = 11;
            // 
            // lPlatf
            // 
            this.lPlatf.AutoSize = true;
            this.lPlatf.Location = new System.Drawing.Point(35, 149);
            this.lPlatf.Name = "lPlatf";
            this.lPlatf.Size = new System.Drawing.Size(54, 13);
            this.lPlatf.TabIndex = 12;
            this.lPlatf.Text = "Platforma:";
            // 
            // cRemem
            // 
            this.cRemem.AutoSize = true;
            this.cRemem.Checked = true;
            this.cRemem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cRemem.Location = new System.Drawing.Point(38, 219);
            this.cRemem.Name = "cRemem";
            this.cRemem.Size = new System.Drawing.Size(108, 17);
            this.cRemem.TabIndex = 13;
            this.cRemem.Text = "Zapamiętaj konto";
            this.cRemem.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 291);
            this.Controls.Add(this.cRemem);
            this.Controls.Add(this.lPlatf);
            this.Controls.Add(this.tAnswer);
            this.Controls.Add(this.tPass);
            this.Controls.Add(this.tEmail);
            this.Controls.Add(this.rPs3);
            this.Controls.Add(this.rPc);
            this.Controls.Add(this.rXbox);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bConfirm);
            this.Controls.Add(this.lAnswer);
            this.Controls.Add(this.lPass);
            this.Controls.Add(this.lEmail);
            this.Controls.Add(this.lLog);
            this.Name = "LoginForm";
            this.Text = "Ekran logowania";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lLog;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.Label lPass;
        private System.Windows.Forms.Label lAnswer;
        private System.Windows.Forms.Button bConfirm;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.RadioButton rXbox;
        private System.Windows.Forms.RadioButton rPc;
        private System.Windows.Forms.RadioButton rPs3;
        private System.Windows.Forms.TextBox tEmail;
        private System.Windows.Forms.TextBox tPass;
        private System.Windows.Forms.TextBox tAnswer;
        private System.Windows.Forms.Label lPlatf;
        private System.Windows.Forms.CheckBox cRemem;
    }
}

