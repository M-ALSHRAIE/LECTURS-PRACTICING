using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lect_5._4_معتصم_عبده_حميد
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = panel2.Visible = panel3.Visible = panel4.Visible = false;
            panel1.Location = panel2.Location = panel3.Location = panel4.Location = new Point(1, 60);




            button11.Click += Button6_Click;
            button9.Click += Button6_Click;
            button7.Click += Button6_Click;

            textBox1.KeyPress += TextBox3_KeyPress;
            textBox2.KeyPress += TextBox3_KeyPress;
            textBox3.KeyPress += TextBox3_KeyPress;
            textBox4.KeyPress += TextBox3_KeyPress;
            textBox5.KeyPress += TextBox3_KeyPress;
            textBox6.KeyPress += TextBox3_KeyPress;
            textBox7.KeyPress += TextBox3_KeyPress;
            textBox8.KeyPress += TextBox3_KeyPress;
            textBox9.KeyPress += TextBox3_KeyPress;
            textBox10.KeyPress += TextBox3_KeyPress;
            textBox11.KeyPress += TextBox3_KeyPress;
            textBox12.KeyPress += TextBox3_KeyPress;

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Form1_Load(null, null);
        }

        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != 8))
                e.Handled = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            Height = panel2.Height * 2;

        }

        private void Button2_Click(object sender, EventArgs e)
        {

            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
            Height = panel2.Height * 2;

        }

        private void Button3_Click(object sender, EventArgs e)
        {

            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;
            Height = panel2.Height * 2;
        }

        private void Button4_Click(object sender, EventArgs e)
        {

            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            Height = panel2.Height * 2;
        }
       

        private void Button5_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text.Trim() != "") && (textBox2.Text.Trim() != ""))
            {
                textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text));
            }
            else
                MessageBox.Show("ادخل الرقم");
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if ((textBox4.Text.Trim() != "") && (textBox5.Text.Trim() != ""))
            {
                textBox4.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text));
            }
            else
                MessageBox.Show("ادخل الرقم");
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            if ((textBox7.Text.Trim() != "") && (textBox7.Text.Trim() != ""))
            {
                textBox5.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text));
            }
            else
                MessageBox.Show("ادخل الرقم");
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            if((textBox10.Text.Trim()!="" ) && (textBox11.Text.Trim()!=""))
            {
                if (textBox1.Text != "0" )
                {
                    textBox6.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text));
                }
                else
                    MessageBox.Show("ادخل الرقم");
            }
        }
    }
}
