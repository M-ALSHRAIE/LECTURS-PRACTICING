using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lect_4._3_معتصم_عبده_حميد
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Location = new Point(textBox1.Left, textBox1.Top - 5);
            textBox1.Top -= 5;
        }

        private void BTN_UP_ADD_Click(object sender, EventArgs e)
        {
            textBox1.Size = new Size(textBox1.Width, textBox1.Height + 5);
            textBox1.Height += 5;
        }

        private void BTN_DWN_MIN_Click(object sender, EventArgs e)
        {
            textBox1.Size = new Size(textBox1.Width, textBox1.Height - 5);
            textBox1.Height -= 5;
        }

        private void BTN_DOWN_Click(object sender, EventArgs e)
        {
            textBox1.Location = new Point(textBox1.Left, textBox1.Top + 5);
        }

        private void BTN_RHT_Click(object sender, EventArgs e)
        {
            textBox1.Location = new Point(textBox1.Left+5,textBox1.Top);
            textBox1.Left +=5;
        }

        private void BTN_RHT_ADD_Click(object sender, EventArgs e)
        {
            textBox1.Size = new Size(textBox1.Width +5,textBox1.Height);
            textBox1.Width+= 5;
        }

        private void BTN_LFT_MIN_Click(object sender, EventArgs e)
        {
            textBox1.Size = new Size(textBox1.Width - 5, textBox1.Height);
            textBox1.Width -= 5;
        }

        private void BTN_LFT_Click(object sender, EventArgs e)
        {
            textBox1.Location = new Point(textBox1.Left- 5, textBox1.Top);
        //  textBox1.Right -= 5;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
                for(int i=0; i<Top; i++)
                {
                    if (checkBox5.Checked)
                        textBox1.Top -= Convert.ToInt16(checkBox5.Text);
                    else if (checkBox10.Checked)
                        textBox1.Top -= Convert.ToInt32(checkBox10.Text);
                    else if (checkBox15.Checked)
                        textBox1.Top -= Convert.ToInt32(checkBox15.Text);
                    else if (checkBox20.Checked)
                        textBox1.Top -= Convert.ToInt32(checkBox20.Text);
                    for (int j = 0; j < 100000000; j++) ;

                }
            else 
                if (radioButton2.Checked)
                for (int i = 0; i<Top; i++)
                {
                    if (checkBox5.Checked)
                        textBox1.Top += Convert.ToInt32(checkBox5.Text);
                    else if (checkBox10.Checked)
                        textBox1.Top += Convert.ToInt32(checkBox10.Text);
                    else if (checkBox15.Checked)
                        textBox1.Top += Convert.ToInt32(checkBox15.Text);
                    else if (checkBox20.Checked)
                        textBox1.Top += Convert.ToInt32(checkBox20.Text);
                    for (int j = 0; j < 10; j++) ;
                }
        }
    }
}
