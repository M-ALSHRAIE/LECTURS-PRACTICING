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

    public partial class Form2 : Form
    {
        public int num1 { get; set; }
        public int num2 { get; set; }
        public string operation { get; set;  }
        public int result { get; set; }
        public Form2()
        {
            InitializeComponent();

            combo_oper.Items.Add("+");
            combo_oper.Items.Add("-");
            combo_oper.Items.Add("*");
            combo_oper.Items.Add("/");
            combo_oper.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public Form2(int n1, string op, int n2, int res)
        {
            InitializeComponent();
            num1 = n1;
            num2 = n2;
            operation = op;
            result = res;
            txt_num1.Text = num1.ToString();
            txt_num2.Text = num2.ToString();
            combo_oper.Text = op.ToString();
            txt_result.Text = result.ToString();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            combo_oper.Items.Add("+");
            combo_oper.Items.Add("-");
            combo_oper.Items.Add("*");
            combo_oper.Items.Add("/");
            combo_oper.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(txt_num1.Text);
            num2 = int.Parse(txt_num2.Text);
            operation = combo_oper.Text;
            result=int.Parse(txt_result.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();


        }
        public double ope(double n1, double n2, string op)
        {
            switch (op)
            {
                case "+":
                    return n1 + n2;
                case "-":
                    return n1 - n2;
                case "*":
                    return n1 * n2;
                case "/":
                    return n2 != 0 ? n1 / n2 : double.NaN;

                default:
                    return double.NaN;

            }
        }
     

        private void btn_calc_Click_1(object sender, EventArgs e)
        {
            if (txt_num1.Text != "")
            {
                if (combo_oper.SelectedIndex != -1)
                {
                    if (txt_num2.Text != "")
                    {
                        txt_result.Text = ope(Convert.ToDouble(txt_num1.Text), Convert.ToDouble(txt_num2.Text), Convert.ToString(combo_oper.Text)).ToString();

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

        private void txt_num1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
