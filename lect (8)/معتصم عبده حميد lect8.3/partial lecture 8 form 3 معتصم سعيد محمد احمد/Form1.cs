using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace partial_lecture_8_form_3_معتصم_عبده_حميد_يحيى
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_av_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int number;
            if(int.TryParse(txt_add.Text,out number)&&(number>0 &&number<9))
            {
                for(int i=0;i<listBox1.Items.Count;i++)
                {
                   if(txt_add.Text==listBox1.Items[i])
                    {
                        listBox1.Items.Add(txt_add.Text);
                    }
                }
                

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
