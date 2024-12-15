using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace partial_lecture_9_form_1_معتصم_عبده_حميد_يحيى
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            Height = groupBox1.Top + 40;
            Random rand=new Random();
            for (int i=0;i<5;i++)
            {
                int n = rand.Next(100);
                listBox1.Items.Add(n);
            }
        }
        //لتحقق من ان المدخل رقما
        bool isnumeric(string elem)
        {
            if (elem == " ") return false;
            for (int i = 0; i < elem.Length; i++)
            {
                if (elem[i] < 48 || elem[i] >57)
                    return false;
            }
            return true;

        }
        //اتحقق من تكرار العناصر
        bool repeated(ListBox l,string s)
        {
            for (int i = 0;i < l.Items.Count;i++)
            {
                if (l.Items[i].ToString() == s)
                    return true;
            }
            return false;
        }
      //  تفغيل وعد تفعيل
       
     //   عكس عناصر القائمه
        void revers(ListBox lis)
        {
            for (int i=lis.Items.Count-1;i>=0;i--)
            {
                lis.Items.Add(lis.Items[i]);
                lis.Items.Remove(lis.Items[i]);
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_write_add.Text != "")
            {
                if (isnumeric(txt_write_add.Text.Trim()))
                {
                    if (!repeated(listBox1, txt_write_add.Text))
                    {
                        listBox1.Items.Add(txt_write_add.Text);
                        txt_write_add.Clear();
                        txt_write_add.Focus();

                    }
                    else
                    {
                        MessageBox.Show("الرقم موجود"); txt_write_add.Clear();
                        txt_write_add.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("يجب ان  يكون الرقم المدخل رقما");
                    txt_write_add.Clear();
                    txt_write_add.Focus();

                }
            }
            else
            {
                MessageBox.Show("لا يوجد رقم في حقل الادخال", "تنبيه");
            }


        }

        private void btn_add_check_Click(object sender, EventArgs e)
        {

            //if (listBox1.SelectedItem != null)
            //{
            //    int x = listBox1.SelectedIndex;
            //    int v = listBox1.SelectedItems.Count;
            //    for (int i = 0; i < v; i++)
            //    {
            //        if (!repeated(listBox2, listBox1.SelectedItems[0].ToString()))
            //        {
            //            listBox2.Items.Add(listBox1.Items[x]);
            //            listBox1.Items.RemoveAt(x);
            //        }
            //    }
            //}
            //بشكل معكوس 
            while(listBox1.SelectedItems.Count>0)
            {
                listBox2.Items.Add(listBox1.SelectedItems[listBox1.SelectedItems.Count - 1]);
                listBox1.Items.Remove(listBox1.SelectedItems[listBox1.SelectedItems.Count - 1]);
            }
            //else
            //{
            //    MessageBox.Show("يرجى تحديد عناصر في القائمه", "تنبيه");
            //}
           
        }
       
        private void btn_add_all_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count>0)
            {
                int c = listBox1.Items.Count;
                for (int i = 0; i < c; i++)
                {
                    if (!repeated(listBox2, listBox1.Items[0].ToString()))
                    {
                        listBox2.Items.Add(listBox1.Items[0]);
                        listBox1.Items.Remove(listBox1.Items[0]);
                    }
                }
            }
            else
            {
                MessageBox.Show("يرجى ادخال عناصر الى القائمه", "تنبيه");
            }
        }

        private void btn_show_shap_Click(object sender, EventArgs e)
        {
            if(btn_show_shap.Text=="v")
            {
                Height = btn_close.Top +btn_close.Height+ 50;
                btn_show_shap.Text = "^";
            }
            else
            {
                btn_show_shap.Text = "v";
                Height = groupBox1.Top + 40;
            }
        }

       
        private void rad_even_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;
            if(rad_even.Checked)
            {
                bool foundeven = false;
                for (int i = 0; i <listBox1.Items.Count; i++)
                {
                    if (Convert.ToInt32(listBox1.Items[i]) % 2 == 0)
                    {
                        listBox1.SetSelected(i, true);
                        foundeven = true;
                    }
                }
                     if(!foundeven)
                    {
                        MessageBox.Show("لا توجد عناصر زوجيه");
                    }
                
            }
        }

        private void rad_odd_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;
            if (rad_odd.Checked)
            {
                bool foundodd = false;
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    if (Convert.ToInt32(listBox1.Items[i]) % 2 != 0)
                    {
                        listBox1.SetSelected(i, true);
                        foundodd = true;
                    }

                }
                if(!foundodd)
                    {
                        MessageBox.Show("لا توجد عناصر فرديه");
                    }
                
            }

        }

        private void rad_order_all_descen_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Sorted = true;
        }
        private void sortanylist(ListBox lis)
        {
            int t;
            int c = lis.Items.Count;
            for(int i=0;i<c;i++)
            {
                for(int j=0;j<c;j++)
                {
                    int n1=Convert.ToInt32(lis.Items[i]),
                        n2=Convert.ToInt32(lis.Items[j]);
                    if(n1<n2)
                    {
                        t = n1;
                        lis.Items[i] = n2;
                        lis.Items[j] = t;
                    }
                }
            }
        }

        private void rad_trans_item_reverc_CheckedChanged(object sender, EventArgs e)
        {
            int n=listBox1.Items.Count;
            for(int i=0;i<n;i++)
            {
                listBox2.Items.Add(listBox1.Items.Count-1);
                listBox1.Items.Remove(listBox1.Items[listBox1.Items.Count - 1]);

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void red_revers_item_CheckedChanged(object sender, EventArgs e)
        {
            revers(listBox1);
        }

        private void rad_prim_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;
            
            if(rad_prim.Checked)
            {
                bool foundprim = false;
                for (int i=0;i<listBox1.Items.Count;++i)
                {
                    int n = Convert.ToInt32(listBox1.Items[i]);
                     bool  ispream = true;
                    if (n<=1)ispream = false;
                    for (int j = 2; j < n; j++)
                    {
                        if (n % j == 0)
                        {
                            ispream = false;
                            break;
                        }
                    }
                        if(ispream==true)
                        {
                            listBox1.SelectedIndex=i;
                            foundprim = true;
                            break;

                        }
                                    }
                if (!foundprim)
                {
                    MessageBox.Show("لا توجد عناصر اوليه");
                }
            }
           
            
        }

        private void btn_clear_item_shaded_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }

        }

        private void rad_reverc_items_list2_CheckedChanged(object sender, EventArgs e)
        {
            revers(listBox2);
        }

        private void rad_order_item_all_desce_list2_CheckedChanged(object sender, EventArgs e)
        {
            sortanylist(listBox2);
        }

        private void btn_shaded_on_item_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox2.Items.Count; i++)
            { 

            if (txt_shaded_on_item.Text == listBox1.Items[i].ToString())
                {
                    listBox1.SelectedIndex = i;
                }
             }




            listBox1.SelectedItems.Remove(txt_shaded_on_item.Text);
        }

        private void btn_count_items_shaded_Click(object sender, EventArgs e)
        {
            txt_count_items_shaded.Text=listBox1.SelectedItems.Count.ToString();
        }

        private void btn_count_items_noy_shaded_Click(object sender, EventArgs e)
        {
           txt_count_item_not_shaded.Text=(listBox1.Items.Count-listBox1.SelectedItems.Count).ToString();
        }

        private void rad_shade_on_all_items_CheckedChanged(object sender, EventArgs e)
        {
            if(listBox1.Items.Count>0)
            {
                for(int i=0;i<listBox1.Items.Count;i++)
                {
                    listBox1.SelectedIndex=i;
                }
            }
            else
            {
                MessageBox.Show("not found element");
            }
        }

        private void rad_remo_shade_on_all_items_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;
        }

        private void txt_write_add_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar <48||e.KeyChar>57)&&(e.KeyChar!=8))
            {
                e.Handled=true;
            }
        }

        private void btn_count_items_Click(object sender, EventArgs e)
        {
            txt_count_items.Text=listBox1.Items.Count.ToString();
        }

        private void btn_clear_item_shaded_list2_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex!=-1)
            {
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }
        }

        private void btn_clear_all_lis1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btn_clear_all_list2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_write_add_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_remov_shaded_on_item_Click(object sender, EventArgs e)
        {

        }
    }
}
