using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lect_6._1_معتصم_عبده_حميد
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Width = pictureBox1.Height = 300;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Image.FromFile(@"E:\c# prog\LECT (6)\lect 6.1 معتصم عبده حميد\pngtree-palestine-new-watercolor-flag-brush-png-image_8877436.png");
            pictureBox1.BackgroundImage = Image.FromFile(@"C:\Users\ALFASHEL\Downloads\Asset 6we can.jpg");
            ToolTip.Equals(pictureBox1, "picturebox1");
            this.AutoSize = true;
        }
    }
}
