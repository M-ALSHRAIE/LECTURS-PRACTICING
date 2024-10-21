using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lect_4._2_معتصم_عبده_حميد
{
    public partial class Form1 : Form
    {
        string[] a;
        int m = 0, i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            textBox2.Enabled = btn_add.Enabled = btn_vew.Enabled = btn_sum.Enabled
              = listBox1.Enabled = textBox3.Enabled = false;
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() != "")
            {
                if (i < m)
                {
                    a[i++] = textBox2.Text.ToString();
                    textBox2.Focus();
                    textBox2.Clear();
                }
                else
                {
                    MessageBox.Show("تجاوزت حجم المصفوفة");

                }
            }
            else
            {
                MessageBox.Show("ادخل الرقم");
            }
           
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
                e.Handled = true;
            if (e.KeyChar == 8)
                e.Handled = false;
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
            {
                m = int.Parse(textBox1.Text);
                a = new string[m];i = 0;
            }
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
                e.Handled = true;
            if (e.KeyChar == 8)
                e.Handled = false;
            listBox1.Items.Clear(); textBox3.Text = "";
        }

        private void Btn_del_Click(object sender, EventArgs e)
        {
            int s = 0;
            if (listBox1.Items.Count > 0)
            {
                for (int h = 0; h < i; h++)
                {
                    s += int.Parse(a[h]);
                }
                textBox3.Text = s.ToString();
            }
            else
                MessageBox.Show("القائمه فارغه");

            //listBox1.Items.Clear();
            //if (i > 0)
            //{
            //    for (int h = 0; h < i; h++)
            //    {
            //        listBox1.Items.Add(a[h]);
            //    }
            //}
            //else
            //    MessageBox.Show("المصفوفة فارغة");
        }

        private void Btn_vew_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (i > 0)
            {
                for (int h = 0; h < i; h++)
                {
                    listBox1.Items.Add(a[h]);
                }
            }
            else
                MessageBox.Show("المصفوفة فارغة");
            //int s = 0;
            //if (listBox1.Items.Count > 0)
            //{
            //    for (int h = 0; h < i; h++)
            //    {
            //        s += int.Parse(a[h]);
            //    }
            //    textBox1.Text = s.ToString();
            //}
            //else
            //    MessageBox.Show("القائمه فارغه");
        }

        private void Btn_sum_Click(object sender, EventArgs e)
        {
            int b = listBox1.Items.Count;
            if (b > 0)
            {
                for (int h = 1; h <= b; h++)
                    listBox1.Items.Remove(listBox1.Items[0]);
                i = m = 0;
                a = new string[0];
                textBox2.Text = textBox1.Text = textBox3.Text = "";
                Form1_Load(null,null);
            }
            else
                MessageBox.Show("القائمة قارغة");
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            bool f = (textBox1.Text != "");
            textBox2.Enabled = btn_add.Enabled = btn_vew.Enabled = btn_sum.Enabled
             = listBox1.Enabled = textBox3.Enabled = f;

        }
        }

        //private void TextBox1_keypress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar < 48 || e.KeyChar > 57)
        //        e.Handled = true;
        //    if (e.KeyChar == 8)
        //        e.Handled = false;
        //}




    }

