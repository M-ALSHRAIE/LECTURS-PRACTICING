using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lect6._4معتصم_عبده_حميد
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Bitmap mybitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            int x, y;
            for(x=0;x<100;x++)
            {
                y = x;
                mybitmap.SetPixel(x, y, Color.Red);
                mybitmap.SetPixel(x, 10, Color.Red);
                mybitmap.SetPixel(10, x, Color.Red);
            }
            pictureBox1.Image = mybitmap;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
