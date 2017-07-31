namespace Bank
{
    partial class NewCredit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_textamount = new System.Windows.Forms.Label();
            this.dtp_creditopendate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_DebitorId = new System.Windows.Forms.ListBox();
            this.lb_debitorName = new System.Windows.Forms.ListBox();
            this.btn_addcredit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_creditBalance = new System.Windows.Forms.TextBox();
            this.tb_creditAmount = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_textamount);
            this.groupBox2.Controls.Add(this.dtp_creditopendate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lb_DebitorId);
            this.groupBox2.Controls.Add(this.lb_debitorName);
            this.groupBox2.Controls.Add(this.btn_addcredit);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tb_creditBalance);
            this.groupBox2.Controls.Add(this.tb_creditAmount);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 283);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CreditsDeteils";
            // 
            // lb_textamount
            // 
            this.lb_textamount.AutoSize = true;
            this.lb_textamount.Location = new System.Drawing.Point(225, 164);
            this.lb_textamount.Name = "lb_textamount";
            this.lb_textamount.Size = new System.Drawing.Size(0, 13);
            this.lb_textamount.TabIndex = 13;
            // 
            // dtp_creditopendate
            // 
            this.dtp_creditopendate.Location = new System.Drawing.Point(175, 209);
            this.dtp_creditopendate.Name = "dtp_creditopendate";
            this.dtp_creditopendate.Size = new System.Drawing.Size(200, 20);
            this.dtp_creditopendate.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Date";
            // 
            // lb_DebitorId
            // 
            this.lb_DebitorId.DisplayMember = "Id";
            this.lb_DebitorId.FormattingEnabled = true;
            this.lb_DebitorId.Location = new System.Drawing.Point(151, 43);
            this.lb_DebitorId.Name = "lb_DebitorId";
            this.lb_DebitorId.Size = new System.Drawing.Size(109, 108);
            this.lb_DebitorId.TabIndex = 10;
            this.lb_DebitorId.ValueMember = "Id";
            // 
            // lb_debitorName
            // 
            this.lb_debitorName.DisplayMember = "Name";
            this.lb_debitorName.FormattingEnabled = true;
            this.lb_debitorName.Location = new System.Drawing.Point(266, 43);
            this.lb_debitorName.Name = "lb_debitorName";
            this.lb_debitorName.Size = new System.Drawing.Size(109, 108);
            this.lb_debitorName.TabIndex = 9;
            this.lb_debitorName.ValueMember = "Id";
            // 
            // btn_addcredit
            // 
            this.btn_addcredit.Location = new System.Drawing.Point(6, 254);
            this.btn_addcredit.Name = "btn_addcredit";
            this.btn_addcredit.Size = new System.Drawing.Size(369, 23);
            this.btn_addcredit.TabIndex = 8;
            this.btn_addcredit.Text = "Add Credit";
            this.btn_addcredit.UseVisualStyleBackColor = true;
            this.btn_addcredit.Click += new System.EventHandler(this.btn_addcredit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Credit Balance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Credit Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Debitor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "CreditID";
            // 
            // tb_creditBalance
            // 
            this.tb_creditBalance.Location = new System.Drawing.Point(266, 183);
            this.tb_creditBalance.Name = "tb_creditBalance";
            this.tb_creditBalance.Size = new System.Drawing.Size(109, 20);
            this.tb_creditBalance.TabIndex = 3;
            // 
            // tb_creditAmount
            // 
            this.tb_creditAmount.Location = new System.Drawing.Point(266, 157);
            this.tb_creditAmount.Name = "tb_creditAmount";
            this.tb_creditAmount.Size = new System.Drawing.Size(109, 20);
            this.tb_creditAmount.TabIndex = 2;
            this.tb_creditAmount.TextChanged += new System.EventHandler(this.tb_creditAmount_TextChanged);
            this.tb_creditAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_creditAmount_KeyPress);
            this.tb_creditAmount.Leave += new System.EventHandler(this.tb_creditAmount_Leave);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(260, 20);
            this.textBox1.TabIndex = 0;
            // 
            // NewCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 297);
            this.Controls.Add(this.groupBox2);
            this.Name = "NewCredit";
            this.Text = "NewCredit";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtp_creditopendate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lb_DebitorId;
        private System.Windows.Forms.ListBox lb_debitorName;
        private System.Windows.Forms.Button btn_addcredit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_creditBalance;
        private System.Windows.Forms.TextBox tb_creditAmount;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lb_textamount;
    }
}