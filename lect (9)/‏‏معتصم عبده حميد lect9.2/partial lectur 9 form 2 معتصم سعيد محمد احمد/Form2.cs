using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace partial_lecture_9_form_2_معتصم_عبده_حميد_يحيى
{
    public partial class Form2 : Form
    {
        //خصائص لتخزين البيانات المعدله
        public  string txtname { get; set; } 
        public string txtage { get; set; }
        public  string txtnum { get; set; }
        public  string radsex { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

       

        private void Form2_Load(object sender, EventArgs e)
        {
        }
       public Form2(string number,string name,string age, string sex)
        {
            InitializeComponent();
            txtnum = number;
            txtname = name;
            txtage = age;
            radsex=sex;
           
            //عرض البيانات في مربعات نصوص
           txt_numberr.Text = txtnum;
            txt_namee.Text = txtname;
            txt_agee.Text = txtage;
            if (radsex == "ذكر")
            {
               radio_malee.Checked = true;  
            }
            else
            {
                radio_wmall.Checked = true;
            }
           

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
           txtnum = txt_numberr.Text;
            txtname = txt_namee.Text;
           txtage=txt_agee.Text;

            if(radio_malee.Checked)
            {
                radsex = "ذكر";
            }
            else
            {
                radsex = "انثى";
            }
           
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }
    }
}
