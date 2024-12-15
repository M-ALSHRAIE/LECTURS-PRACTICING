using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace partial_lecture_7_form_3_معتصم_عبده_حميد_يحيى
{
    public partial class mult : Form
    {
        public mult()
        {
            InitializeComponent();
            txt_result_mult.Enabled = false;
            txt_num2_mult.KeyPress += txt_num1_mult_KeyPress;
        }
       
        private void btn_cals_mult_Click(object sender, EventArgs e)
        {
            txt_result_mult.Text = (Convert.ToInt32(txt_num1_mult.Text) *Convert.ToInt32(txt_num2_mult.Text)).ToString();
        }

        private void txt_num1_mult_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void btn_clear_mult_Click(object sender, EventArgs e)
        {

            txt_num1_mult.Clear();
            txt_num2_mult.Clear();
            txt_result_mult.Clear();
        }
    }
}
