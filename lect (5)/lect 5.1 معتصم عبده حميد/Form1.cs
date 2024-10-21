using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lect_5._1_معتصم_عبده_حميد
{
    public partial class lect_5_1 : Form
    {
        public lect_5_1()
        {
            InitializeComponent();
        }

        private void Btn_count_Click(object sender, EventArgs e)
        {
            int s = 0; bool f = false;
            textBox1.Text = null;
            if (checkBox1.Checked == true)
            {
                s += Convert.ToInt32(checkBox1.Checked == true); f = true;
            }
            if (checkBox2.Checked)
            {
                s += Convert.ToInt32(checkBox2.Text); f = true;
            }
            if (checkBox3.Checked)
            {
                s += Convert.ToInt32(checkBox3.Checked == true); f = true;
            }
            if (checkBox4.Checked)
            {
                s += Convert.ToInt32(checkBox4.Checked == true); f = true;
            }
            if (checkBox5.Checked)
            {
                s += Convert.ToInt32(checkBox5.Checked == true); f = true;
            }
            if (f)
                textBox1.Text = s.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (radioButton8_red.Checked == true)
                label1.BackColor = Color.Red;
            else if (radioButton_yellow.Checked == true)
                label1.BackColor = Color.Yellow;
            else if (radioButton_green.Checked == true)
                label1.BackColor = Color.Green;
            else if (radioButton_black.Checked == true)
                label1.BackColor = Color.Black;
            //.............................................
            if (radioButton1.Checked)
                label1.ForeColor = Color.Red;
            else if (radioButton2.Checked)
                label1.ForeColor = Color.Yellow;
            else if (radioButton3.Checked)
                label1.ForeColor = Color.Green;
            else if (radioButton4.Checked)
                label1.ForeColor = Color.Black;

        }

        private void Btnenabld_Click(object sender, EventArgs e)
        {
            panelbacolor.Enabled = true;
        }

        private void Btnunabld_Click(object sender, EventArgs e)
        {
            panelbacolor.Enabled = false;
        }

        private void Btnvisibl_Click(object sender, EventArgs e)
        {
            panelbacolor.Visible = true;
        }

        private void Btnunvisibl_Click(object sender, EventArgs e)
        {
            panelbacolor.Visible = false;
        }
    }

  

}

