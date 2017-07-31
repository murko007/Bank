namespace Bank
{
    partial class NewPayment
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
            this.Refr = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_credit_id = new System.Windows.Forms.ListBox();
            this.lb_creditBalance = new System.Windows.Forms.ListBox();
            this.lb_credit_amount = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_textamount = new System.Windows.Forms.Label();
            this.dtp_payamountdate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_DebitorId = new System.Windows.Forms.ListBox();
            this.lb_debitorName = new System.Windows.Forms.ListBox();
            this.btn_addPayment = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PaymentID = new System.Windows.Forms.Label();
            this.tb_paymentAmount = new System.Windows.Forms.TextBox();
            this.tx_PaymentID = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Refr);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lb_credit_id);
            this.groupBox2.Controls.Add(this.lb_creditBalance);
            this.groupBox2.Controls.Add(this.lb_credit_amount);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lb_textamount);
            this.groupBox2.Controls.Add(this.dtp_payamountdate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lb_DebitorId);
            this.groupBox2.Controls.Add(this.lb_debitorName);
            this.groupBox2.Controls.Add(this.btn_addPayment);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.PaymentID);
            this.groupBox2.Controls.Add(this.tb_paymentAmount);
            this.groupBox2.Controls.Add(this.tx_PaymentID);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(569, 407);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CreditsDeteils";
            // 
            // Refr
            // 
            this.Refr.Location = new System.Drawing.Point(290, 298);
            this.Refr.Name = "Refr";
            this.Refr.Size = new System.Drawing.Size(75, 23);
            this.Refr.TabIndex = 19;
            this.Refr.Text = "Refresh";
            this.Refr.UseVisualStyleBackColor = true;
            this.Refr.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(409, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "label4";
            // 
            // lb_credit_id
            // 
            this.lb_credit_id.DisplayMember = "Idddd";
            this.lb_credit_id.FormattingEnabled = true;
            this.lb_credit_id.Location = new System.Drawing.Point(115, 157);
            this.lb_credit_id.Name = "lb_credit_id";
            this.lb_credit_id.Size = new System.Drawing.Size(145, 108);
            this.lb_credit_id.TabIndex = 17;
            this.lb_credit_id.ValueMember = "Idddd";
            this.lb_credit_id.SelectedIndexChanged += new System.EventHandler(this.lb_Debitor_SelectedIndexChanged);
            // 
            // lb_creditBalance
            // 
            this.lb_creditBalance.DisplayMember = "Balance";
            this.lb_creditBalance.FormattingEnabled = true;
            this.lb_creditBalance.Location = new System.Drawing.Point(381, 157);
            this.lb_creditBalance.Name = "lb_creditBalance";
            this.lb_creditBalance.Size = new System.Drawing.Size(98, 108);
            this.lb_creditBalance.TabIndex = 16;
            this.lb_creditBalance.ValueMember = "Balance";
            // 
            // lb_credit_amount
            // 
            this.lb_credit_amount.DisplayMember = "Name";
            this.lb_credit_amount.FormattingEnabled = true;
            this.lb_credit_amount.Location = new System.Drawing.Point(266, 157);
            this.lb_credit_amount.Name = "lb_credit_amount";
            this.lb_credit_amount.Size = new System.Drawing.Size(109, 108);
            this.lb_credit_amount.TabIndex = 15;
            this.lb_credit_amount.ValueMember = "Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Creditor";
            // 
            // lb_textamount
            // 
            this.lb_textamount.AutoSize = true;
            this.lb_textamount.Location = new System.Drawing.Point(225, 164);
            this.lb_textamount.Name = "lb_textamount";
            this.lb_textamount.Size = new System.Drawing.Size(0, 13);
            this.lb_textamount.TabIndex = 13;
            // 
            // dtp_payamountdate
            // 
            this.dtp_payamountdate.Location = new System.Drawing.Point(175, 343);
            this.dtp_payamountdate.Name = "dtp_payamountdate";
            this.dtp_payamountdate.Size = new System.Drawing.Size(200, 20);
            this.dtp_payamountdate.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Date";
            // 
            // lb_DebitorId
            // 
            this.lb_DebitorId.DisplayMember = "Id";
            this.lb_DebitorId.FormattingEnabled = true;
            this.lb_DebitorId.Location = new System.Drawing.Point(115, 43);
            this.lb_DebitorId.Name = "lb_DebitorId";
            this.lb_DebitorId.Size = new System.Drawing.Size(145, 108);
            this.lb_DebitorId.TabIndex = 10;
            this.lb_DebitorId.ValueMember = "Id";
            this.lb_DebitorId.SelectedIndexChanged += new System.EventHandler(this.lb_Debitor_SelectedIndexChanged);
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
            this.lb_debitorName.SelectedIndexChanged += new System.EventHandler(this.lb_Debitor_SelectedIndexChanged);
            // 
            // btn_addPayment
            // 
            this.btn_addPayment.Location = new System.Drawing.Point(6, 378);
            this.btn_addPayment.Name = "btn_addPayment";
            this.btn_addPayment.Size = new System.Drawing.Size(369, 23);
            this.btn_addPayment.TabIndex = 8;
            this.btn_addPayment.Text = "Add Payment";
            this.btn_addPayment.UseVisualStyleBackColor = true;
            this.btn_addPayment.Click += new System.EventHandler(this.btn_addPayment_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = " Amount";
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
            // PaymentID
            // 
            this.PaymentID.AutoSize = true;
            this.PaymentID.Location = new System.Drawing.Point(10, 23);
            this.PaymentID.Name = "PaymentID";
            this.PaymentID.Size = new System.Drawing.Size(59, 13);
            this.PaymentID.TabIndex = 4;
            this.PaymentID.Text = "PaymentID";
            // 
            // tb_paymentAmount
            // 
            this.tb_paymentAmount.Location = new System.Drawing.Point(175, 300);
            this.tb_paymentAmount.Name = "tb_paymentAmount";
            this.tb_paymentAmount.Size = new System.Drawing.Size(109, 20);
            this.tb_paymentAmount.TabIndex = 2;
            this.tb_paymentAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_paymentAmount_KeyPress);
            this.tb_paymentAmount.Leave += new System.EventHandler(this.tb_paymentAmount_Leave);
            // 
            // tx_PaymentID
            // 
            this.tx_PaymentID.Location = new System.Drawing.Point(115, 16);
            this.tx_PaymentID.Name = "tx_PaymentID";
            this.tx_PaymentID.ReadOnly = true;
            this.tx_PaymentID.Size = new System.Drawing.Size(260, 20);
            this.tx_PaymentID.TabIndex = 0;
            // 
            // NewPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 431);
            this.Controls.Add(this.groupBox2);
            this.Name = "NewPayment";
            this.Text = "NewPayment";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lb_credit_id;
        private System.Windows.Forms.ListBox lb_creditBalance;
        private System.Windows.Forms.ListBox lb_credit_amount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_textamount;
        private System.Windows.Forms.DateTimePicker dtp_payamountdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lb_DebitorId;
        private System.Windows.Forms.ListBox lb_debitorName;
        private System.Windows.Forms.Button btn_addPayment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PaymentID;
        private System.Windows.Forms.TextBox tb_paymentAmount;
        private System.Windows.Forms.TextBox tx_PaymentID;
        private System.Windows.Forms.Button Refr;
    }
}