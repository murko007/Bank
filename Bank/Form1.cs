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
    public partial class Form1 : Form
    {    Dal dal = new Dal();
        public Form1()
        {
            InitializeComponent();
            //форма загрузилась, загрузились кредитторы и потом можна кликать и лезть в базу

            ArrayList allDebitors=dal.getAlDebitors();
            dvg_Debitors.DataSource = allDebitors;
            
            Settings_Debitors();
        }

        void Settings_Debitors()
        {
            dvg_Debitors.Columns["Id"].Visible = false;
            dvg_Debitors.TopLeftHeaderCell.Value = "#";
        }

        private void dvg_Debitors_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dvg_Debitors.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dvg_Debitors.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dvg_Debitors.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = dvg_Debitors.Rows[e.RowIndex].Cells[3].Value.ToString();

            dvg_credits.DataSource=dal.getAlCredits(dvg_Debitors.CurrentRow.Cells["Id"].Value.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
      {// когда форма загрузилась можем кликать
            //событие...............делегат............................вызываются методы
            //мы подписываемся на событие только когда форма загрузилась
            dvg_Debitors.CellEnter += new DataGridViewCellEventHandler(dvg_Debitors_CellEnter);
            dvg_credits.CellEnter += new DataGridViewCellEventHandler(dvg_credits_CellEnter);
        }

        void dvg_credits_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            string creditorID = dvg_credits.CurrentRow.Cells[0].Value.ToString();
            dgv_payment.DataSource = dal.getAlPayments(creditorID);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Close ?", "Bank", MessageBoxButtons.OKCancel) == DialogResult.OK)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newDebitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewDebitor newDeb = new NewDebitor();
            if (newDeb.ShowDialog() == DialogResult.OK)
                MessageBox.Show("Новый дебитор создан", "Bank", MessageBoxButtons.OK);
            else MessageBox.Show("Новый дебитор не создан", "Bank", MessageBoxButtons.OK);
                dvg_Debitors.DataSource=dal.getAlDebitors();
        }

        private void addNewCreditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewCredit n = new NewCredit();
            if (n.ShowDialog() == DialogResult.OK)
            {
                dvg_credits.DataSource = dal.getAlCredits(dvg_Debitors.CurrentRow.Cells["Id"].Value.ToString());
                MessageBox.Show("Good","Bank",MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("bad", "Bank", MessageBoxButtons.OK);
            }
        }

        private void addNewPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPayment newPayment = new NewPayment();
            if (newPayment.ShowDialog() == DialogResult.OK)
            {
                dvg_credits.DataSource = dal.getAlCredits(dvg_Debitors.CurrentRow.Cells["Id"].Value.ToString());
                MessageBox.Show("Good Payment", "Bank", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("bad Payment", "Bank", MessageBoxButtons.OK);
            }

        }

        private void saveToCVSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dal.DBSaveToCSVLocalFile())
            {
                MessageBox.Show("Данные сохранены в файлах", "Bank",MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show("Данные не сохранены в файлах", "Bank", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        List<DataGridViewRow> searchedRow;
        int currentRow;
        private void btn_search_Click(object sender, EventArgs e)
        {
            searchedRow = new List<DataGridViewRow>();
            string debName = textBox5.Text.Trim();
            string debPost = textBox6.Text.Trim();
            string debPhone = textBox7.Text.Trim();

            if (!checkBox1.Checked)
            {
                foreach (DataGridViewRow row in dvg_Debitors.Rows)
                {
                    if (row.Cells["Name"].Value.ToString().Contains(debName) &&
                    (row.Cells["PostNumber"].Value.ToString().Contains(debPost)) &&
                    (row.Cells["PhoneNumber"].Value.ToString().Contains(debPhone)))
                        searchedRow.Add(row);
                }

                if (searchedRow.Count == 0)
                {
                    MessageBox.Show("Не найдено записей");
                    btn_next.Enabled = false;

                }

                else
                {
                    MessageBox.Show("найдено записей " + searchedRow.Count);
                    btn_next.Enabled = true;
                    currentRow = -1;
                }
            }

            else
            {
               ArrayList searcharr= dal.Search(debName,debPhone,debPhone);
               if (searcharr == null || searcharr.Count == 0)
               {
                   btn_next.Enabled = false;
                   MessageBox.Show("Не найдено записей");
               }

               else
               {
                   MessageBox.Show("найдено записей"+searcharr.Count);
                   dvg_Debitors.DataSource = searcharr;
                   btn_next.Enabled = false;
               }
            }
           


        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (currentRow == searchedRow.Count - 1)
            {
                currentRow = 0;
            }
            else currentRow++;
            // currentRow in searchedRow
            dvg_Debitors.CurrentCell = searchedRow[currentRow].Cells[1]; ;
        }

        
    }
}
