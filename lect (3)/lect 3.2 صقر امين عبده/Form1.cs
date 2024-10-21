using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lect_3._2_معتصم_عبده_حميد
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //اذا ظغطت على اي بوتن فيه اسم لون معين يغير 
     //  البوتن الرابع وخلفية البرنامج الى ذلك اللون المعين
        private void Btnyelow_Click(object sender, EventArgs e)
        {
            if (sender == btnyelow)
            {
                btnchick.BackColor = Color.Yellow;
               BackColor = Color.Yellow;
            }
        }
        private void Btngren_Click(object sender, EventArgs e)
        {
            if (sender == btngren)
            {
                btnchick.BackColor  = Color.Green;
                BackColor = Color.Green;
            }
        }
        private void Btnred_Click_1(object sender, EventArgs e)
        {
            if (sender == btnred)
            {
                btnchick.BackColor = Color.Red;
                BackColor = Color.Red;
            }
        }
    }
}
