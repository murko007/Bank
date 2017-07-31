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
    public partial class NewCredit : Form
    {
        ArrayList allDebitors;
        Dal d = new Dal();
        public NewCredit()
        {
            InitializeComponent();
            textBox1.Text = Guid.NewGuid().ToString();
            allDebitors = d.getAlDebitors();
            if (allDebitors == null || allDebitors.Count == 0)
            {
                tb_creditAmount.Enabled = btn_addcredit.Enabled = false;
            }
            lb_DebitorId.DataSource = allDebitors;
            lb_debitorName.DataSource = allDebitors;
        }

       

        private void tb_creditAmount_TextChanged(object sender, EventArgs e)
        {
            tb_creditAmount.Text = tb_creditAmount.Text.Trim().Replace(" ","");
            tb_creditBalance.Text = tb_creditAmount.Text;
        }

        private void btn_addcredit_Click(object sender, EventArgs e)
        {
            if (d.SaveNewCredit(Guid.Parse(textBox1.Text), Guid.Parse(lb_DebitorId.SelectedValue.ToString()), Int32.Parse(tb_creditAmount.Text),Int32.Parse(tb_creditBalance.Text), dtp_creditopendate.Value))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.No;
            }
        }

        private void tb_creditAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57)&& e.KeyChar !=8)
            {
                e.Handled = true;
            }
        }

        private void tb_creditAmount_Leave(object sender, EventArgs e)
        {
            if (tb_creditAmount.Text == String.Empty || Int32.Parse(tb_creditAmount.Text.Trim()) < 100 || Int32.Parse(tb_creditAmount.Text.Trim()) > 1000)
            {
                lb_textamount.Text = "недопустимое значение";
                lb_textamount.BackColor = Color.Red;
                btn_addcredit.Enabled = false;

            }
        }
    }
}
