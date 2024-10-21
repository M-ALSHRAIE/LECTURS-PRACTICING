using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lect_2._3_معتصم_عبده_حميد
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.TextChanged += TextBox2_TextChanged;
            btn_sum.Enabled = btn_min.Enabled = btn_mult.Enabled = btn_div.Enabled = true;
            textBox3.ReadOnly = true;
            this.Text = "sempil calculater";
        }

        private void Btn_sum_Click(object sender, EventArgs e)
        {
            textBox3.Text = (Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text)).ToString();
        }

        private void Btn_min_Click(object sender, EventArgs e)
        {
            textBox3.Text = (Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox2.Text)).ToString();
        }

       
        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            btn_div.Enabled = btn_mult.Enabled = btn_min.Enabled = btn_sum.Enabled = (textBox1.Text != "") && (textBox2.Text != "");
            textBox1.TextChanged += TextBox2_TextChanged;
        }

        private void Btn_del_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
                e.Handled = true;
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
                e.Handled = true;
        }
    }
}
