using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace معتصم_عبده_حميد_يحيى
{
    public partial class Form3 : Form
    {
       
        public Form3()
        {
            InitializeComponent();
        }

        
      
        private void Button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text.Trim() != "")
            {
                

                MessageBox.Show("تم التعديل بنجاح");
                Close();

            }
            else
            {
                MessageBox.Show("ادخل التعديل");
                textBox1.Focus();
            }
        }
    }
}
