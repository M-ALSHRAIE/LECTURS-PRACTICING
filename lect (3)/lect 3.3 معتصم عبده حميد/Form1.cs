using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lect_3._3_معتصم_عبده_حميد
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

                if (int.TryParse(textBox1.Text, out int number))
                {
                    //int sum = number + number;
                    //label1.Text = sum.ToString();

                int summation = 1;
                for (int i = 2; i <= number; i++)
                {
                    summation += i;
                }
                label1.Text = summation.ToString(); 
            }
                else
                {
                    MessageBox.Show("please a right number");
                }
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int number))
            {
                int factorial = 1;
                for (int i = 2; i <= number; i++)
                {
                    factorial *= i;
                }
                label2.Text = factorial.ToString();
            }
            else
            {
                MessageBox.Show("please a right number");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double number))
            {
                double squareroot = Math.Sqrt(number);
                label3.Text = squareroot.ToString();
            }
            else
            {
                MessageBox.Show("please a right number or dicemal");
            }
        }
    }
}
