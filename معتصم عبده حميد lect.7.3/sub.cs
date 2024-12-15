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
    public partial class sub : Form
    {
        public sub()
        {
            InitializeComponent();
            txt_result_sub.Enabled = false;
            txt_num1_sub.KeyPress += txt_num1_sub_keypress;
            txt_num2_sub.KeyPress += txt_num1_sub_keypress;
        }

        private void sub_Load(object sender, EventArgs e)
        {

        }
        private void txt_num1_sub_keypress(object sender,KeyPressEventArgs e)
        {

            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void btn_cals_sub_Click(object sender, EventArgs e)
        {
            txt_result_sub.Text = (Convert.ToInt32(txt_num1_sub.Text) -Convert.ToInt32(txt_num2_sub.Text)).ToString();
        }

        private void btn_clear_sub_Click(object sender, EventArgs e)
        {

            txt_num1_sub.Clear();
            txt_num2_sub.Clear();
            txt_result_sub.Clear();
        }
    }
}
