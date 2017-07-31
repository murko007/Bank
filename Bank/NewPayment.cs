using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Bank
{
    public partial class NewPayment : Form
    {
        Dal d = new Dal();
        ArrayList allDebitors;
        ArrayList allCredits;
        
        public NewPayment()
        {
            InitializeComponent();
            tx_PaymentID.Text = Guid.NewGuid().ToString();
            allDebitors = d.getAlDebitors();
            lb_DebitorId.DataSource = allDebitors;
            lb_debitorName.DataSource = allDebitors;
            if (allDebitors == null || allDebitors.Count == 0)
            {
                btn_addPayment.Enabled = false;
                tb_paymentAmount.Enabled = false;
            }
            else
            {
                btn_addPayment.Enabled = true;
                tb_paymentAmount.Enabled = true;
            }
        }

        private void lb_Debitor_SelectedIndexChanged(object sender, EventArgs e)
        {
            allCredits = d.getAlCredits(lb_DebitorId.SelectedValue.ToString());
            lb_credit_id.DataSource = allCredits;
            if (allCredits == null || allCredits.Count == 0)
            {
                btn_addPayment.Enabled = false;
                tb_paymentAmount.Enabled = false;
            }
            else
            {
                btn_addPayment.Enabled = true;
                tb_paymentAmount.Enabled = true;
            }
           
            lb_credit_amount.DataSource = allCredits;
            lb_creditBalance.DataSource = allCredits;
            lb_credit_id.DisplayMember = "Id";
            lb_credit_id.ValueMember="Idddd";
            lb_credit_amount.DisplayMember = "Amount";
            lb_credit_amount.ValueMember = "Id";
            lb_creditBalance.DisplayMember = "Balance";
            lb_creditBalance.ValueMember = "Balance";
        }

        private void tb_paymentAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
            {
                if (tb_paymentAmount.Text.Trim().Contains(",") || tb_paymentAmount.Text==String.Empty)
                {
                    e.Handled = true;
                    return;
                }
                else
                {
                    e.Handled = false;
                    return;
                }
            }
            short res;
            if (Int16.TryParse(e.KeyChar.ToString(), out res))
                e.Handled = false;
            else e.Handled = true;
        }

        private void tb_paymentAmount_Leave(object sender, EventArgs e)
        {
            if (tb_paymentAmount.Text.Trim() == String.Empty)
            {
                label4.Text = "Summa no";
                label4.ForeColor = Color.Red;
                btn_addPayment.Enabled = false;
                return;
                
            }
            decimal PayValue = decimal.Parse(tb_paymentAmount.Text);

             
            if (PayValue<100 || PayValue>decimal.Parse(lb_creditBalance.SelectedValue.ToString()))
            {
                label4.Text = "no";
                label4.ForeColor = Color.Red;
                btn_addPayment.Enabled = false;
               

            }
            else
            {
                label4.Text = "yes";
                label4.ForeColor = Color.Green; ;
                btn_addPayment.Enabled = true;
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            tb_paymentAmount.Clear();
        }

        private void btn_addPayment_Click(object sender, EventArgs e)
        {
            decimal payamount;
            if (!decimal.TryParse(tb_paymentAmount.Text.Trim(), out payamount))
            {
                MessageBox.Show("Неверно указана сумма платежа");
                return;
            }
            if (d.SaveNewPayment(new Guid(tx_PaymentID.Text.Trim()), new Guid(lb_credit_id.SelectedValue.ToString()), payamount, dtp_payamountdate.Value))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.No;
            }
        }

       /* private void NewPayment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankDataSet.Payment' table. You can move, or remove it, as needed.
            this.paymentTableAdapter.Fill(this.bankDataSet.Payment);

        }*/
    }
}
