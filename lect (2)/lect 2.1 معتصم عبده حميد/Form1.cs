using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lect_2._1_معتصم_عبده_حميد
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_sum_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("enter the frit num");

            }
            else if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("enter the second number");
            }
            else
            {
                double x = Convert.ToDouble(textBox1.Text);
                double y = Convert.ToDouble(textBox2.Text);
                double z = x + y;
                textBox3.Text = z.ToString();
            }
        }


        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                btn_sum.Enabled = true;
            }
            else
                btn_sum.Enabled = false;
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                btn_sum.Enabled = true;
            }
            else
                btn_sum.Enabled = false;
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
