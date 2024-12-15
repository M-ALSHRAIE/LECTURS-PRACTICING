using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace معتصم_عبده_حميد_الشراعي
{
    public partial class Form2 : Form
    {
        
        public static Class1[] d = new Class1[20];
        public static int count = 0;
        
       

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "مرحبا  :معتصم عبده حميد  " + Form1.lable;
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(txtbox1.Text=="")
            {
                MessageBox.Show(" ادخل رقم في الخانه المجاوره");
            }

            else
            {
                //زوجي

                if (Convert.ToInt32(txtbox1.Text) % 2 == 0)
                {
                    listBox1.Items.Add(txtbox1.Text);
                    
                }

                //اولي
                for (int i = 2; i < Convert.ToInt32(txtbox1.Text) / 2; i++)
                {
                    listBox2.Items.Add(txtbox1.Text);
                }
               
                //فردي

                if (Convert.ToInt32(txtbox1.Text) % 2 != 0)
                {
                    listBox3.Items.Add(txtbox1.Text);
                }

               

            if(count<20)
                {
                    d[count] = new Class1();
                    d[count].setnumber(Convert.ToInt32(txtbox1.Text));
                    count++;
                    txtbox1.Text = "";
                    MessageBox.Show("تمت الاظافة بنجاح");
                }
            }





        }

        Form4 f4;
        private void Button4_Click(object sender, EventArgs e)
        {
            f4 = new Form4();
            f4.Show();
        }

        Form3 f3;
        private void Button3_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem!=null || listBox2.SelectedItem!=null || listBox3.SelectedItem!=null)
            {
                f3 = new Form3();
                f3.Show();
            }
            else
            {
                MessageBox.Show("اختر عنصر من القوائم السابقة");
            }
           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
                listBox3.Items.Remove(listBox3.SelectedItem);
            }
            else
            {
                MessageBox.Show("يرجى تاكيد الحذف");
            }
           
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txtbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                if (e.KeyChar < 48 || e.KeyChar > 57)
                    e.Handled = true;
                if (e.KeyChar == 8)
                    e.Handled = false;
            
        }
    }
}
