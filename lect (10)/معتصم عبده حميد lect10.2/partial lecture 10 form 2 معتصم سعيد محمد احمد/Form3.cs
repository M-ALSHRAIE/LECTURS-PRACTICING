using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace partial_lecture_10_form_2_معتصم_عبده_حميد_يحيى
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            load_steudent_data();
            list_num_ste.SelectedIndexChanged += find_selected_index;
            list_name_ste.SelectedIndexChanged += find_selected_index;
            list_datbirthday_ste.SelectedIndexChanged += find_selected_index;
        }

        public static int index = -1;

        private void find_selected_index(object sender, EventArgs e)
        {
            if (((ListBox)sender).SelectedIndex != -1)
            {
                index = list_num_ste.SelectedIndex = list_name_ste.SelectedIndex = list_datbirthday_ste.SelectedIndex = ((ListBox)sender).SelectedIndex;
                pictureBox1.Image = Image.FromFile(Form2.s[index].getimagpath());
            }
        }

        void load_steudent_data()
        {
            for (int i = 0; i < Form2.count; i++)
            {
                list_num_ste.Items.Add(Form2.s[i].getnumber().ToString());
                list_name_ste.Items.Add(Form2.s[i].getname());
                list_datbirthday_ste.Items.Add(Form2.s[i].getbirthday().ToString());
                pictureBox1.Image = Image.FromFile(Form2.s[i].getimagpath());
            }
        }



        private void btn_clear_Click(object sender, EventArgs e)
        {
            if (list_num_ste.SelectedIndex != -1)
            {
                list_num_ste.Items.RemoveAt(list_num_ste.SelectedIndex);
                list_name_ste.Items.RemoveAt(list_name_ste.SelectedIndex);
                list_datbirthday_ste.Items.RemoveAt(list_datbirthday_ste.SelectedIndex);
                for (int i = index; i < Form2.count - 1; i++)
                {
                    Form2.s[i] = Form2.s[i + 1];
                }
                Form2.count--;

                if (Form2.count >= 1)
                {
                    pictureBox1.Image = Image.FromFile(Form2.s[0].getimagpath());
                    list_num_ste.SelectedIndex = list_name_ste.SelectedIndex = list_datbirthday_ste.SelectedIndex = 0;
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        
        {
           //Form2 form = new Form2(int num,string name,string date,);
           // form.ShowDialog();


            //    if (list_num_ste.SelectedItem != null)
            //    {
            //        Form2 f = new Form2();
            //        f.ShowDialog();
            //        list_num_ste.Items[index] = Form2.s[index].getnumber();
            //        list_name_ste.Items[index] = Form2.s[index].getname();
            //        list_datbirthday_ste.Items[index] = Form2.s[index].getbirthday();
            //        pictureBox1.Image = Image.FromFile(Form2.s[index].getimagpath());
            //    }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            list_num_ste.Items.Clear();
            list_name_ste.Items.Clear();
            list_datbirthday_ste.Items.Clear();
            load_steudent_data();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void list_datbirthday_ste_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}