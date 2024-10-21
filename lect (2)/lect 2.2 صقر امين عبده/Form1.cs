using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lect_2._2_معتصم_عبده_حميد
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
            button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = true;
            textBox3.ReadOnly = true;
            this.Text = "sempil calculater";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = (Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text)).ToString();
            textBox3.BackColor = Color.Blue;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = (Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox2.Text)).ToString();
            textBox3.BackColor = Color.Blue;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = (Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text)).ToString();
            textBox3.BackColor = Color.Blue;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
           
                textBox3.Text = (Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text)).ToString();
                textBox3.BackColor = Color.Blue;
            
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            button4.Enabled = button3.Enabled = button2.Enabled = button1.Enabled = (textBox1.Text != "") && (textBox2.Text != "");

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            button4.Enabled = button3.Enabled = button2.Enabled = button1.Enabled = (textBox1.Text != "") && (textBox2.Text != "");

        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar !=8))
                e.Handled = true;
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
                e.Handled = true;
        }
    }
}
