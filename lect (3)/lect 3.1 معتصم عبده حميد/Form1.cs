using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lect_3._1_معتصم_عبده_حميد
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void checknum(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8) && (e.KeyChar != 45) && (e.KeyChar != 46))
            {
                e.Handled = true;

            }
            if (e.KeyChar == 45 && num1.SelectionStart != 0)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 46 && num1.Text.Contains('.'))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 45 && num1.SelectionStart == 0)
            {
                e.Handled = true;
            }
        }
        private Double operatio(double n1, double n2, string oper)
        {
            if (oper2.Text == "/" )
            {
                
            }
            switch (oper)
            {
                case "+":
                    return n1 + n2;
                case "-":
                    return n1 - n2;
                case "*":
                    return n1 * n2;
                case "/":
                    return n2 != 0 ? n1 / n2 : double.NaN;
                default: return double.NaN;

            }

        }

        private void Math_Click(object sender, EventArgs e)
        {

            double n1, n2, n3;
            string operation1 = oper1.Text;
            string operation2 = oper2.Text;
            string intermediaresult = "";
            string finalresult = "";
            if (double.TryParse(num1.Text, out n1) &&
                double.TryParse(num2.Text, out n2) &&
                double.TryParse(num3.Text, out n3))
            {
                if (oper2.Text == "/")
                {
                    intermediaresult = (Convert.ToDouble(num2.Text) / Convert.ToDouble(num3.Text)).ToString();
                    finalresult = operatio(Convert.ToDouble(intermediaresult), n1, operation1).ToString();
                }
                else if (oper2.Text == "*")
                {
                    intermediaresult = (Convert.ToDouble(num2.Text) * Convert.ToDouble(num3.Text)).ToString();
                    finalresult = operatio(Convert.ToDouble(intermediaresult), n1, operation1).ToString();
                }

                else
                {
                    intermediaresult = operatio(n1, n2, operation1).ToString();
                    if (oper1.Text == "")
                    {
                        MessageBox.Show("the  first operation  non correct");
                        oper1.Focus();
                        return;
                    }

                    finalresult = operatio(Convert.ToDouble(intermediaresult), n3, operation2).ToString();
                    if (oper2.Text == "")
                    {
                        MessageBox.Show("the  second operation  non correct");
                        oper2.Focus();
                        return;
                    }
                }
               
                result.Text = Convert.ToString(finalresult);
            }
            else if (num1.Text == "")
            {
                MessageBox.Show("please enter the  first number ");
                num1.Focus();
            }
            else if (num2.Text == "")
            {
                MessageBox.Show("please enter the  second number");
                num2.Focus();
            }
            else if (num3.Text == "")
            {
                MessageBox.Show("please enter the  thirth number");
                num3.Focus();
            }
            else
            {
                MessageBox.Show("please enter the correct numbers");
                num1.Focus();
            }
            num1.Text = num2.Text = num3.Text = oper1.Text = oper2.Text = null;
        }

        private void Num1_KeyPress(object sender, KeyPressEventArgs e)
        {
            checknum(sender, e);
        }

        private void Num2_KeyPress(object sender, KeyPressEventArgs e)
        {
            checknum(sender, e);
        }

        private void Num3_KeyPress(object sender, KeyPressEventArgs e)
        {
            checknum(sender, e);
        }

        //private void Oper1_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void Oper1_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    chec(sender, e);
        //}

        //private void Oper2_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    ckeckoperation(sender, e);
        //}

        private void Clos_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

