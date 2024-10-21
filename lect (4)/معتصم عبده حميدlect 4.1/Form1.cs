using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lect_4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("مرحبا بك", "انقر على الواجهه لالوان مختلفه", MessageBoxButtons.OKCancel);
            this.CenterToParent();
            listBox1.Text = "معتصم الشراعي"+"\r\n";

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            this.BackColor = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")

                textBox1.BackColor = Color.Gold;
            else
                textBox1.BackColor = Color.White;
        }

        private void Button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor= Color.White;
            button1.BackColor = Color.Green;
        }

        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
             button1.BackColor = Color.Gray;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("god by");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() !="" )
            {
                listBox1.Text += textBox1.Text + "\r\n".ToString();
                textBox1.Focus();
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("خطا في مربع النص");
                textBox1.Focus();
                textBox1.Clear();
            }
        }
    }
}
