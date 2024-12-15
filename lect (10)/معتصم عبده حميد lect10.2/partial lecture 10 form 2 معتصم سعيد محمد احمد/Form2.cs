using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace partial_lecture_10_form_2_معتصم_عبده_حميد_يحيى
{
    public partial class Form2 : Form
    {
        public static steudent[] s = new steudent[100];
        public static int count = 0;


        public Form2()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        void load_steudent_data()
        {
          
        }
        bool ischoce_imag=false;
        private void btn_add_Click(object sender, EventArgs e)
        {
            if(count<100)
            {
                if(ischoce_imag)
                {
                    s[count]=new steudent();
                    s[count].setnumber(Convert.ToInt32(numericUpDown1.Value));
                    s[count].setname(txt_name_ste.Text);
                    s[count].sitbirthday(data_birthday.Text);
                    s[count].setimagebath(openFileDialog1.FileName);
                    count++;
                    ischoce_imag = false;
                    image_student.Image = null;
                    numericUpDown1.Value = 0;
                    txt_name_ste.Text = "";
                    MessageBox.Show("تم اضافة طالب بنجاح", "نجاح");
                }
                else
                {
                    MessageBox.Show("الرجاء اختيار صورة طالب", "تحذير");
                }
            }
            else
            {
                MessageBox.Show("الحد المسموح به مائة طالب فقط", "تحذير");
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void check_imag_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Images (*.jpg;*.bmp;*.png)|*.jpg;*.bmp;*.png";

            //openFileDialog1.Filter = "img(*.jpg)|*.jpg|(img*.bmp;*.png)|*.bmp;*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                image_student.Image=Image.FromFile(openFileDialog1.FileName);
                ischoce_imag=true;  
            }
        }

        private void txt_name_ste_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
