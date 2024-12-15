using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System
namespace partial_lecture_10_form_2_معتصم_عبده_حميد_يحيى
{
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();
        }
        public string getname()
        {
            return txt_write.Text;
        }
        public void updatename(string name)
        {
            txt_write.Text = name;  
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn_show_dialog_Click(object sender, EventArgs e)
        {
            Form1 f1=new Form1("التعامل مع الواجهات المتعدده");
            f1.ShowDialog();
            f1.Show();

        }

        private void btn_show_function_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            f2.setvalue(txt_write.Text);
            f2.Show();
            

        }
        public Form2(string n)
        {
            updatename(n);
            
            
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            f2.Show();
        }

        private void btn_show_stat_var_Click(object sender, EventArgs e)
        {
            Form1 f1=new Form1();
            Form1.staticvariable=txt_write.Text;
            f1.Show();
        }

        private void btn_show_out_real_obje_Click(object sender, EventArgs e)
        {
            new Form1(txt_write.Text).Show();
        }

        private void btn_show_send_list_Click(object sender, EventArgs e)
        {
            Form1 f=new Form1(listBox1);
            f.Show();
        }

        private void btn_show_send_form_Click(object sender, EventArgs e)
        {
            Form1 f=new Form1(this);
            f.Show();
        }
        Form1 foon=new Form1();
        private void btn_show_once_Click(object sender, EventArgs e)
        {

            foon.Show();
        }
        Form1 form1;
        private void btn_show_formal_obje_Click(object sender, EventArgs e)
        {
            if(form1 == null|| form1.IsDisposed)
            {
                form1 = new Form1();
                form1.Show();
            }
            else
            {
                if(!form1.Visible)
                {
                    form1.Show();
                }
                else
                {
                    form1.BringToFront(); // يجعل النموذج الحالي في مقدمة النوافذ

                }
              
            }

        }

        private void txt_write_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
