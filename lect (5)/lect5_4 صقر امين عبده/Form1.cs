using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LECT5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)

        {
            if ((textBox1.Text.Trim() != "") && (textBox2.Text.Trim() != ""))
            {
                textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text));

                  if ((textBox1.Text.Trim() != "") && (textBox2.Text.Trim() != ""))
                {
                    textBox4.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text));
                }

                 if ((textBox1.Text.Trim() != "") && (textBox2.Text.Trim() != ""))
                {
                    textBox5.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text));
                }

                 if ((textBox1.Text.Trim() != "") && (textBox2.Text.Trim() != ""))
                {
                    if (textBox1.Text != "0")
                    {
                        textBox6.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text));
                    }
                }
            }

           
            else
                MessageBox.Show("ادخل الرقم");
        }
    }
}

