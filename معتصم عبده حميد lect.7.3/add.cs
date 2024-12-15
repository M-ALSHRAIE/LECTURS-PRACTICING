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
    public partial class add : Form
    {
        public add()
        {
            InitializeComponent();
            txt_result_add.Enabled = false;
        }

        private void btn_cals_add_Click(object sender, EventArgs e)
        {
            txt_result_add.Text= (Convert.ToInt32(txt_num1_add.Text) + Convert.ToInt32(txt_num2_add.Text)).ToString();
        }

        private void txt_num1_add_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar<48||e.KeyChar>57)&&(e.KeyChar!=8))
            {
                e.Handled = true;
            }
        }

        private void btn_clear_add_Click(object sender, EventArgs e)
        {

            txt_num1_add.Clear();
            txt_num2_add.Clear();
            txt_result_add.Clear();
        }

        private void Add_Load(object sender, EventArgs e)
        {

        }
    }
}
