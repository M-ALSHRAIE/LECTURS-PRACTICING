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
    public partial class div : Form
    {
        private TextBox textBox1 = new TextBox();
        private Label label1 = new Label();
        private ListBox lsbx = new ListBox();
        
        public div()
        {
            InitializeComponent();
            txt_result_div.Enabled = false;
        }

        private void txt_num1_div_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void div_Load(object sender, EventArgs e)
        {
            this.txt_num1_div.Text = "div_n1";
            this.Text = "divid";
            this.Controls.Add(textBox1);
            this.textBox1.Text = "welcom";
            textBox1.Top=100;
            this.Controls.Add(lsbx);
            lsbx.Items.Add("+");
            lsbx.Items.Add("-");


        }

        private void btn_cals_div_Click(object sender, EventArgs e)
        {
            if (txt_num2_div.Text == "0")
            {
                MessageBox.Show("لا يمكنك القسمه على صفر", "تنبيه");
                txt_num2_div.Clear();
            }
            else
            {


                txt_result_div.Text = (Convert.ToInt32(txt_num1_div.Text) / Convert.ToInt32(txt_num2_div.Text)).ToString();
            }
        }

        private void btn_clear_div_Click(object sender, EventArgs e)
        {
            txt_num1_div.Clear();
            txt_num2_div.Clear();
            txt_result_div.Clear();
        }
    }
}
