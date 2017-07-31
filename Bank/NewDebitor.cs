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
    public partial class NewDebitor : Form
    {
        Dal d = new Dal();
        public NewDebitor()
        {
            InitializeComponent();
            textBox1.Text = Guid.NewGuid().ToString();
            


        }

        private void btn_save_new_Debitor_Click(object sender, EventArgs e)
        {
            if(d.SaveNewDebitor(textBox1.Text.Trim(), textBox2.Text.Trim(), textBox3.Text.Trim(), textBox4.Text.Trim()))
                       this.DialogResult = DialogResult.OK;
            else 
            this.DialogResult = DialogResult.Cancel;
            
        }
    }
}
