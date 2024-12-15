using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespacepartial_lecture_9_form_3_معتصم_عبده_حميد_يحيى
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
            combo_oper.Items.Add("+");
            combo_oper.Items.Add("-");
            combo_oper.Items.Add("*");
            combo_oper.Items.Add("/");
            combo_oper.DropDownStyle=ComboBoxStyle.DropDownList;
        }
        public double operation(double n1,double n2,string op)
        {
            switch(op)
            {
                case "+":
                    return n1 + n2;
                    case"-":
                    return n1 - n2;
                    case "*":
                    return n1 * n2;
                    case "/":
                    return n2 != 0 ? n1 / n2 : double.NaN;

                default:
                    return double.NaN;
                        
            }
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            if(txt_num1.Text!="")
            {
                if(combo_oper.SelectedIndex != -1)
                {
                    if(txt_num2.Text !="")
                    {
                        txt_result.Text = operation(Convert.ToDouble(txt_num1.Text), Convert.ToDouble(txt_num2.Text), Convert.ToString(combo_oper.Text)).ToString();

                    }
                    else
                    {
                        MessageBox.Show("يرجى ادخال الرقم الثاني", "تنبيه");
                        txt_num2.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("يرجى اختيار العمليه ", "تنبيه");
                    combo_oper.Focus();
                }
            }
            else
            {
                MessageBox.Show("يرجى ادخال الرقم الاول", "تنبيه");
                txt_num1.Focus();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void txt_num1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar<48||e.KeyChar>57)&&(e.KeyChar!=8))
            {
                e.Handled = true;
            }

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(txt_num1.Text !="")
            {
                if(combo_oper.SelectedIndex != -1)
                {
                    if(txt_num2.Text !="")
                    {
                        list_num1.Items.Add(txt_num1.Text);
                        list_oper.Items.Add(combo_oper.Text);
                        list_num2.Items.Add(txt_num2.Text);
                        list_result.Items.Add(txt_result.Text);
                        txt_num1.Text = "";
                        txt_num2.Text = "";
                        txt_result.Text = "";
                        combo_oper.SelectedIndex = -1;

                    }
                    else
                    {
                        MessageBox.Show("يرجى ردخال الرقم الثاني", "تنبيه");
                        txt_num2.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("يرجى اختيار  عمليه   ", "تنبيه");
                }
            }
            else
            {
                MessageBox.Show("يرجى ردخال الرقم الاول", "تنبيه");
                txt_num1.Focus();
            }

        }

        private void list_num1_SelectedIndexChanged(object sender, EventArgs e)
        {
            list_num2.SelectedIndex = list_oper.SelectedIndex = list_result.SelectedIndex = list_num1.SelectedIndex;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            if(list_num1.SelectedIndex !=-1)
            {
                int selected = list_num1.SelectedIndex;

                list_num1.Items.RemoveAt(selected);
                list_num2.Items.RemoveAt(selected);
                list_oper.Items.RemoveAt(selected);
                list_result.Items.RemoveAt(selected);
               

            }
            else
            {
                MessageBox.Show("يرجى تحديد عمليه للحذف", "تنبيه");
            }

        }

        private void list_oper_SelectedIndexChanged(object sender, EventArgs e)
        {
            list_num1.SelectedIndex = list_num2.SelectedIndex = list_result.SelectedIndex = list_oper.SelectedIndex;
        }

        private void list_num2_SelectedIndexChanged(object sender, EventArgs e)
        {
            list_num1.SelectedIndex = list_oper.SelectedIndex = list_result.SelectedIndex = list_num2.SelectedIndex;

        }

        private void list_result_SelectedIndexChanged(object sender, EventArgs e)
        {
            list_num1.SelectedIndex = list_num2.SelectedIndex = list_oper.SelectedIndex = list_result.SelectedIndex;
        }

        private void btn_clear_all_Click(object sender, EventArgs e)
        {

            list_num1.Items.Clear();
            list_num2.Items.Clear();
            list_oper.Items.Clear();
            list_result.Items.Clear();
            txt_num1.Clear();
            txt_num2.Clear();
            txt_result.Clear();
            combo_oper.SelectedIndex = -1;
        }

        private void btn_clear_check_Click(object sender, EventArgs e)
        {
            if (list_num1.SelectedIndex != -1)
            {
                list_num1.ClearSelected();
                list_num2.ClearSelected();

                list_oper.ClearSelected();
                list_result.ClearSelected();
            }
            else
            {
                MessageBox.Show("يرجى نظليل عمليه", "تنبيه");
            }

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if(list_num1.SelectedIndex != -1)
            {
                int n1 = Convert.ToInt32(list_num1.Items[list_num1.SelectedIndex]);
                string op =  list_oper.Items[list_oper.SelectedIndex].ToString();
                int n2 = Convert.ToInt32(list_num2.Items[list_num2.SelectedIndex]);
                int re =Convert.ToInt32(list_result.Items[list_result.SelectedIndex]);



                Form2 f2 = new Form2(n1,op,n2,re);
                if(f2.ShowDialog()==DialogResult.OK)
                {
                    list_num1.Items[list_num1.SelectedIndex] = f2.num1;
                    list_oper.Items[list_oper.SelectedIndex] = f2.operation;
                    list_num2.Items[list_num2.SelectedIndex] = f2.num2;
                   list_result.Items[list_result.SelectedIndex] = f2.result;

                }

            }
          
            else
            {
                MessageBox.Show("يرجى تحديد عمليه لتعديلها   ", "تنبيه");
            }


        }
    }
}
