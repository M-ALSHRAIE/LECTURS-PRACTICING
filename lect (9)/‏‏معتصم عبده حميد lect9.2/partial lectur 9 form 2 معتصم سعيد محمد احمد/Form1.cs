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
    public partial class Form1 : Form
    {
        private string name;
        private string number;
        private string age;
        private string sex;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_number.Text.Trim() != "")
            {
                if(txt_name.Text.Trim()!="")
                {
                    if(txt_age.Text.Trim()!="")
                    {
                        if (radio_male.Checked|| radio_wmal.Checked )
                        {
                            list_name.Items.Add(txt_name.Text);
                            list_age.Items.Add(txt_age.Text);
                            list_number.Items.Add(txt_number.Text);

                            if (radio_male.Checked)
                            {
                                list_six.Items.Add(radio_male.Text);

                            }
                            if(radio_wmal.Checked)
                            {
                                list_six.Items.Add( radio_wmal.Text);
                            }
                            txt_name.Clear();
                            txt_age.Clear();
                            txt_number.Clear();
                            radio_male.Checked = false;
                            radio_wmal.Checked = false;
                        }
                        else
                        { 
                            MessageBox.Show("يرجى اختيار نوع الجنس", "تنبيه");
                            label2.Focus();
                        }
                    
                    }
                    else
                    {
                        MessageBox.Show("يرجى ادخال  العمر", "تنبيه");
                        txt_age.Focus();

                    }

                }
                else
                {
                    MessageBox.Show("يرجى اادخال الاسم", "تنبيه");
                    txt_name.Focus();

                }
            }


            else
            {
                MessageBox.Show("يرجى ادخال الرقم", "تنبيه");
                txt_number.Focus();
            }              
        }

       private void btn_remov_Click(object sender, EventArgs e)
{
    if (list_name.SelectedIndex != -1) // التأكد من وجود عنصر محدد
    {
        int selectedIndex = list_name.SelectedIndex;

        // حذف العنصر المحدد من جميع القوائم
        list_name.Items.RemoveAt(selectedIndex);
        list_age.Items.RemoveAt(selectedIndex);
        list_number.Items.RemoveAt(selectedIndex);
        list_six.Items.RemoveAt(selectedIndex);

        MessageBox.Show("تم حذف بيانات الشخص المحدد بنجاح", "نجاح");
    }
    else
    {
        MessageBox.Show("يرجى تحديد شخص للحذف", "تنبيه");
    }
}


        private void btn_remove_all_Click(object sender, EventArgs e)
        {
            list_age.Items.Clear();
            list_name.Items.Clear();
            list_number.Items.Clear();
            list_six.Items.Clear();
        }
        

        private void txt_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar<48||e.KeyChar>57)&&(e.KeyChar!=8))
            {
                e.Handled = true;
            }
        }

       
       

        private void Form1_Load(object sender, EventArgs e)
        {
            

           
        }
      

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void list_number_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            list_name.SelectedIndex = list_six.SelectedIndex = list_age.SelectedIndex = list_number.SelectedIndex;

        }

        public void list_age_SelectedIndexChanged(object sender, EventArgs e)
        {
            list_name.SelectedIndex = list_number.SelectedIndex = list_six.SelectedIndex = list_age.SelectedIndex;

        }

        private void txt_number_TextChanged(object sender, EventArgs e)
        {
            

        }

        public void list_name_SelectedIndexChanged(object sender, EventArgs e)
        {
          
           list_six.SelectedIndex = list_number.SelectedIndex = list_age.SelectedIndex = list_name.SelectedIndex;

            

        }
        private void selected(object sender,EventArgs e)
        {
           
        }

        public void list_six_SelectedIndexChanged(object sender, EventArgs e)
        {
            list_name.SelectedIndex = list_number.SelectedIndex = list_age.SelectedIndex = list_six.SelectedIndex;
        }

        private void btn_clearselected_Click(object sender, EventArgs e)
        {
            list_age.ClearSelected();
            list_name.ClearSelected();
            list_number.ClearSelected();
            list_six.ClearSelected();

        }

        private void radio_wmal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if(list_name.SelectedIndex !=-1)
            {
                string num=list_number.Items[list_number.SelectedIndex].ToString();
                string name = list_name.Items[list_name.SelectedIndex].ToString();
                string age = list_age.Items[list_age.SelectedIndex] .ToString();
                string sex=list_six.Items[list_six.SelectedIndex] .ToString();

                Form2 f2 = new Form2(num, name, age, sex);
                if(f2.ShowDialog()==DialogResult.OK)
                {
                    list_number.Items[list_number.SelectedIndex] = f2.txtnum;
                    list_name.Items[list_name.SelectedIndex] = f2.txtname;
                    list_age.Items[list_age.SelectedIndex] = f2.txtage;
                    list_six.Items[list_six.SelectedIndex] = f2.radsex;


                }



            }


            
        }
        public Form1(string nu, string na, string ag, string s)
        {
            InitializeComponent();
            name = na;
            age = ag;
            sex = s;
            number= nu;
            number = list_number.Items[list_number.SelectedIndex].ToString();
            name = list_name.Items[list_name.SelectedIndex].ToString();
            age=list_age.Items[list_age.SelectedIndex].ToString();
            sex=list_six.Items[list_six.SelectedIndex].ToString();


        }

    }
}