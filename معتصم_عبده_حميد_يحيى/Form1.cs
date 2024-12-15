using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace معتصم_عبده_حميد_الشراعي
{
    public partial class Form1 : Form
    {
        public static string lable;
        public static int index = 0;
        public static int count = 0;
       // public static string username[] p = new username[20];
        public Form1()
        {
            InitializeComponent();
        }
        Form2 f2;
        private void Button1_Click(object sender, EventArgs e)
        {
            f2 = new Form2();
            f2.Show();
        }
    }
}
